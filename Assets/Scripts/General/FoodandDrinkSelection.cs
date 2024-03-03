using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using static NPCArrivalTiming;
public class FoodSelection : MonoBehaviour
{
    public int itemNum;
    private int items_remaining;
    private static bool drink_dispensed;
    private static bool complete;
    GameObject[] items;
    GameObject trayItem;
    public static GameObject[] trayItems;
    private static GameObject drinks;
    private static GameObject drinks_child;
    public GameObject up_left;
    public GameObject left;
    public GameObject up;
    public GameObject down;
    static int loc = 0;

    private void Start()
    {
        items = new GameObject[itemNum];
        items_remaining = itemNum;
        trayItems = new GameObject[4];
        for(int i = 0; i < itemNum; i++)
        {
            items[i] = this.transform.GetChild(i).gameObject;
        }
    }

    public void RemoveItem()
    {
        //if items_remaining == 0, dont add to plate
        if(items_remaining != 0 && loc < 3)
        {
            items[items_remaining - 1].gameObject.SetActive(false);
            string name = items[items_remaining - 1].gameObject.name;
            switch(loc)
            {
                case 0:
                    trayItem = up.transform.Find(name).gameObject;
                    break;
                case 1:
                    trayItem = down.transform.Find(name).gameObject;
                    break;
                case 2:
                    trayItem = left.transform.Find(name).gameObject;
                    break;
            }
            trayItems[loc] = trayItem;
            trayItem.SetActive(true);
            items_remaining--;

            loc++;
            if (loc == 3 && drink_dispensed) GiveTray();
        }

    }

    public void DispenseDrink(string drink)
    {
        //add cup in machine
        drinks = GameObject.Find("drinksBase");
        drinks_child = drinks.transform.Find(drink).gameObject;
        GameObject.Find("cup_end").SetActive(false);
        drinks_child.SetActive(true);

        //give cup back to tray
        StartCoroutine(PourDrink());

    }

    void PlaceTray()
    {
        down.GetComponentInParent<Transform>().gameObject.SetActive(true);
    }

    void GiveTray()
    {
        drink_dispensed = false;
        loc = 0;
        
        StartCoroutine(Wait());
    }

    IEnumerator PourDrink()
    {
        yield return new WaitForSeconds(1);
        drinks_child.SetActive(false);
        string drink_of_choice = "";
        switch(drinks_child.name)
        {
            case "drinks_filled_lemonade":
                drink_of_choice = "cup_side_filled_lemonade";
                break;
            case "drinks_filled_rootbeer":
                drink_of_choice = "cup_side_filled_sweet_tea";
                break;
            case "drinks_filled_sweet_tea":
                drink_of_choice = "cup_side_rootbeer";
                break;
        }
        up_left.transform.Find(drink_of_choice).gameObject.SetActive(true);
        trayItems[3] = up_left.transform.Find(drink_of_choice).gameObject;



        drink_dispensed = true;
        if (loc == 3 && drink_dispensed) GiveTray();

    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);

        for (int i = 0; i < 4; i++)
        {
            Debug.Log(trayItems[i].ToString());
            trayItems[i].SetActive(false);
        }
        trayItems = new GameObject[3];

        down.GetComponentInParent<SpriteRenderer>().enabled = false;
        GameObject.Find("cup_end").SetActive(true);

        NPCArrivalTiming.chosenNPC.GetComponent<Animator>().SetTrigger("leave");
        yield return new WaitForSeconds(3f);
        NPCArrivalTiming.SummonNPC();
    }

}
