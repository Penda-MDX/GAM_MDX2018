using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EntityStats : IComparable<EntityStats>
{
    public int SpeedStat;
    public int PhysicalAttackStat;
    public int PhysicalDefenseStat;
    public int MagicalAttackStat;
    public int MagicalDefenseStat;
    public int HealthStat;


    //constructor
    public EntityStats(int initSpeed,int initHealth)
    {
        SpeedStat = initSpeed;
        HealthStat = initHealth;

        //
        PhysicalAttackStat = 1;
        PhysicalDefenseStat = 1;
        MagicalAttackStat = 1;
        MagicalDefenseStat = 1;
    }

    //This method is required by the IComparable
    //interface. 
    public int CompareTo(EntityStats other)
    {
        if (other == null)
        {
            return 1;
        }
        else
        {
            return SpeedStat - other.SpeedStat;
        }
    }
}
