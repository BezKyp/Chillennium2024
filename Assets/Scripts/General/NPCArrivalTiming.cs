using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using static StressLevel;

public class NPCArrivalTiming : MonoBehaviour
{
    public static int numNPCs = 4;
    public static GameObject NPCs;
    private static int[] usedNums;
    private static int curr_ind = 0;
    private static int num;
    public static GameObject chosenNPC;
    public static int cust_timer = 0;
    private static int timer = 0;

    private void Start()
    {
        usedNums = new int[numNPCs];
        for(int i = 0; i < numNPCs; i++)
        {
            usedNums[i] = -1;
        }

        NPCs = GameObject.Find("Customers");
        StartCoroutine(InitialSummon());

    }

    private void Update()
    {
        if(++timer % 240 == 0 && StressLevel.gameStart == true)
        {
            cust_timer++;
        }
    }

    IEnumerator InitialSummon()
    {
        yield return new WaitForSeconds(2f);
        SummonNPC();
    }
    public static void SummonNPC()
    {
        bool good = true;
        if (curr_ind == numNPCs)
        {
            curr_ind = 0;
            GameObject customers = GameObject.Find("Customers");
            for(int i = 0; i < numNPCs; i++)
            {
                customers.transform.GetChild(i).GetComponent<Animator>().SetTrigger("Reset");
            }
        }
        while(good)
        {
            num = UnityEngine.Random.Range(0, numNPCs);
            for(int j = 0; j < curr_ind; j++)
            {
                if (usedNums[j] == num)
                {
                    good = false;
                    break;
                }
            }
            if (good)
            {
                usedNums[curr_ind] = num;
                curr_ind++;
                good = false;
            }
            else good = true;
        }

        chosenNPC = NPCs.transform.GetChild(num).gameObject;
        Animator anim = chosenNPC.GetComponent<Animator>();
        anim.SetTrigger("run");
        cust_timer = 0;

    }

}
