using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    [SerializeField] int numero, numero1;
    int numeroTotal;
    // Start is called before the first frame update
    void Start()
    {
        for (int numero=0; numero != numero1; numeroTotal += numero + 1)
        {
            Debug.Log(numeroTotal);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
