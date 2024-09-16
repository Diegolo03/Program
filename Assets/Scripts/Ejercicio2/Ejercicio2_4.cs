using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 10;
    // Start is called before the first frame update
    void Start()
    {
        vidas += 77;
        Debug.Log(vidas);
        vidas -=3;
        Debug.Log(vidas);
        vidas *= 4;
        Debug.Log(vidas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
