using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemie : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name=="DeadMan")
        {
            SceneManager.LoadScene(0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
