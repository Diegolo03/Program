using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    [SerializeField] float velocidad1;
    // Start is called before the first frame update
    void Start()
    {
        float conversion = Velocidades(velocidad1);
        Debug.Log("Coche:");

        Debug.Log("Velocidad km/h: " + velocidad1 + "km/h");
        
        Debug.Log("Velocidad m/s: " + conversion + "m/s");
    }

    // Update is called once per frame
    void Update()
    {

    }
    float Velocidades(float velocidad1)
    {
        float velocidadMetros;
        

        velocidadMetros = velocidad1 * 3.6f;

        return velocidadMetros;

    }
}
