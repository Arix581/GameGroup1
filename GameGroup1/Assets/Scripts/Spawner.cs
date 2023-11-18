using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Spawner : MonoBehaviour
{
    public float spawnDistance = 15f;

    public SpawnSession[] sessions;

    [SerializeField] private float globalTimer;

    // Start is called before the first frame update
    void Start()
    {
        globalTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        globalTimer += Time.deltaTime;

        // Old Spawning System
        //if (globalTimer >= spawnTime)
        //{
        //    Spawn(prefab);
        //    globalTimer = Random.Range(1f, spawnOffset);
        //}
        

        // New Spawning System
        for (int i = 0; i < sessions.Length; i++)
        {
            if (sessions[i].startTime <= globalTimer)
            {
                sessions[i].timer += Time.deltaTime;
                if (sessions[i].AttemptSpawn())
                {
                    Spawn(sessions[i].prefab);
                }
            }
        }
    }

    public void Spawn(GameObject prefab)
    {
        int angle = UnityEngine.Random.Range(0, 359);
        Vector3 position = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle), 0f) * spawnDistance;
        position += transform.position;

        Instantiate(prefab, position, transform.rotation);
    }
}

[Serializable]
public class SpawnSession
{
    public EnemyStats stats;
    public float startTime;
    public float ramp;
    public float timer;
    public GameObject prefab;
    public float interval;

    public bool AttemptSpawn()
    {
        if (timer >= interval)
        {
            timer = 0;
            return true;
        } 
        else
        {
            return false;
        }
    }
}