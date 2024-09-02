using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Increase : MonoBehaviour
{
    [SerializeField] private UnityEvent<Increase> starEvent;

    [SerializeField] private UnityEvent<Increase> coinEvent;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Star"))
        {   
            GameObject.Destroy(other.gameObject);
            starEvent?.Invoke(this);
        }

        if (other.gameObject.CompareTag("Coin"))
        {
            GameObject.Destroy(other.gameObject);
            coinEvent?.Invoke(this);
        }
    }
}
