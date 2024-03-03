using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.UI;

public class StressLevel : MonoBehaviour
{
    // Start is called before the first frame update

    public static int stressLevel = 20;
    public static int customerLevel = 50;
    int h_max = 128;
    int w_max = 10;

    public static bool gameStart = false;
    public static bool hasBox = false;
    public static int lastBox;
    public static int location;

    public AnimatorController animplayer;
    public AnimatorController animplayerBox;

    public Image stressBar;
    public Image customerBar;

    public GameObject player;

    public AudioClip sip;


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

    public void drinkWater() { stressLevel -= 5;}
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

    public void stressBarAdj()
    {
        float scale = ((float)stressLevel) / ((float)100);
        float scale2 = ((float)customerLevel) / ((float)100);
        stressBar.GetComponent<RectTransform>().sizeDelta = new Vector2(w_max, (scale * h_max));
        customerBar.GetComponent<RectTransform>().sizeDelta = new Vector2(w_max, (scale2 * h_max));

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
        stressBarAdj();
    }
}
