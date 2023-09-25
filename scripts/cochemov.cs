using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using TMPro;

public class cochemov : MonoBehaviour
{
    public InputAction cerrar;
    public InputAction movimiento; //estamos declarando la variable que permitirá el movimiento
    CharacterController controlar; //le asiganmos un controlador al objeto que recive el script
    public Vector3 direccionMovimiento; //declaramos un vector tridimensional
    public float velocidad =0;
    public int vueltas = 0;
    public bool puntoguar = false;
    int max = 20;
    int min = -20;
    float friccion = 0.3f;
    public TMP_Text cantidadvueltas;

    // Start is called before the first frame update
    void Start()
    {
        movimiento.Enable(); //activador de la variable moviiento
        controlar = gameObject.GetComponent<CharacterController>(); //le asiga a la variable controlar el objeto a mover
        cerrar.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 miDireccion = movimiento.ReadValue<Vector2>(); //creamos un vector bidimensional (eje "x" y "y")
        velocidad = velocidad + miDireccion.y * 0.4f;
        transform.Rotate(transform.up, miDireccion.x * (velocidad * 0.1f)); //realizar giro respecto al eje x
        controlar.SimpleMove(transform.forward * velocidad); //especifica una velocidad independiente a los fps
        if (velocidad > max)
        {
            velocidad = max;
        }
        if (velocidad < min)
        {
            velocidad = min;
        }
        if (velocidad > 0)
        {
            velocidad = velocidad - friccion;
        }
        cantidadvueltas.text = "vuelta " + vueltas +  "/3";
        if (cerrar.triggered)
        {
            Debug.Log("funciono");
            Application.Quit();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("he chocado con " + other.gameObject.name);

        if (other.gameObject.name == "meta" && puntoguar==true)
        {
            vueltas = vueltas + 1;
            puntoguar = false;

                if(vueltas>2)
                {
                    //he ganado
                    SceneManager.LoadScene("Ganar");
                }
            
        }


        if (other.gameObject.name == "checkpoint")
        {
            puntoguar = true;
        }

        if (other.gameObject.name == "turbo")
        {
            max= max + 1;
            velocidad = velocidad + 2;
        }

        if (other.gameObject.name == "desturbo")
        {
            velocidad = velocidad * 0.2f;
        }

    }
}
