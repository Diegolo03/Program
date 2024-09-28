using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private bool yaEjecutado = false;
    private Personaje Pikachu;
    private Personaje Charmander;
    


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && yaEjecutado==false)
        {
            PrepararPersonajes();
        }
        else if (Input.GetKeyDown(KeyCode.Space) && yaEjecutado ==true)
        {
            Debug.Log("YA LO HAS EJECUTADO");
            
        }
    }

    void PrepararPersonajes()
    {
        Pikachu = new Personaje();
        Charmander = new Personaje();
        Pikachu.Experiencia = 3000;
        Pikachu.Nombre = "Pikachu";
        Pikachu.Vida = 200;
        Charmander.Experiencia = 2000;
        Charmander.Nombre = "Charmander";
        Charmander.Vida = 100;


        Debug.Log( "Nivel de Pikachu: " + Pikachu.CalcularNivel());


        Debug.Log("Nivel de Charmander: " + Charmander.CalcularNivel());
        yaEjecutado = true;

    }













}

