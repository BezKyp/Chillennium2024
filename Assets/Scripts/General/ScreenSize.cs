using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSize : MonoBehaviour
{

    public Camera cam;

    private int sch;
    // Start is called before the first frame update
    void Start()
    {
        //cam.rect = new Rect(0.25f, 0f, 0.5f, 1.0f);
        sch = Screen.height;
        float scale = ((float) Screen.height) / ((float) Screen.width);
        float off = (1 - scale) / 2;
        cam.rect = new Rect(off, 0f, scale, 1.0f);

    }

    private void Update()
    {
        if (sch != Screen.height)
        {
            sch = Screen.height;
            float scale = ((float)Screen.height) / ((float)Screen.width);
            float off = (1 - scale) / 2;
            cam.rect = new Rect(off, 0f, scale, 1.0f);
        }


    }

}
