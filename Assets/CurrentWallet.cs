using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


[System.Serializable]
public class CurrentWallet : MonoBehaviour
{
    
    public Text DonateValueText;
    public Text GoldValueText;
    [SerializeField]
    private int goldGameValue = 400;
    public int gold
    {
        get { return goldGameValue; }
        set { goldGameValue = value; }
    }
    [SerializeField]
    private int donateValue = 6;
    public int donate
    {
        get { return donateValue; }
        set { donateValue = value; }
    }
    void wallet()
    {
        DonateValueText.text = donateValue.ToString();
        GoldValueText.text = goldGameValue.ToString();
    }

    private void Start()
    {
        LoadGame();
    }

    private void Update()
    {
        wallet();
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt("SavedInteger", donateValue);
        PlayerPrefs.SetInt("SavedGold", goldGameValue);
        PlayerPrefs.Save();
    }

    void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedInteger"))
        {
            donateValue = PlayerPrefs.GetInt("SavedInteger");
            goldGameValue = PlayerPrefs.GetInt("SavedGold");
            Debug.Log("Game data loaded!");
        }
        else
        {
            PlayerPrefs.DeleteAll();
            donateValue = 8;
            goldGameValue = 600;
            Debug.Log("Data reset complete");
        }
    }
    public void ResetData()
    {
        PlayerPrefs.DeleteAll();
        donateValue = 8;
        goldGameValue = 600;
        Debug.Log("Data reset complete");
    }
}