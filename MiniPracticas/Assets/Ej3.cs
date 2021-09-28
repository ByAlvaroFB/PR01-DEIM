using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej3 : MonoBehaviour
{

    private float Var;


    // Start is called before the first frame update
    void Start()
    {

        Var = Multi(2, 0);
        print("El resultado es: " + Var);

    }

    // Update is called once per frame

    float Multi( int num1, int num2)
    {
        int RandomNumber = Random.Range(1, 20);

        int resultado;

        resultado = num1 + num2;

        if(resultado < RandomNumber)
        {
            print("Error");

        }

        if(resultado > RandomNumber)
        {
            print("Aceptado");
        }

        return resultado;
    }
}
