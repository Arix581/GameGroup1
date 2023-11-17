using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : HealthScript
{
    public FloatObject playerHealth;
    public BoolObject playedBefore;
    public float resistanceMultiplier = 1;

    public override void TakeDamage(float Amount)
    {
        health = playerHealth.value;
        base.TakeDamage(Amount * resistanceMultiplier);
        playerHealth.value = Mathf.Clamp(health, 0f, maxHealth);
        Debug.Log("Player took " + Amount.ToString() + " damage.");
    }

    public override void OnStartHealth()
    {
        if (!playedBefore.value)
        {
            playerHealth.Reset();
        }
    }
}
