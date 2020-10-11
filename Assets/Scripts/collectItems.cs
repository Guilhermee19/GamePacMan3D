using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectItems : MonoBehaviour
{
    public Text punctuation;
    private int points;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        punctuation.text = "Pontos: "+ points;
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "collectable_items"){
            other.gameObject.SetActive(false);
            points = points + 1;
        }
        if( points == 328){
            // Excelent ! Finish Game
        }
        
    }
}
