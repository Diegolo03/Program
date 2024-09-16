using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] float baseTri, alturaTri, radioCir, ladoCuad;
    // Start is called before the first frame update
    void Start()
    {
        float areaTri, areaCir, areaCuad, pi = 3.14159265359f;
        areaCir = pi * (radioCir * radioCir);
        Debug.Log("Área de la circunferencia = " + areaCir);
        areaCuad = (ladoCuad * ladoCuad);
        Debug.Log("Área de la cuadrado = " + areaCuad);
        areaTri = (baseTri * alturaTri) / 2;
        Debug.Log("Área del triángulo = " + areaTri);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
