using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespawnPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    private void OnTriggerEnter(Collider other){
        if( other.tag == "ghost"){
            Debug.Log("1-> "+player.transform.position);
            Debug.Log("2-> "+respawnPoint.transform.position);
            player.transform.position = respawnPoint.transform.position;
        }
       
    }
}
