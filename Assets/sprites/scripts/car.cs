using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class car : MonoBehaviour {
    float velocidad = 1f;
    public KeyCode teclaAsignada = KeyCode.F1;
    public string nombre;
    int cuenta = 0;
    public GameObject canvas;

	void Update () {
        ExecuteEvents.Execute<IMisEventosCanvas>(canvas, null, (x, y) => x.MostrarPuntos(cuenta));
        if (cuenta>10) {
            Debug.Log("El ganador es "+nombre);
        }
        else
        {
            if (Input.GetKeyDown(teclaAsignada)) {
                this.transform.Translate(new Vector3(0, velocidad, 0));
                cuenta++;
                ExecuteEvents.Execute<IMisEventosCanvas>(canvas, null, (x, y) => x.MostrarPuntos(cuenta));
                
            }
        }
    }
}

