using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidad1;
    // Start is called before the first frame update
    void Start()
    {
        Velocidades(velocidad1);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Velocidades(float velocidad1)
    {
        float velocidadMetros;
        //1

        Debug.Log("Coche 1:");

        Debug.Log("Velocidad km/h: " + velocidad1+"km/h");
        velocidadMetros = velocidad1 * 3.6f;
        Debug.Log("Velocidad m/s: " + velocidadMetros + "m/s");



    }
}
