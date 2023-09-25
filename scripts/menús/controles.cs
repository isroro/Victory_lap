using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class controles : MonoBehaviour
{
    public GameObject botoninicio;
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
    public void inicio()
    {
        SceneManager.LoadScene("inicio");
    }
}
