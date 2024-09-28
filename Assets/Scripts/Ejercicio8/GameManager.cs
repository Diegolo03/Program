using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] bool yaEjecutado = false;
    [SerializeField] Personaje Pikachu;
    [SerializeField] Personaje Charmander;
    
    //Fernando no entiendo muy bien el resto de apartados del ejercicio, no es que no sepa hacerlos, sino que no entioendo los enunciados me han estado costando un montón hice el 8_1, seguire intentando el resto pero no se muy bien como hacerlo

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && yaEjecutado==false)
        {
            PrepararPersonajes();

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

