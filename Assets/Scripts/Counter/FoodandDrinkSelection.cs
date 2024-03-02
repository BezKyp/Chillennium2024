using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FoodSelection : MonoBehaviour
{
    public int itemNum;
    private static int items_remaining;
    private static bool drink_dispensed;
    GameObject[] items;
    GameObject trayItem;
    GameObject[] trayItems;
    public GameObject left;
    public GameObject up;
    public GameObject down;
    static int loc = 0;

    private void Start()
    {
        items = new GameObject[itemNum];
        trayItems = new GameObject[3];
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
            string name = items[items_remaining - 1].gameObject.name;
            items_remaining--;
            switch(loc)
            {
                case 0:
                    Debug.Log(name);
                    trayItem = down.transform.Find(name).gameObject;
                    break;
                case 1:
                    trayItem = up.transform.Find(name).gameObject;
                    break;
                case 2:
                    trayItem = left.transform.Find(name).gameObject;
                    break;
            }
            trayItems[loc] = trayItem;
            trayItem.SetActive(true);
            loc++;
            if (loc == 3 && drink_dispensed) GiveTray();
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

        drink_dispensed = true;
    }

    void PlaceTray()
    {
        down.GetComponentInParent<Transform>().gameObject.SetActive(true);
    }

    void GiveTray()
    {
        drink_dispensed = false;
        loc = 0;
        for(int i = 0; i < trayItems.Length; i++)
        {
            trayItems[i].SetActive(false);
        }
        down.GetComponentInParent<Transform>().gameObject.SetActive(false);
    }

}
