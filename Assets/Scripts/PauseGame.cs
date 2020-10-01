using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject textPause;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(Time.timeScale == 1){
                textPause.SetActive(true);
                Time.timeScale = 0;
            }
            else{
                textPause.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}
