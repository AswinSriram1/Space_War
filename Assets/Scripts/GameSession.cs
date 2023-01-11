using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    public static GameSession instance;
    int score = 0;
    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int numderGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numderGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    public int GetScore()
    {
        return score;
    }
    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }
    public void ResetGame()
    {
        Destroy(gameObject);
    }

}
