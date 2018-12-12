using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nepe : MonoBehaviour
{
    int cuenta = 0;
    public KeyCode teclaD = KeyCode.D;
    public KeyCode teclaW = KeyCode.W;
    public KeyCode teclaS = KeyCode.S;
    float movimiento = 1f;
    public Text marcador;
    public Text victoria;
    public string nombre;
    // Update is called once per frame
    void Update()
    {
        if (cuenta == 45)
        {
            victoria.text = "Winner is: " + nombre; 
                  
        }
        else
        {
            if (Input.GetKeyDown(teclaD))
            {
                this.transform.Translate(new Vector3(0, movimiento , 0));
                cuenta++;
                marcador.text = "" + cuenta;
            }else if (Input.GetKeyDown(teclaW))
            {
                this.transform.Translate(new Vector3(-movimiento, 0, 0));
               
            }
            else if (Input.GetKeyDown(teclaS))
            {
                this.transform.Translate(new Vector3(movimiento, 0, 0));

            }
        }
    }
}

