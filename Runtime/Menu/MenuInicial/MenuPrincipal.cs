using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{   
    public string proximoNivelString;
    public GameObject tutorial;    
    public AudioSource playSound;
    public AudioSource clickSound;
    bool startPressed = false;
   
    public void LoadNextLevel()
    {
        if (startPressed == false) {
            Invoke("Play", 3);
            startPressed = true;
            print("Start Pressed!");
            playSound.Play();
        }        
    }

    public void Play()
    {  
        if (IsThisSceneInProject(proximoNivelString)) SceneManager.LoadScene(proximoNivelString);
    }

    public void QuitGame()
    {
        clickSound.Play();
        //print("Click - Salir del Juego!!");
        Application.Quit();

    }

    public void CloseTutorial()
    {
        clickSound.Play();
        tutorial.gameObject.SetActive(false);
    }

    public void OpenTutorial()
    {
        clickSound.Play();
        tutorial.gameObject.SetActive(true);
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
