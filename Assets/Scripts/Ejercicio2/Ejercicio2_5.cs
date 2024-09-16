using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidasPlayer1=10, vidasPlayer2=12, vidasPlayer3=14, vidasPlayer4=16;
    // Start is called before the first frame update
    void Start()
    {
        int vidasOriginal=vidasPlayer2;
        Debug.Log("vidasPlayer1 " + vidasPlayer1);
        Debug.Log("vidasPlayer2 " + vidasPlayer2);
        Debug.Log("vidasPlayer3 " + vidasPlayer3);
        Debug.Log("vidasPlayer4 " + vidasPlayer4);
        vidasPlayer2 = vidasPlayer3;
        Debug.Log("vidasPlayer2 " + vidasPlayer2);
        Debug.Log("vidasPlayer3 " + vidasPlayer3);
        vidasPlayer3 = vidasPlayer1;
        Debug.Log("vidasPlayer3 " + vidasPlayer3);
        Debug.Log("vidasPlayer1 " + vidasPlayer1);
        vidasPlayer1 = vidasPlayer4;
        Debug.Log("vidasPlayer1 " + vidasPlayer1);
        Debug.Log("vidasPlayer4 " + vidasPlayer4);
        vidasPlayer4 = vidasOriginal;
        Debug.Log("vidasPlayer4 " + vidasPlayer4);
        Debug.Log("vidasPlayer2 " + vidasOriginal);

        Debug.Log("Los resultados actuales son: ");

        Debug.Log("vidasPlayer1 " + vidasPlayer1);
        Debug.Log("vidasPlayer2 " + vidasPlayer2);
        Debug.Log("vidasPlayer3 " + vidasPlayer3);
        Debug.Log("vidasPlayer4 " + vidasPlayer4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
