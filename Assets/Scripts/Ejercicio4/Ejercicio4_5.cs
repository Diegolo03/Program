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
        float areaForma = CalcularArea(areaUsando);
        if (id == 0)
            Debug.Log("Área de la circunferencia = " + areaForma);
        if (id == 1)
            Debug.Log("Área de la cuadrado = " + areaForma);
        if (id == 2)
            Debug.Log("Área del triángulo = " + areaForma);
        float resultado = ConvertirDinero(moneda);
        Debug.Log("Son " + resultado + " " + cambio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float CalcularArea(string areaUsando)
    {
        float areaTri, areaCir, areaCuad, pi = 3.14159265359f;
        if (areaUsando == "Cir" || areaUsando == "cir" || areaUsando == "círculo" || areaUsando == "circulo" || areaUsando =="Circulo"|| areaUsando == "Círculo")
        {
            areaCir = pi * (radioCir * radioCir);
            id = 0;
            areaElegida = areaCir;
        }
        if (areaUsando == "Cuad" || areaUsando == "cuad" || areaUsando == "cuadrado" || areaUsando == "Cuadrado")
        {
            areaCuad = (ladoCuad * ladoCuad);
            id = 1;
            areaElegida = areaCuad;
        }
        if (areaUsando == "Tri" || areaUsando == "tri" || areaUsando == "trinágulo" || areaUsando == "trinagulo" || areaUsando == "Trinagulo" || areaUsando == "Triángulo")
        {
            areaTri = (baseTri * alturaTri) / 2;
            id = 2;
            areaElegida = areaTri;
        }
        return areaElegida;
        
        
    }
  
    float ConvertirDinero(string moneda)
    {
        float cantidad = areaElegida;
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
