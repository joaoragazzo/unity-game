﻿using System;
using UnityEngine;

public class DroneTreeDamageUpgrade : Upgrade
{

    public DroneTreeDamageUpgrade()
    {
        Name = "Dano do drone em Árvore";
        Description = "Habilita o dano em arvores";
        Image = Resources.Load<Sprite>("Images/Upgrades/critdamageupgrade");
        Price = 0;
        Max = 1;
    }

    public override bool ApplyUpgrade()
    {
        if (PlayerStatsController.Stats.Money >= Price)
        {
            RifleAmmoScript.droneTreeDamageUpgrade = true;
            PlayerStatsController.Stats.Money -= Price;
            PlayerStatsController.Stats.Upgrades.Add(new DroneTreeDamageUpgrade());
            return true;
        }

        return false;
    }
}