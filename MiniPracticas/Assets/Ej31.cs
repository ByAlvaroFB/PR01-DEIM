using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej31 : MonoBehaviour
{
    public bool State = false;
    public int Minutos;
    public int Horas;
    public int x = 1;
    public int y = 1;

    // Start is called before the first frame update
    void Start()
    {

            StartCoroutine("Cronometro");

        
    }

    // Update is called once per frame
    void Update()
    {

        if (State == true)
        {
            Minutos = x++;
            StartCoroutine("Cronometro");
            State = false;
        }

        if (Minutos >= 60)
        {
            Horas = y++;
            x = 1;
            Minutos = 0;
        }

    }

    IEnumerator Cronometro()
    {
        for (int n = 1; ; n++)
        {
            int segundos;
            segundos = n;
            yield return new WaitForSeconds(1f);
            print("Horas " + Horas + " Minutos: " + Minutos + " Segundos: " + segundos);

            if (segundos >= 60)
            {
                State = true;
                StopCoroutine("Cronometro");

            }
        }


        }
}
