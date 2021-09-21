using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{

    private string nombre = "Profe";
    private int nota01 = 5;
    private int nota02 = 5;
    private int notafinal;

    // Start is called before the first frame update
    void Start()
    {
        print("Hola " + nombre);
        notafinal = nota01 + nota02;
        print("Espero que me pongas un " + notafinal);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
