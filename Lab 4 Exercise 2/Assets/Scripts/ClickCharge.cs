using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ClickCharge : MonoBehaviour
{
    public static event Action clicked;

    private void OnMouseDown()
    {
        ChargeText.Instance.AddCharge(1);

        #region observer
        clicked?.Invoke();
        #endregion
    }
}
