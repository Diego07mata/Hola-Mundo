using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    public void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector3(-28, 3, -12);
        Debug.Log("hola");
        
    }      
    
}
