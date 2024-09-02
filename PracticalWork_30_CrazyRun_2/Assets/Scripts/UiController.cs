using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [SerializeField] private Text _textStarCount;

    [SerializeField] private Text _textCoinCount;
    
    [SerializeField] private Text _textStarCountInWinPanel;

    [SerializeField] private Text _textCoinCountInWinPanel;
    
    [SerializeField] private Text _textStarCountInGameOverPanel;

    [SerializeField] private Text _textCoinCountInGameOverPanel;

    private int starCount, coinCount;


    private void Start()
    {
        _textStarCount.text = "x 0";

        _textCoinCount.text = "x 0";
    }

    public void TextStarCount(StockController stockController) 
    {
        //_textStarCount.text = "x " + stockController.StarCount.ToString();
        starCount = stockController.StarCount;
        TextStarAndCoinCount();
    } 
    
    public void TextCoinCount(StockController stockController) 
    {
       //_textCoinCount.text = "x " + stockController.CoinCount.ToString();
       coinCount = stockController.CoinCount;
        TextStarAndCoinCount();
    }

    private void TextStarAndCoinCount()
    {       
        _textCoinCount.text = "x " + coinCount.ToString();
       
        _textCoinCountInGameOverPanel.text = "x " + coinCount.ToString();
       
        _textCoinCountInWinPanel.text = "x " + coinCount.ToString();
       
        _textStarCount.text = "x " + starCount.ToString();

        _textStarCountInGameOverPanel.text = "x " + starCount.ToString();
       
        _textStarCountInWinPanel.text = "x " + starCount.ToString();
    }
}
