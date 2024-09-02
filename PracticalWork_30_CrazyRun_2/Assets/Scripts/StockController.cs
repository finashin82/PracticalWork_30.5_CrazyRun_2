using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StockController : MonoBehaviour
{
    [SerializeField] private UnityEvent<StockController> uiStarCount;

    [SerializeField] private UnityEvent<StockController> uiCoinCount;

    public int CoinCount => coinCount;

    public int StarCount => starCount;

    private int starCount, coinCount;    
    
    void Start()
    {
        starCount = 0;

        coinCount = 0;
    }
   
    public void StarCountInGame()
    {
        starCount++;

        uiStarCount?.Invoke(this);       
    }
    
    public void CoinCountInGame()
    {
        coinCount++;

        uiCoinCount?.Invoke(this);
    }
}
