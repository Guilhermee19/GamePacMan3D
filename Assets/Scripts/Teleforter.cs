using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleforter : MonoBehaviour
{
    public Transform destination;
    private void OnTriggerEnter(Collider other){
        if( other.tag == "ghost"){
            other.transform.position = destination.transform.position;
        }
        
    }
}
