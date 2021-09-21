using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{

    int Valor = 0;
    int x;
    [SerializeField] int speed;
    bool Estado = true;
    private int stringTime;


    // Start is called before the first frame update
    void Start()
    {
        x = 1;
        speed = 1;

        while (Valor <= 100)
        {
            print("Contador " + Valor);
            Valor = x++ * speed;
        }

        if (Valor >= 100)
        {
            Estado = false;
            print("El contador llego a su fin");
            Valor = x++ * speed;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


}
