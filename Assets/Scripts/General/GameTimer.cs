using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public static int timer = 300;
    static int counter = 0;

    public TextMeshProUGUI time_text;

    // Update is called once per frame
    void Update()
    {
        if((++counter) % 240 == 0)
        {
            timer--;
            time_text.text = timer.ToString();
        }
    }
}
