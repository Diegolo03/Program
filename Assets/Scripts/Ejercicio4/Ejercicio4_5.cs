 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    [SerializeField] float baseTri, alturaTri, radioCir, ladoCuad;
    [SerializeField] string areaUsando = "", moneda = "";
    float areaElegida =0f;
    string cambio = "";

    // Start is called before the first frame update
    void Start()
    {
        float areaForma = CalcularArea(areaUsando);
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
        if (areaUsando == "Cir" || areaUsando == "cir" || areaUsando == "c�rculo" || areaUsando == "circulo" || areaUsando =="Circulo"|| areaUsando == "C�rculo")
        {
            areaCir = pi * (radioCir * radioCir);
            Debug.Log("�rea de la circunferencia = " + areaCir);
            areaElegida = areaCir;
        }
        if (areaUsando == "Cuad" || areaUsando == "cuad" || areaUsando == "cuadrado" || areaUsando == "Cuadrado")
        {
            areaCuad = (ladoCuad * ladoCuad);
            Debug.Log("�rea de la cuadrado = " + areaCuad);
            areaElegida = areaCuad;
        }
        if (areaUsando == "Tri" || areaUsando == "tri" || areaUsando == "trin�gulo" || areaUsando == "trinagulo" || areaUsando == "Trinagulo" || areaUsando == "Tri�ngulo")
        {
            areaTri = (baseTri * alturaTri) / 2;
            Debug.Log("�rea del tri�ngulo = " + areaTri);
            areaElegida = areaTri;
        }
        return areaElegida;
        
        
    }
  
    float ConvertirDinero(string moneda)
    {
        float cantidad = areaElegida;
        if (areaUsando == "EUR" || areaUsando == "euro" || moneda == "euros")
        {
            float diferencia = 0.1122f;

            cantidad += cantidad * diferencia;

            cambio = "Dolares";
        }
        if (areaUsando == "USD" || areaUsando == "dolar" || moneda == "dolares" || moneda == "d�lares")
        {
            float diferencia = 0.1009f;

            cantidad -= cantidad * diferencia;

            cambio = "Euros";
        }
        return cantidad;

    }
}
