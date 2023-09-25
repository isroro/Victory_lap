using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class menu : MonoBehaviour
{
    public GameObject botoncontroles;
    public GameObject botonjuego;
    public InputAction cerrar;
    // Start is called before the first frame update
    void Start()
    {
        cerrar.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (cerrar.triggered)
        {
            Debug.Log("funciono");
            Application.Quit();
        }
    }
    public void controles()
    {
        SceneManager.LoadScene("controles");
    }
    public void juego()
    {
        SceneManager.LoadScene("juego");
    }
}
