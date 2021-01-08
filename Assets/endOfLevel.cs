using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endOfLevel : MonoBehaviour
{
    public void endOfGame()
    {
        //Application.Quit();
        SceneManager.LoadScene("salaSubterranea");
        
    }
}
