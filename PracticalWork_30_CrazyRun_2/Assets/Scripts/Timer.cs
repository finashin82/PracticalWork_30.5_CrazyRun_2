using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private int maxTime;

    [SerializeField] private UnityEvent<Timer> timeEvent;
    public float CurrentTime => currentTime;
    public float MaxTime => maxTime;
    public bool IsTimeForGame => currentTime > 0; 

    private float currentTime;   

    private void Awake()
    {
        currentTime = maxTime;       
    }

    void Update()
    {
        currentTime -= Time.deltaTime;

        timeEvent?.Invoke(this);       
    }
}
