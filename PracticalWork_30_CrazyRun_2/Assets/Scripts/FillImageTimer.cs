using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillImageTimer : MonoBehaviour
{
    [SerializeField] private Image _fillImageTimer;   

    public void FillImage(Timer timer)
    {
        _fillImageTimer.fillAmount = timer.CurrentTime / timer.MaxTime;
    }
}
