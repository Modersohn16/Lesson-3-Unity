using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpelHanteraren : MonoBehaviour
{
    bool isGameOver = false;
    public float tidRestart = 3f;
    public float tidNastaLvl = 3f;
    public GameObject vinnaLvlCanvas;
    public void gameOver()
    {
        if (isGameOver == false)
        {
            Debug.Log("GAME OVER");
            Invoke("restart", tidRestart);
        }
    }

    public void seger()
    {
        vinnaLvlCanvas.SetActive(true);
        Invoke("laddaNastaLvl", tidNastaLvl);
        
    }

    public void laddaNastaLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
