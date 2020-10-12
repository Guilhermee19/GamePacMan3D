using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool GamePause = false;
    public string nameScene;

    public GameObject textPause;
    public GameObject boxPoints;
    public GameObject miniMap;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GamePause){
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    public void Resume(){
        textPause.SetActive(false);
        boxPoints.SetActive(true);
        miniMap.SetActive(true);
        Time.timeScale = 1f;
        Cursor.visible = false;
        GamePause = false;
    }

    void Pause(){
        textPause.SetActive(true);
        boxPoints.SetActive(false);
        miniMap.SetActive(false);
        Time.timeScale = 0f;
        Cursor.visible = true;
        GamePause = true;
    }

    public void LoadMenu(){
        SceneManager.LoadScene(nameScene);
    }

}
