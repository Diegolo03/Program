using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{

   [SerializeField] int numero;
    int numero1 = 1;
    // Start is called before the first frame update
    void Start()
    {
        if (numero > numero1)
        {
            for (int i = numero; i >= numero1; i--)
            {
                if (i % 3 == 0)
                {
                    Debug.Log(i);
                }
            }
        }
        else
        {
            for (int i = numero; i <= numero1; i++)
            {
                if (i % 3 == 0)
                {
                    Debug.Log(i);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
