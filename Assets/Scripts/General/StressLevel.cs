using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StressLevel : MonoBehaviour
{
    // Start is called before the first frame update

    static int stressLevel;
    static int customerLevel;

    public bool gameStart = false;
    public bool hasBox = false;



    void Start()
    {
        stressLevel = 20;
        customerLevel = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
