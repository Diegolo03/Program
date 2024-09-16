using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    float vidaPlayer = 120f, venenoPorRonda=0f;
    // Start is called before the first frame update
    void Start()
    {
        Rondas(1,2,3,4,5);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Rondas(int ronda1, int ronda2, int ronda3, int ronda4, int ronda5) 
    {
        float vidaOriginal = vidaPlayer, venenoInicial = 0.03f;
        //1

        Debug.Log("Ronda "+ronda1);
        
        Debug.Log("Vida Inicial: " + vidaPlayer);
        venenoPorRonda = venenoInicial * ronda1;
        Debug.Log("Veneno: " + venenoPorRonda);
        vidaPlayer -= vidaOriginal*venenoPorRonda;
        Debug.Log("Vida Actual: " + vidaPlayer);

        //2
        Debug.Log("Ronda " + ronda2);

        Debug.Log("Vida Inicial: " + vidaPlayer);
        venenoPorRonda = venenoInicial * ronda2;
        Debug.Log("Veneno: " + venenoPorRonda);
        vidaPlayer -= vidaOriginal * venenoPorRonda;
        Debug.Log("Vida Actual: " + vidaPlayer);

        //3
        Debug.Log("Ronda " + ronda3);
        
        Debug.Log("Vida Inicial: " + vidaPlayer);
        venenoPorRonda = venenoInicial * ronda3;
        Debug.Log("Veneno: " + venenoPorRonda);
        vidaPlayer -= vidaOriginal * venenoPorRonda;
        Debug.Log("Vida Actual: " + vidaPlayer);

        //4
        Debug.Log("Ronda " + ronda4);

        Debug.Log("Vida Inicial: " + vidaPlayer);
        venenoPorRonda = venenoInicial * ronda4;
        Debug.Log("Veneno: " + venenoPorRonda);
        vidaPlayer -= vidaOriginal * venenoPorRonda;
        Debug.Log("Vida Actual: " + vidaPlayer);

        //5
        Debug.Log("Ronda " + ronda5);

        Debug.Log("Vida Inicial: " + vidaPlayer);
        venenoPorRonda = venenoInicial * ronda5;
        Debug.Log("Veneno: " + venenoPorRonda);
        vidaPlayer -= vidaOriginal * venenoPorRonda;
        Debug.Log("Vida Actual: " + vidaPlayer);


    }
}
