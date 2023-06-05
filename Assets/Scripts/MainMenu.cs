using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void PlayButton() 
    {
        SceneManager.LoadScene("OtherSceneName");
    }

    public void QuiteButton() 
    {
        Application.Quit();
    }
}
