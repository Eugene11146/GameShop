using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class SaveManBost3 : MonoBehaviour
{
    private GameBooster gameBooster;
    public GameObject Buster;

    private void FixedUpdate()
    {
        SaveGame();
    }
    private void Start()
    {
        gameBooster = Buster.GetComponent(typeof(GameBooster)) as GameBooster;
        LoadGame();
    }

    void SaveGame()
    {
        PlayerPrefs.SetFloat("SavedFloat3", gameBooster.activeTime);
        PlayerPrefs.Save();
    }

    void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedFloat3"))
        {
            Buster.SetActive(true);
            gameBooster.activeTime = PlayerPrefs.GetFloat("SavedFloat3");
        }
        else
        {
            PlayerPrefs.DeleteAll();
            gameBooster.activeTime = 0;
            Debug.Log("Data reset complete");
        }
    }
}
