using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] float baseTri, alturaTri, radioCir, ladoCuad;
    [SerializeField] string areaCalcular = "";
    float areaElegida = 0f;
    int id = 0;
    // Start is called before the first frame update
    void Start()
    {
        float areaForma = CalcularArea(areaCalcular);
        
        if (id == 0)
        Debug.Log("�rea de la circunferencia = " + areaForma);
        if (id == 1)
            Debug.Log("�rea de la cuadrado = " + areaForma);
        if (id == 2)
            Debug.Log("�rea del tri�ngulo = " + areaForma);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float CalcularArea(string areaCalcular)
    {
        float areaTri, areaCir, areaCuad, pi = 3.14159265359f;
        if (areaCalcular == "Cir" || areaCalcular == "cir" || areaCalcular == "c�rculo" || areaCalcular == "circulo" || areaCalcular == "Circulo" || areaCalcular == "C�rculo")
        {
            areaCir = pi * (radioCir * radioCir);
            id = 0;
            areaElegida = areaCir;
        }
        if (areaCalcular == "Cuad" || areaCalcular == "cuad" || areaCalcular == "cuadrado" || areaCalcular == "Cuadrado")
        {
            areaCuad = (ladoCuad * ladoCuad);
            id = 1;
            areaElegida = areaCuad;
        }
        if (areaCalcular == "Tri" || areaCalcular == "tri" || areaCalcular == "trin�gulo" || areaCalcular == "trinagulo" || areaCalcular == "Trinagulo" || areaCalcular == "Tri�ngulo")
        {
            areaTri = (baseTri * alturaTri) / 2;
            id = 2;
            areaElegida = areaTri;
        }
        return areaElegida;


    }
}
