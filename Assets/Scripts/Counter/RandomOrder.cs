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

        //order[0] = Unity.Mathematics.Random() % numMeat;

        return order;
    }

}
