using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeText : MonoBehaviour
{
    private int _charge;
    private Text _text;

    public static ChargeText Instance {get; private set;}

    private void Awake()
    {
        if (Instance == null)
        {
            _text = GetComponent<Text>();
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddCharge(int value)
    {
        _charge += value;
        _text.text = _charge.ToString();
    }

    public int GetCharge()
    {
        return _charge;
    }

    public void ResetCharge()
    {
        _charge = 0;
        _text.text = _charge.ToString();
    }
}
