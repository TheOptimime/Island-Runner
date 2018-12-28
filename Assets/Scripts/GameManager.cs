using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RandomGenerator))]
[RequireComponent(typeof(InputManager))]

public class GameManager : MonoBehaviour
{
    RandomGenerator rGen;
    InputManager inputM;
    public int score;

    public enum GameState
    {
        MainMenu,
        InGame,
        Endscreen,
    }

    public GameState gameState, previousGameState;


	// Use this for initialization
	void Start ()
    {
        rGen = GetComponent<RandomGenerator>();
        //Doesn't Crash
        DontDestroyOnLoad(this);
        gameState = new GameState();

	}
	
	// Update is called once per frame
	void Update ()
    {
		if (gameState == GameState.MainMenu)
        {

        }
        else if (gameState == GameState.InGame)
        {
            if (previousGameState != gameState)
            {
                score = 0;
            }

        }
        else if (gameState == GameState.Endscreen)
        {
            //Save New Score if the score > old score

        }

        previousGameState = gameState;
	}
}
