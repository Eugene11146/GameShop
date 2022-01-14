using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

public class SaveManager : MonoBehaviour
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
        PlayerPrefs.SetFloat("SavedFloat", gameBooster.activeTime);
        PlayerPrefs.Save();
    }

    void LoadGame()
    {
        if (PlayerPrefs.HasKey("SavedFloat"))
        {
            Buster.SetActive(true);
            gameBooster.activeTime = PlayerPrefs.GetFloat("SavedFloat");
            Debug.Log("Game data loaded!");
        }
        else
        {
            PlayerPrefs.DeleteAll();
            gameBooster.activeTime = 0;
            Debug.Log("Data reset complete");
        }
    }
}