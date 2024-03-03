using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NPCArrivalTiming : MonoBehaviour
{
    public static int numNPCs;
    public static GameObject NPCs;
    private static int[] usedNums;
    private static int curr_ind = 0;
    private static int num;

    private void Start()
    {
        usedNums = new int[numNPCs];
        for(int i = 0; i < numNPCs; i++)
        {
            usedNums[i] = -1;
        }
    }
    public static void SummonNPC()
    {
        bool good = true;
        while(good)
        {
            num = UnityEngine.Random.Range(0, numNPCs);
            for(int j = 0; j < usedNums.Length; j++)
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
            }
            else good = true;
        }

        GameObject chosenNPC = NPCs.transform.GetChild(num).gameObject;
        Animator anim = chosenNPC.GetComponent<Animator>();
        anim.SetTrigger("run");

    }
}
