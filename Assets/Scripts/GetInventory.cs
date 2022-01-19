using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static Inventory;

public class GetInventory : MonoBehaviour
{
    public Text coinsCountText;

    // Start is called before the first frame update
    void Start()
    {
       Inventory.instance.coinsCountText = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void OnDestroy(){
        Inventory.instance.coinsCountText = null;
    }
}
