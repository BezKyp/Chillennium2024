using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FoodSelection : MonoBehaviour
{
    public int itemNum;
    private static int items_remaining;
    GameObject[] items;

    private void Start()
    {
        items = new GameObject[itemNum];
        items_remaining = itemNum;
        for(int i = 0; i < itemNum; i++)
        {
            items[i] = this.transform.GetChild(i).gameObject;
        }
    }

    public void RemoveItem()
    {
        //if items_remaining == 0, dont add to plate
        if(items_remaining != 0)
        {
            items[items_remaining - 1].gameObject.SetActive(false);
            items_remaining--;
        }

    }

    public void DispenseDrink(string drink)
    {
        //remove cup from tray
        
        //add cup in machine

        //show pouring visual
        switch(drink) { 
            case "rootbeer":

                break;
            case "lemonade":

                break;
            case "tea":

                break;
        }

        //give cup back to tray
    }

}
