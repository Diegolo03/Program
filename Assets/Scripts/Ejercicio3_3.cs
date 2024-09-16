using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero ;
    // Start is called before the first frame update
    void Start()
    {
        int doble, triple;
        Debug.Log(numero);
        doble = numero * 2;
        Debug.Log("Doble " + doble);
        triple = numero * 3;
        Debug.Log("Triple " + triple);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
