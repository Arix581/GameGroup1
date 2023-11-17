using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatObject : ScriptableObject
{
    public float value;
    public float defaultValue;

    public void Equals(FloatObject other)
    {
        value = other.value;
    }
}
