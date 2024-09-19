using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Apuntes : MonoBehaviour
{
    //apoyado en el doc
    // [SerializeField] para que sea como un public a diferencia no puedo ponerle el static
    // Start is called before the first frame update
    int pocion = 3;
    int vida = 10;
    void Start()
    {
        SumarN(vida, pocion);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SumarN(int numeroA, int numeroB)
    {
        numeroA += 4;
    }
    //1. PARA PARAMETRIZAR EL METODO se inicia con Nombre(numero1,numero2); void Nombre(float1,float2,float3, etc...) hay que rellenar todso los huecos asignados en el void y en su orden correcto
    //2. Para cambiar el nombre con CTRL+R, CTRL+R

    //3. El if, si pones if doble tab se rellena, se puede meter dentro del parentesis parametros para entrar o no entrar, && -> and, || -> or, ! -> not .
    //Ejemplo if carnet:
    //[SerializeField]bool carnetConducir;
    //if (carnetConducir==true)
    //{
    //   Debug.Log("Puedo conducir!");
    //}

    //for el for es un bucle que se ha de completyar para llenarse el anterior va de dentro a fuera
    //for (int niveles = 0; niveles< 5; niveles++) //Nivel = 1
    //    {
    //        for (int rondas = 0; rondas< 10; rondas++) //Ronda = 0, 1, 2, 3.....9
    //        {
    //            Debug.Log("Voy por la ronda: " + rondas + " del nivel " + niveles);
    //        }
    //    }



}
