using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyStats : ScriptableObject
{
    public float speed = 5f;
    public float damageInterval = 2.5f;
    public bool canDash = false;
}
