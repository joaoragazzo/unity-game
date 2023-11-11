﻿using UnityEngine;

public class DifficultyStatsController: MonoBehaviour
{
    public static DifficultyStatsController Stats { get; private set; }

    public int difficulty;

    private void Awake()
    {
        if (Stats == null)
        {
            Stats = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}