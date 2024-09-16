using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    int vida;
    float porcentajeAcierto;
    bool quemado;
    string explorador;
    char solucionPuzzle;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¡Hola Mundo!");
        Debug.Log("Este es el primer videojuego de Diego");
        Debug.Log("Estoy aprendiendo C#");
        

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Ha pasado un frame");
        //Este mensaje al igual que el anterior, se repite sucesivamente ya que la funcion del void update se repite cada frame a diferencia de del void start 
    }
}
