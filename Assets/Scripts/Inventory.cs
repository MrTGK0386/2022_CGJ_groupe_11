using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int coinsCount;
    public int shield;
    public int fuel;
    public int oxygen;
    public int motor;
    public Text coinsCountText;

    public static Inventory instance;
/*
    void Start()
    {   
        //coinsCount=PlayerPrefs.GetInt("totalCoins");
        coinsCountText.text = coinsCount.ToString();
    }*/
    
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance != null)
        {
            Debug.LogWarning("+ d'un inventaire");
            return;
        }
        instance = this;
        //PlayerPrefs.SetInt("totalCoins", coinsCount);
        //coinsCountText.text = coinsCount.ToString();
     }

    public void Addcoins(int count)
    {
        coinsCount+=count;
        coinsCountText.text = coinsCount.ToString();
    }
}
