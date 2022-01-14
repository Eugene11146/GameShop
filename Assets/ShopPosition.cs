using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ShopPosition : MonoBehaviour
{
    private CurrentWallet currentWallet;
    public GameObject notEnoughValue;
    private GameBooster gameBooster;
    public GameObject blockImage;
    public GameObject Wallet;
    public GameObject Buster;
    public int TimeBuster;
    public int priceDonation;
    public int priceGold;

    public void Start()
    {
        currentWallet = Wallet.GetComponent(typeof(CurrentWallet)) as CurrentWallet;
        gameBooster = Buster.GetComponent(typeof(GameBooster)) as GameBooster;
    }
    public void ButtonPayDonateValue()
    {
        if (currentWallet.donate >= priceDonation)
        {
            currentWallet.donate -= priceDonation;
            Buster.SetActive(true);
            blockImage.SetActive(false);
            gameBooster.activeTime += TimeBuster;
        }
        else
        {
            notEnoughValue.SetActive(true);
        }
       currentWallet.SaveGame();
    }

    public void ButtonPayGoldGame()
    {
        if (currentWallet.gold >= priceGold)
        {
            currentWallet.gold -= priceGold;
            Buster.SetActive(true);
            blockImage.SetActive(false);
            gameBooster.activeTime += TimeBuster;
        }
        else
        {
            notEnoughValue.SetActive(true);
        }
        currentWallet.SaveGame();
    }
}


