using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterVersion : MonoBehaviour
{
    Animator animator;
    public GameObject meatButton;
    public GameObject sideButton;
    public GameObject treatButton;
    public GameObject drinkButton;
    static int state = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        //Debug.Log(state);
    }

    public void MoveLeftMeat()
    {
        if(state == 0)
        {
            animator.SetTrigger("SlideOut");
            meatButton.SetActive(false);
            state = 1;
        }
        
        
    }

    public void MoveLeftSides()
    {
        if (state == 0)
        {
            animator.SetTrigger("MiddleFromRight");
            //StartCoroutine(WaitAndReset());
            sideButton.SetActive(true);
            //state = 1;
        }
        else if (state == 1)
        {
            animator.SetTrigger("ToLeft");
            sideButton.SetActive(false);
            state = 2;
        }


    }

    public void MoveLeftTreats()
    {
        if (state == 1)
        {
            animator.SetTrigger("MiddleFromRight");
            //StartCoroutine(WaitAndReset());
            treatButton.SetActive(true);
            //state = 2;
        }
        else if (state == 2)
        {
            animator.SetTrigger("ToLeft");
            treatButton.SetActive(false);
            state = 3;
        }

    }
    
    public void MoveLeftDrink()
    {
        if (state == 2)
        {
            animator.SetTrigger("SlideIn");
            //StartCoroutine(WaitAndReset());
            drinkButton.SetActive(true);
            //state = 3;
        }

    }

    public void MoveRightMeat()
    {
        if (state == 1)
        {
            animator.SetTrigger("SlideIn");

            meatButton.SetActive(true);
            state = 0;
        }

    }

    public void MoveRightSides()
    {
        if (state == 1)
        {
            animator.SetTrigger("ToRight");
            sideButton.SetActive(false);
            //state = 0;
        }
        else if (state == 2)
        {
            animator.SetTrigger("MiddleFromLeft");
            StartCoroutine(WaitAndReset());
            sideButton.SetActive(true);
            state = 1;
        }

    }

    public void MoveRightTreats()
    {
        if (state == 3)
        {
            animator.SetTrigger("ToRight");
            //StartCoroutine(WaitAndReset());
            treatButton.SetActive(true);
            state = 2;
        }
        else if (state == 2)
        {
            animator.SetTrigger("MiddleFromLeft");
            treatButton.SetActive(false);
            //state = 1;
        }

    }

    public void MoveRightDrink()
    {
        if (state == 3)
        {
            animator.SetTrigger("SlideOut");
            drinkButton.SetActive(false);
            //state = 2;
        }

    }

    IEnumerator WaitAndReset()
    {
        yield return new WaitForSeconds(1);
        this.transform.SetPositionAndRotation(new Vector3(0f, -2.1f, 0), this.transform.rotation);
    }

}
