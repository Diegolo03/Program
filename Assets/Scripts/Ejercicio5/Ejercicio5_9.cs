using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    int da�o = 0, vida = 0;
    // Start is called before the first frame update
    void Start()
    {
       
        if (tipo == 1)
        {
            da�o = 350;
            vida = 650;
        }
        else if (tipo == 2)
        {
            da�o = 300;
            vida = 550;
        }
        else if (tipo == 3)
        {
            da�o = 300;
            vida = 500;
        }
        else if (tipo == 4)
        {
            da�o = 310;
            vida = 460;
        }
        else if (tipo == 5)
        {
            da�o = 280;
            vida = 490;
        }
        else if (tipo == 6)
        {
            da�o = 360;
            vida = 520;
        }
        Debug.Log("Enemigo tipo "+ tipo + " generado:");
        Debug.Log("Da�o: "+ da�o);
        Debug.Log("Vida: "+ vida);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
