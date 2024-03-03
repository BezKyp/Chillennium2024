using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void SwitchToCounter()
    {
        SceneManager.LoadScene("CounterTesting");
    }

    public void SwitchToBackRoom()
    {
        SceneManager.LoadScene("BackRoom");
    }

    public void SwitchToKitchen() {
        SceneManager.LoadScene("Kitchen");
    }

    public void SwitchToStart()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
