using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class postjuego : MonoBehaviour
{
    public GameObject botoninicio;
    public GameObject botonjuego;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void inicio()
    {
        SceneManager.LoadScene("inicio");
    }
    public void juego()
    {
        SceneManager.LoadScene("juego");
    }
}
