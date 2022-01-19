using UnityEngine;

public class init_player_stat : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("totalCoins", 0);   
    }
}
