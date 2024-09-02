using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WinLevel : MonoBehaviour
{
    [SerializeField] private UnityEvent<WinLevel> winEvent;

    private void OnTriggerEnter(Collider other)
    {
        winEvent?.Invoke(this);
    }
}
