using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    // Start is called before the first frame update
    void Start()
    {
        float longitud, area, pi= 3.14159265359f;
        longitud = 2f * pi * radio;
        area = pi * (radio *radio);
        Debug.Log("Longitud de la circunferencia = "+longitud);
        Debug.Log("Área de la circunferencia = "+area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
