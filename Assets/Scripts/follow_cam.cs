using UnityEngine;
using System.Collections;


public class follow_cam : MonoBehaviour
{
    public Transform Canvas;
    void Update () 
    {
        transform.position = new Vector3 (0, Canvas.position.y,-10);
    }
}
