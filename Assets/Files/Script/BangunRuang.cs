using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BangunRuang : MonoBehaviour
{
    public void RumusKubus(){
        SceneManager.LoadScene("RumusKubus");
    }

    public void RumusBalok(){
        SceneManager.LoadScene("RumusBalok");
    }

    public void RumusTabung(){
        SceneManager.LoadScene("RumusTabung");
    }

    public void RumusLimas(){
        SceneManager.LoadScene("RumusLimas");
    }

    public void Back(){
        SceneManager.LoadScene("MainMenu");
    }

}
