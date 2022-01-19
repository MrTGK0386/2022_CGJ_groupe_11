using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat_manager : MonoBehaviour
{
    public int coins;
    public int shield;
    public int fuel;
    public int oxygen;
    public int motor;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
