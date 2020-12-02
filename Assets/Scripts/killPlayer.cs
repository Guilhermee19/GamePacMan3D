using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class killPlayer : MonoBehaviour
{    
    public Text num_heart;
    private int heart;
    public string killScene;
    //public string resetGame;

    void Start(){
        heart = 3;
    }

    void Update(){
        num_heart.text = "Vidas: "+ heart;
    }
    
    private void OnTriggerEnter(Collider other){
        if( other.tag == "ghost"){
            heart = heart - 1;
                    
            if(heart == 0){
                Cursor.visible = true;
                SceneManager.LoadScene(killScene);
            }
            
        }
        
    }

}
