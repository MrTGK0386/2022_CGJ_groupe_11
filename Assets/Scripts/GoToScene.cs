using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoToScene : MonoBehaviour
{
    public int buildIndex; 
    // Start is called before the first frame update
    public void LoadScene()
    {
        SceneManager.LoadScene(buildIndex);
    }

}
