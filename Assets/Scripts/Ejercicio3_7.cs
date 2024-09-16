using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float baseTri, alturaTri;
    // Start is called before the first frame update
    void Start()
    {
        float area;
        area = (baseTri * alturaTri) / 2;
        Debug.Log("Área del triángulo = " + area);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
