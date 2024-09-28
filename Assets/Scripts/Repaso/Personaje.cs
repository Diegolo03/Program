using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    private string nombre;
    private float vida, experiencia, nivel;

    public string Nombre { get => nombre; set => nombre = value; }
    public float Vida { get => vida; set => vida = value; }
    public float Experiencia { get => experiencia; set => experiencia = value; }
    public float Nivel { get => nivel; set => nivel = value; }

    public float CalcularNivel()
    {
        nivel = experiencia / 1000;
        return nivel;
    }
    void Mover()
    {

    }
    void Atacar()
    {

    }
    void Saltar()
    {

    }

}
