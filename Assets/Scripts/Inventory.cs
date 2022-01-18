using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int coinsCount;
    public Text coinsCountText;

    public static Inventory instance;

    void Start()
    {
        coinsCountText.text = coinsCount.ToString();
    }
    
    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("+ d'un inventaire");
            return;
        }

        instance = this;
    }

    public void Addcoins(int count)
    {
        coinsCount+=count;
        coinsCountText.text = coinsCount.ToString();
    }
}
