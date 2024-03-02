using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RandomOrder : MonoBehaviour
{
    //meat, side, dessert, drink
    int[] order;
    public int NumMeat;
    public int NumSide;
    public int NumDes;
    public int NumDrink;

    int[] OrderIndices()
    {
        order = new int[4];

        order[0] = UnityEngine.Random.Range(0, NumMeat);
        order[1] = UnityEngine.Random.Range(0, NumSide);
        order[2] = UnityEngine.Random.Range(0, NumDes);
        order[3] = UnityEngine.Random.Range(0, NumDrink);

        return order;
    }

}
