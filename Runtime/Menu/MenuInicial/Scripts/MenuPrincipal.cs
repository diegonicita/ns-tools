using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{   
    public string proximoNivelString;
    private GameObject tutorial;
    private GameObject levelUp;
    private GameObject quitGameWin;
    public AudioSource playSound;
    public AudioSource clickSound;
    bool startPressed = false;

    void OnAwake()
    {
        tutorial = GameObject.Find("Tutorial");
        levelUp = GameObject.Find("LevelUp");
        quitGameWin = GameObject.Find("Win");
    }
   
    public void LoadNextLevel()
    {
        if (startPressed == false) {
            Invoke("Play", 3);
            startPressed = true;
            print("Start Pressed!");            
        }        
    }

    public void Play()
    {  
       // if (IsThisSceneInProject(proximoNivelString)) SceneManager.LoadScene(proximoNivelString);
    }

    public void QuitApplication()
    {         
        Application.Quit();
    }

    public void ClickSound()
    {
        clickSound.Play();
    }

    public void PlayGameSound()
    {
        playSound.Play();
    }

    public void TutorialWindows(bool flag)
    {        
        tutorial.gameObject.SetActive(flag);
    }

    public void LevelUpWindows(bool flag)
    {       
        levelUp.gameObject.SetActive(flag);
    }

    public void QuitGameWindows(bool flag)
    {
        quitGameWin.gameObject.SetActive(flag);
    }

    private bool IsThisSceneInProject(string name)
    {
        bool flag = false;

        for (var i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            Debug.Log(i);
            var x = SceneUtility.GetScenePathByBuildIndex(i);
            Debug.Log(x);
            if (x.Contains(name)) {flag = true; }                
        }
        return flag;
    }
}
