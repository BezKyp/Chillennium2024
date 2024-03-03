using System.Collections;
using System.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine;
using UnityEngine.UI;

using static NPCArrivalTiming;
using static GameTimer;
using static FoodSelection;
using static RandomOrder;
using UnityEngine.SceneManagement;

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

    public static bool drink = true;
    public static bool side = true;
    public static bool treat = true;
    public static bool meat = true;

    public RuntimeAnimatorController animplayer;
    public RuntimeAnimatorController animplayerBox;

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
        if (NPCArrivalTiming.cust_timer % 3 == 0 && NPCArrivalTiming.cust_timer != 0) stressLevel++;
        if (GameTimer.timer % 3 == 0 && SceneManager.GetActiveScene().name == "BackRoom") stressLevel--;
        if (GameTimer.timer % 8 == 0 && SceneManager.GetActiveScene().name == "CounterTesting") stressLevel++;

        for (int i = 0; i < 4; i++) {
            //if (RandomOrder.order[0] == FoodSelection.trayItems[i]) meat = true;
            //if (RandomOrder.order[1] == FoodSelection.trayItems[i]) side = true;
            //if (RandomOrder.order[2] == FoodSelection.trayItems[i]) treat = true;
            //if (RandomOrder.order[3] == FoodSelection.trayItems[i]) drink = true;
        }
        if (meat = false) customerLevel -= 7;
        if (side = false) customerLevel -= 5;
        if (treat = false) customerLevel -= 4;
        if (drink = false) customerLevel -= 4;

        drink = true;
        side = true;
        treat = true;
        meat = true;

    stressBarAdj();
        if (stressLevel >= 100 || customerLevel <= 0) SceneManager.LoadScene("GAMEOVER");
    }
}
