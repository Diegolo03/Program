using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidad1, velocidad2, velocidad3, velocidad4, velocidad5;
    // Start is called before the first frame update
    void Start()
    {
        Velocidades(velocidad1, velocidad2, velocidad3, velocidad4, velocidad5);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Velocidades(float velocidad1, float velocidad2, float velocidad3,float velocidad4, float velocidad5)
    {
        float velocidadMetros;
        //1

        Debug.Log("Coche 1:");

        Debug.Log("Velocidad km/h: " + velocidad1+"km/h");
        velocidadMetros = velocidad1 * 3.6f;
        Debug.Log("Velocidad m/s: " + velocidadMetros + "m/s");


        //2
        Debug.Log("Coche 2:");

        Debug.Log("Velocidad km/h: " + velocidad2 + "km/h");
        velocidadMetros = velocidad2 * 3.6f;
        Debug.Log("Velocidad m/s: " + velocidadMetros + "m/s");

        //3
        Debug.Log("Coche 3:");

        Debug.Log("Velocidad km/h: " + velocidad3 + "km/h");
        velocidadMetros = velocidad3 * 3.6f;
        Debug.Log("Velocidad m/s: " + velocidadMetros + "m/s");

        //4
        Debug.Log("Coche 4:");

        Debug.Log("Velocidad km/h: " + velocidad4 + "km/h");
        velocidadMetros = velocidad4 * 3.6f;
        Debug.Log("Velocidad m/s: " + velocidadMetros + "m/s");

        //5
        Debug.Log("Coche 5:");

        Debug.Log("Velocidad km/h: " + velocidad5 + "km/h");
        velocidadMetros = velocidad5 * 3.6f;
        Debug.Log("Velocidad m/s: " + velocidadMetros + "m/s");


    }
}
