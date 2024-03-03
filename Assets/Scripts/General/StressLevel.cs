using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class StressLevel : MonoBehaviour
{
    // Start is called before the first frame update

    static int stressLevel = 20;
    static int customerLevel = 50;

    public static bool gameStart = false;
    public static bool hasBox = false;
    public static int lastBox;
    public static int location;

    public AnimatorController animplayer;
    public AnimatorController animplayerBox;

    public GameObject player;


    public void setBoxTrue()
    {
        hasBox = true;
    }
    public void setBoxFalse()
    {
        hasBox = false;
    }

    public bool getBox()
    {
        return hasBox;
    }

    public void setBoxMeat() { lastBox = 0; }
    public void setBoxSide() { lastBox = 1; }
    public void setBoxDes() { lastBox = 2; }
    public void setBoxSoda() { lastBox = 3; }

    public void drinkWater() { stressLevel -= 5; }
    public void lookPoster() { stressLevel -= 5; }
    public void sit() { stressLevel -= 5; }

    public void changeAnimBox()
    {
        player.GetComponent<Animator>().runtimeAnimatorController = animplayerBox;
    }

    public void changeAnim()
    {
        player.GetComponent<Animator>().runtimeAnimatorController = animplayer;
    }

    void Start()
    {
        if (hasBox)
        {
            changeAnimBox();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
