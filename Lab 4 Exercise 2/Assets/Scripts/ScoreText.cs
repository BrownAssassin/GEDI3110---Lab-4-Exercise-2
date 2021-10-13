using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private int _score;
    private Text _text;

    public static ScoreText Instance {get; private set;}

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

    void Update()
    {
        if (ChargeText.Instance.GetCharge() == 10)
        {
            _score++;
            _text.text = _score.ToString();
            ChargeText.Instance.ResetCharge();
        }
    }
}
