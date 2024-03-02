using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void SwitchToCounter()
    {
        SceneManager.LoadScene("Counter");
    }

    public void SwitchToBackRoom()
    {
        SceneManager.LoadScene("BackRoom");
    }
}
