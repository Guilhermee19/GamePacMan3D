using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject textPause;
    public GameObject boxPoints;
    public GameObject miniMap;
    float cameraPitch = 0.0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(Time.timeScale == 1){
                textPause.SetActive(true);
                boxPoints.SetActive(false);
                miniMap.SetActive(false);
                Time.timeScale = 0;
            }
            else{
                textPause.SetActive(false);
                boxPoints.SetActive(true);
                miniMap.SetActive(true);
                Time.timeScale = 1;
            }
        }
    }
}
