using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int numero1, numero2;
    // Start is called before the first frame update
    void Start()
    {
 
        int numero3;
        numero3 = (numero1 / numero2);
        if (numero2 != 0)
        {

            Debug.Log("El resultado de la división es: " + numero3);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
