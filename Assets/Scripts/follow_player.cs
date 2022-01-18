using UnityEngine;
using System.Collections;


public class follow_player : MonoBehaviour
{
    public Transform player;
    void Update () 
    {
        transform.position = new Vector3 (0, player.position.y,-10);
    }
}
