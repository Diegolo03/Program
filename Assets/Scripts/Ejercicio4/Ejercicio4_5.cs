 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    [SerializeField] float baseTri, alturaTri, radioCir, ladoCuad;
    [SerializeField] string areaUsando = "", moneda = "";
    float areaElegida =0f;
    string cambio = "";
    int id = 0;

    // Start is called before the first frame update
    void Start()
    {
        


        float resultado = ConvertirDinero(moneda, 3f);
        Debug.Log("Son " + resultado + " " + cambio);


       float resultadoTri= CalcularTriangulo(3f, 2f);
       float resultadoCuad= CalcularCuadrado(12f);
       float resultadoCir = CalcularCirculo(6f, 3.14159265359f);
        ConvertirDinero(moneda, resultadoCir);
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
    //float CalcularArea(string areaUsando)
    //{
    //    float areaTri, areaCir, areaCuad, pi = 3.14159265359f;
    //    if (areaUsando == "Cir" || areaUsando == "cir" || areaUsando == "círculo" || areaUsando == "circulo" || areaUsando =="Circulo"|| areaUsando == "Círculo")
    //    {
    //        areaCir = pi * (radioCir * radioCir);
    //        id = 0;
    //        areaElegida = areaCir;
    //    }
    //    if (areaUsando == "Cuad" || areaUsando == "cuad" || areaUsando == "cuadrado" || areaUsando == "Cuadrado")
    //    {
    //        areaCuad = (ladoCuad * ladoCuad);
    //        id = 1;
    //        areaElegida = areaCuad;
    //    }
    //    if (areaUsando == "Tri" || areaUsando == "tri" || areaUsando == "triángulo" || areaUsando == "triangulo" || areaUsando == "Triangulo" || areaUsando == "Triángulo")
    //    {
    //        areaTri = (baseTri * alturaTri) / 2;
    //        id = 2;
    //        areaElegida = areaTri;
    //    }
    //    return areaElegida;
        
    //}
  
    float ConvertirDinero(string moneda, float cantidad)
    {
        
        if (moneda == "EUR" || moneda == "euro" || moneda == "euros")
        {
            float diferencia = 0.1122f;

            cantidad += cantidad * diferencia;

            cambio = "Dolares";
        }
        if (moneda == "USD" || moneda == "dolar" || moneda == "dolares" || moneda == "dólares")
        {
            float diferencia = 0.1009f;

            cantidad -= cantidad * diferencia;

            cambio = "Euros";
        }
        return cantidad;

    }
}
