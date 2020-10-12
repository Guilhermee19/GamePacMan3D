using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectItems : MonoBehaviour
{
    public Text punctuation;
    private int points;

    void Start(){
        points = 0;
    }

    void Update(){
        punctuation.text = "Pontos: "+ points;
    }

    private void OnTriggerEnter(Collider other){
        if( other.tag == "collectable_items"){
            other.gameObject.SetActive(false);
            points = points + 1;
        }
        if( points == 328){
            Debug.Log("Excelente !");
        }
        
    }
}
