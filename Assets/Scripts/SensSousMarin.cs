using UnityEngine;

public class SensSousMarin : MonoBehaviour
{

    
    private Transform Player;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {   
        float dirX = Input.GetAxis("Horizontal");
        if(dirX<0)
        {
            GetComponent<SpriteRenderer>().flipX=true;
//            transform.localScale = new Vector3(-1,1,1);
            
        }
        else if(dirX>0)
        {
            GetComponent<SpriteRenderer>().flipX=false;
//            transform.localScale = new Vector3(1,1,1);
        }
    }
}
