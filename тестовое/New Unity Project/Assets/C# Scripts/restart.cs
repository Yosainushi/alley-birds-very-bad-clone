 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    [SerializeField]
    public  GameObject Pause;
    void Start()
    {
        Pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart()
    { 
        Pause.SetActive(false);
        SceneManager.LoadScene("save");
    }
    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }
}
