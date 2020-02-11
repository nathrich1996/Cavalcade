using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameController
{
    public static float Timer { get; set; }
    public static int Score { get; set; }
    public static void UpdateTier()
    {
        Timer -= Time.deltaTime;
    }
    public static void UpdateScore(int points)
    {
        Score += points;
    }
}
