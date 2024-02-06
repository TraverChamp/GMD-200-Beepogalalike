using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Lifescript 
{
    private static int _lives = 2;
    public static event Action<int> LifeLost;
    public static void setLife(int lives)
    {
        if(lives==_lives)
        {
            return;
        }
        lives = _lives;
        LifeLost?.Invoke(lives);
    }
    public static int getLife()
    {
        return _lives;
    }
}
