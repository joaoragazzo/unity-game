using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerStats : IDamageble   
{
    public bool IsAlive { get; set; } = true;
    public float Health { get; set; } = 100f;
    public float MaxHealth { get; set; } = 100f;
    public float WalkSpeed { get; set; } = 6f;
    public float RunSpeedMultiplier { get; set; } = 2f;
    public int Strength { get; set; } = 1;
    public float CritChance { get; set; } = 0.25f;
    public float CritMultiplier { get; set; } = 2.5f;
    public float AxeRotateSpeed { get; set; } = 120f;
    public float BaseDamageMultiplier { get; set; } = 100f;
    public int Money { get; set; } = 0;
    public bool CanMove { get; set; } = true;
    public bool CanTurn { get; set; } = true;
    public bool CanFire { get; set; } = true;
    public bool IsRunning { get; set; } = false;
    public List<Upgrade> Upgrades { get; set; } = new List<Upgrade>();
    


    public void TakeDamage(int amount)
    {
        Health -= amount;

        if (Health <= 0)
        {
            IsAlive = false;
        }
    }


    public void IncreaseMaxHealth(float multiplier)
    {
        MaxHealth *= multiplier;
    }

    public void Freeze()
    {
        CanFire = false;
        CanTurn = false;
        CanMove = false;
    }

    public void Unfreeze()
    {
        CanFire = true;
        CanTurn = true;
        CanMove = true;
    }
    
    
    
}