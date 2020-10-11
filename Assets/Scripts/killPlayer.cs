using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class killPlayer : MonoBehaviour
{
    public Text num_heart;
    private int heart;
    public string menuScene;
    public string resetGame;

    // Start is called before the first frame update
    void Start()
    {
        heart = 3;
    }

    // Update is called once per frame
    void Update()
    {
        num_heart.text = "Vidas: "+ heart;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "ghost"){
            heart = heart - 1;
            SceneManager.LoadScene(resetGame);
            
            if(heart == 0){
                SceneManager.LoadScene(menuScene);
            }
            
        }
        
    }

}
