using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] int numero;
    
    // Start is called before the first frame update
    void Start()
    {
        if ((numero/1)==0)
        {
            if ((numero % numero) == 0)
            {

                if ((numero % 4) != 0)
                {
                    Debug.Log("No es primo");
                }
                else
                {
                    Debug.Log("Es primo");
                }
            
            }


        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
