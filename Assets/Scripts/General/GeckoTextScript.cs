using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GeckoTextScript : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI textBox;

    public List<string> emptyResponse;
    public List<string> foodResponse;

    public GameObject gameVariables;
    private StressLevel var_script;
    void Start()
    {
        emptyResponse = new List<string>();
        foodResponse = new List<string>();
        emptyResponse.Add("Come back with something useful.");
        emptyResponse.Add("Scram! Get back to the customers.");
        emptyResponse.Add("Got any more slop for me to fry?");
        foodResponse.Add("Order Up.");
        foodResponse.Add("I'll get this food cooked for ya.");
        foodResponse.Add("Yum. Deep fried.");
        var_script = gameVariables.GetComponent<StressLevel>();
    }

    // Update is called once per frame
    public void setText()
    {

        if (var_script.getBox() == false)
        {
            textBox.text = emptyResponse[Random.Range(0, 3)];
        }
        else
        {
            textBox.text = foodResponse[Random.Range(0, 3)];
            var_script.setBoxFalse();
        }

    }
}
