using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] float baseTri, alturaTri, radioCir, ladoCuad;
    [SerializeField] string areaCalcular = "";
    float areaElegida = 0f, areaTri, areaCuad, areaCir;
    int id = 0;
    // Start is called before the first frame update
    void Start()
    {
       
       float resultadoTri= CalcularTriangulo(3f, 2f);
       float resultadoCuad= CalcularCuadrado(12f);
       float resultadoCir = CalcularCirculo(6f, 3.14159265359f);
        
        Debug.Log("Área de la circunferencia = " + resultadoCir);
            Debug.Log("Área de la cuadrado = " + resultadoCuad);
            Debug.Log("Área del triángulo = " + resultadoTri);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float CalcularTriangulo(float baseTri, float alturaTri)
    {
        float areaTri = baseTri * alturaTri / 2;
        return areaTri;
    }
    float CalcularCuadrado(float ladoCuad)
    {
        float areaCuad = (ladoCuad * ladoCuad);
        return areaCuad;
    }
    float CalcularCirculo(float radioCir, float pi)
    {
        float areaCir = pi * (radioCir * radioCir);
        return areaCir;
    }
}
