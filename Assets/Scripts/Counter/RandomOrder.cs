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
    public GameObject tableTray;
    public GameObject button;
    public GameObject bubble;
    private Animator animator;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void CustomerArrive()
    {
        //this.transform.Find("speech bubble").Find("Test").gameObject.SetActive(false);
        StartCoroutine(Enter());
    }
    
    public void OrderIndices()
    {
        order = new GameObject[4];

        order[0] = meat.GetChild(UnityEngine.Random.Range(0, 3)).gameObject;
        order[1] = side.GetChild(UnityEngine.Random.Range(0, 3)).gameObject;
        order[2] = treat.GetChild(UnityEngine.Random.Range(0, 3)).gameObject;
        order[3] = drink.GetChild(UnityEngine.Random.Range(0, 3)).gameObject;

        //Debug.Log(order);

        StartCoroutine(Wait());
    }

    
    IEnumerator Enter()
    {

        yield return new WaitForSeconds(0.5f);
        OrderIndices();
    }
    IEnumerator Wait()
    {
        animator.SetTrigger("Talk");
        for (int i = 0; i < 4; i++)
        {
            order[i].SetActive(true);
            yield return new WaitForSeconds(1.2f);
            order[i].SetActive(false);
            yield return new WaitForSeconds(0.25f);
        }

        animator.SetTrigger("StopTalk");
        animator.SetTrigger("RemoveSpeech");
    }


}
