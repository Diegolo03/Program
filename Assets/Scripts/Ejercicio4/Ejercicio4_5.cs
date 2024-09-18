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
            Debug.Log("�rea de la circunferencia = " + areaForma);
        if (id == 1)
            Debug.Log("�rea de la cuadrado = " + areaForma);
        if (id == 2)
            Debug.Log("�rea del tri�ngulo = " + areaForma);
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
            id = 0;
            areaElegida = areaCir;
        }
        if (areaUsando == "Cuad" || areaUsando == "cuad" || areaUsando == "cuadrado" || areaUsando == "Cuadrado")
        {
            areaCuad = (ladoCuad * ladoCuad);
            id = 1;
            areaElegida = areaCuad;
        }
        if (areaUsando == "Tri" || areaUsando == "tri" || areaUsando == "trin�gulo" || areaUsando == "trinagulo" || areaUsando == "Trinagulo" || areaUsando == "Tri�ngulo")
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
        if (moneda == "USD" || moneda == "dolar" || moneda == "dolares" || moneda == "d�lares")
        {
            float diferencia = 0.1009f;

            cantidad -= cantidad * diferencia;

            cambio = "Euros";
        }
        return cantidad;

    }
}
