using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class StressLevel : MonoBehaviour
{
    // Start is called before the first frame update

    static int stressLevel;
    static int customerLevel;

    public static bool gameStart = false;
    public static bool hasBox = false;

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

    public void changeAnimBox()
    {
        player.GetComponent<Animator>().runtimeAnimatorController = animplayerBox;
    }

    void Start()
    {
        stressLevel = 20;
        customerLevel = 50;
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
