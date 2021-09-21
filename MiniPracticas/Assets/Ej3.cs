using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3 : MonoBehaviour
{

    private float Var;
    bool state;
    bool state1;

    // Start is called before the first frame update
    void Start()
    {
        Var = Multi(6, 0);
        print("El resultado es: " + Var);

    }

    // Update is called once per frame

    float Multi(int num1, int num2)
    {
        int resultado;

        resultado = num1 + num2;

        if(resultado < 5)
        {
            print("Error");

        }

        if(resultado > 5)
        {
            print("Aceptado");
        }

        return resultado;
    }
}
