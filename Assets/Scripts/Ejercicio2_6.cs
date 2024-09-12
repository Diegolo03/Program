using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1=10,puntuacion2=12,puntuacion3=14, media;
    // Start is called before the first frame update
    void Start()
    {
        media = (puntuacion1 + puntuacion2 + puntuacion3) / 3;
        Debug.Log("puntuacion1 " + puntuacion1);
        Debug.Log("puntuacion2 " + puntuacion2);
        Debug.Log("puntuacion3 " + puntuacion3);
        Debug.Log("media " + media);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
