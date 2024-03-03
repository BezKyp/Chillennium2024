using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GeckoTextScript : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI textBox;

    public string[] emptyResponse;
    void Start()
    {
        emptyResponse[0] = "Come back with something useful.";
        emptyResponse[1] = "Scram! Get back to the customers.";
        emptyResponse[2] = "Got any more slop for me to fry?";
        emptyResponse[3] = "...";
        emptyResponse[4] = "I miss my wife.";
    }

    // Update is called once per frame
    public void changeText()
    {
        textBox.text = emptyResponse[Random.Range(0,4)];
    }
}
