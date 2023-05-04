using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void BangunRuang(){
        SceneManager.LoadScene("BangunRuang");
    }

    public void Info(){
        SceneManager.LoadScene("Info");
    }

    public void Exit(){
        Application.Quit();
        Debug.Log("App Closed");
    }
}
