using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] int numero;
    int numero1 = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        while (numero1 <= numero)
        {
            Debug.Log(numero1);
            numero1++;
        }
        
        for (int i = numero1; i <= numero; i++)
        {
            Debug.Log(i);
        }
    }
    // Update is called once per frame
    void Update()
    {

        
    }
}
