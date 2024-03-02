using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesterScript : MonoBehaviour
{
    public GameObject hex;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //DoSomething
                Console.WriteLine("press");
                hex.SetActive(true);

              }
        }
    }
}
