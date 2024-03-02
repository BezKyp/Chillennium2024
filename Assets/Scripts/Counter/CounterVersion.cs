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
        Debug.Log(state);
    }

    public void MoveLeftMeat()
    {
        if(state == 0)
        {
            animator.SetBool("SlideOut", true);
            meatButton.SetActive(false);
            state = 1;
        }
        
        
    }

    public void MoveLeftSides()
    {
        if (state == 0)
        {
            animator.SetBool("SlideInFromRight", true);
            animator.SetBool("SlideOutLeft", false);
            animator.SetBool("SlideInFromLeft", false);
            animator.SetBool("SlideOutRight", false);
            sideButton.SetActive(true);
            //state = 1;
        }
        else if (state == 1)
        {
            animator.SetBool("SlideOutLeft", true);
            //this.transform.SetPositionAndRotation(this.transform.GetLocalPositionAndRotation(), this.transform.rotation);
            animator.SetBool("SlideInFromRight", false);
            animator.SetBool("SlideInFromLeft", false);
            animator.SetBool("SlideOutRight", false);
            sideButton.SetActive(false);
            state = 2;
        }


    }

    public void MoveLeftTreats()
    {
        if (state == 1)
        {
            animator.SetBool("SlideInFromRight", true);
            animator.SetBool("SlideOutLeft", false);
            animator.SetBool("SlideOutRight", false);
            animator.SetBool("SlideInFromLeft", false);
            treatButton.SetActive(true);
            //state = 2;
        }
        else if (state == 2)
        {
            animator.SetBool("SlideOutLeft", true);
            animator.SetBool("SlideInFromRight", false);
            animator.SetBool("SlideOutRight", false);
            animator.SetBool("SlideInFromLeft", false);
            treatButton.SetActive(false);
            state = 3;
        }

    }
    
    public void MoveLeftDrink()
    {
        if (state == 2)
        {
            animator.SetBool("SlideIn", true);
            animator.SetBool("SlideOut", false);
            drinkButton.SetActive(true);
            //state = 3;
        }

    }

    public void MoveRightMeat()
    {
        if (state == 1)
        {
            animator.SetBool("SlideIn", true);
            animator.SetBool("SlideOut", false);
            meatButton.SetActive(true);
            state = 0;
        }
        animator.SetBool("SlideIn", false);

    }

    public void MoveRightSides()
    {
        if (state == 1)
        {
            animator.SetBool("SlideOutRight", true);
            animator.SetBool("SlideInFromLeft", false);
            sideButton.SetActive(false);
            state = 0;
        }
        else if (state == 2)
        {
            animator.SetBool("SlideInFromLeft", true);
            animator.SetBool("SlideOutRight", false);
            sideButton.SetActive(true);
            //state = 1;
        }

    }

    public void MoveRightTreats()
    {
        if (state == 3)
        {
            animator.SetBool("SlideInFromLeft", true);
            animator.SetBool("SlideOutRight", false);
            treatButton.SetActive(true);
            //state = 2;
        }
        else if (state == 2)
        {
            animator.SetBool("SlideOutRight", true);
            animator.SetBool("SlideInFromLeft", false);
            treatButton.SetActive(false);
            state = 1;
        }

    }

    public void MoveRightDrink()
    {
        if (state == 3)
        {
            animator.SetBool("SlideOut", true);
            animator.SetBool("SlideIn", false);
            drinkButton.SetActive(false);
            state = 2;
        }

    }

}
