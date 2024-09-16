using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] float experiencia;
    // Start is called before the first frame update
    void Start()
    {
        float level;
        level = 32 + (9 * experiencia / 5);
        Debug.Log("Tú nivel es el: " + level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
