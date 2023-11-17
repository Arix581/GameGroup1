using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : HealthScript
{
    public FloatObject points;
    public float pointsOnDeath;
    public override void Die()
    {
        base.Die();
        points.value += pointsOnDeath;
        Destroy(gameObject);
    }
}
