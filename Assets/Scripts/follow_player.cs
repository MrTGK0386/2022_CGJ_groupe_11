using UnityEngine;
using System.Collections;


public class follow_player : MonoBehaviour
{
    public Transform player;
    void Update () 
    {
        transform.position = new Vector3 (player.position.x, 0,-10);
    }
}
