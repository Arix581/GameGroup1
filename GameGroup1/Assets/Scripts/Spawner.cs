using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnTime = 10f;
    public GameObject prefab;
    public float spawnOffset = 5f;
    public float spawnDistance = 15f;

    [SerializeField] private float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnTime)
        {
            Spawn();
            timer = Random.Range(1f, spawnOffset);
        }
    }

    public void Spawn()
    {
        var vector2 = Random.insideUnitCircle.normalized * spawnDistance;
        Vector3 position = new Vector3(vector2.x, 0, vector2.y);
        
        Instantiate(prefab, position, transform.rotation);
    }
}
