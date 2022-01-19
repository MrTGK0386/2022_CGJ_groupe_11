using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        float dirX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(dirX * 6f, rb.velocity.y);
        
        if (Input.GetButtonDown("Horizontal"))
        {
            rb.velocity = new Vector3();
        }
        if (Input.GetButtonDown("escape"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
