using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState State;

    public static event Action<GameState> OnGameStateChanged;

    static int stressLevel;
    static int customerLevel;

    public bool gameStart = false;
    static bool hasBox = false;

    private void Awake()
    {
        Instance = this;
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState) {
            case GameState.stressLevel:
                break;
            case GameState.customerLevel:
                break;
            case GameState.hasBox:
                break;
            case GameState.gameStart:
                break;
            case GameState.timer:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState,null);
        }

        OnGameStateChanged?.Invoke(newState);

    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateGameState(GameState.stressLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum GameState
{
    stressLevel,
    customerLevel,
    hasBox,
    gameStart,
    timer
}