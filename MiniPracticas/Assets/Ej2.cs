using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{

    int Valor;
    int x;

    // Start is called before the first frame update
    void Start()
    {
        x = 1;

        int randomResult = Random.Range(1, 100);

        while (Valor != randomResult)
        {
            //int randomNumber = Random.Range(1, 101);
            print("Vamos por: " + Valor);
            Valor = x++;
        }

            print("El contador llego a su fin, el resultado fue " + Valor);
        

    }

    // Update is called once per frame
    void Update()
    {
    
    }


}
