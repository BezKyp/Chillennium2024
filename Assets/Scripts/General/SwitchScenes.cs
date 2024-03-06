using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using static StressLevel;

public class SwitchScenes : MonoBehaviour
{

    public GameObject gameVariables;
    public void switchCounterGameStart()
    {
        StressLevel.gameStart = true;
        SceneManager.LoadScene("CounterTesting");
    }
    
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
        StressLevel.stressLevel = 20;
        StressLevel.customerLevel = 50;
    }

}
