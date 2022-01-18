using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int coinsCount;

    public static Inventory instance;

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
    }
}
