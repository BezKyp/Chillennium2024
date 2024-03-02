using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RandomOrder : MonoBehaviour
{
    //meat, side, dessert, drink
    GameObject[] order;
    public Transform meat;
    public Transform side;
    public Transform treat;
    public Transform drink;
    public GameObject heldTray;
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void CustomerArrive()
    {
        animator.SetBool("run", true);
        StartCoroutine(Enter());
    }
    
    public void OrderIndices()
    {
        order = new GameObject[4];

        order[0] = meat.GetChild(UnityEngine.Random.Range(0, 3)).gameObject;
        order[1] = side.GetChild(UnityEngine.Random.Range(0, 3)).gameObject;
        order[2] = treat.GetChild(UnityEngine.Random.Range(0, 3)).gameObject;
        order[3] = drink.gameObject; //drink.GetChild(UnityEngine.Random.Range(0, 3)).gameObject;

        Debug.Log(order);

        StartCoroutine(Wait());
    }

    
    IEnumerator Enter()
    {
        yield return new WaitForSeconds(2.32f);
        //heldTray.SetActive(false);
        //animator.SetBool("run", false);
        //yield return new WaitForSeconds(1f);
        this.transform.Find("speech bubble").gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        OrderIndices();
    }
    IEnumerator Wait()
    {
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("made it");
            order[i].SetActive(true);
            yield return new WaitForSeconds(1.2f);
            order[i].SetActive(false);
            yield return new WaitForSeconds(0.25f);
        }

        this.transform.Find("speech bubble").gameObject.SetActive(false);
    }


}
