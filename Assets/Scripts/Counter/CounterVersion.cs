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
    public Animator sidesSign;
    public Animator treatSign;
    public Animator drinkSign;
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
            sidesSign.SetTrigger("SlidesUp");
            sideButton.SetActive(true);
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
            treatSign.SetTrigger("SlidesUp");
            treatButton.SetActive(true);
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
            drinkSign.SetTrigger("SlidesUp");
            drinkButton.SetActive(true);
        }

    }

    public void MoveRightMeat()
    {
        if (state == 1)
        {
            animator.SetTrigger("SlideIn");
            meatButton.SetActive(true);
        }

    }

    public void MoveRightSides()
    {
        if (state == 1)
        {
            animator.SetTrigger("ToRight");
            sidesSign.SetTrigger("SlidesDown");
            sideButton.SetActive(false);
            state = 0;
        }
        else if (state == 2)
        {
            animator.SetTrigger("MiddleFromLeft");
            sideButton.SetActive(true);
        }

    }

    public void MoveRightTreats()
    {
        if (state == 3)
        {
            animator.SetTrigger("MiddleFromLeft");
            treatButton.SetActive(true);
        }
        else if (state == 2)
        {
            animator.SetTrigger("ToRight");
            treatSign.SetTrigger("SlidesDown");
            treatButton.SetActive(false);
            state = 1;
        }

    }

    public void MoveRightDrink()
    {
        if (state == 3)
        {
            animator.SetTrigger("SlideOut");
            drinkSign.SetTrigger("SlidesDown");
            drinkButton.SetActive(false);
            state = 2;
        }

    }

    IEnumerator WaitAndReset()
    {
        yield return new WaitForSeconds(1);
        this.transform.SetPositionAndRotation(new Vector3(0f, -2.1f, 0), this.transform.rotation);
    }

}
