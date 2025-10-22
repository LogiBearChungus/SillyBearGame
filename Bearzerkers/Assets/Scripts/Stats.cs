using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public float health;
    public float speed;
    public float damage;
    public float armor;
    public float attackSpeed;


    public void setHealth(float h)
    {
        this.health = h;
    }
    public void setSpeed(float s)
    {
        this.speed = s;
    }
    public void setDamage(float d)
    {
        this.damage = d;
    }
    public void setArmor(float a)
    {
        this.armor = a;
    }
    public void setAttackSpeed(float atkS)
    {
        this.attackSpeed = atkS;
    }
}
