﻿using UnityEngine;

public class CucaStats : EnemyStats
{
    private WorldInteraction _worldInteraction;
    
    public CucaStats(WorldInteraction worldInteraction)
    {
        
        _worldInteraction = worldInteraction;
        _worldInteraction.Initialize();
        baseHealth = 100 * Mathf.Pow(1.05f, (_worldInteraction.worldStats.DayCounter - 1));
        baseSpeed = 5.0f;
        baseAttackDamage = 10;
        baseAttackRange = 10f;
        baseAttackSpeed = 1f;
    }
}
