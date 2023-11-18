using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 5f;
    public float damage = 1f;
    public float damageInterval = 2.5f;

    [SerializeField] private float damageTimer = 0f;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        damageTimer = 0f;
        player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
        damageTimer += Time.deltaTime;
        //Vector3 toMove = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        //transform.position = toMove;
        if (player != null)
        {
            Vector3 target = player.transform.position;
            transform.LookAt(target);
            Vector3 movement = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            transform.position = movement;
        }
    }

    public void DamagePlayer()
    {
        if (damageTimer >= damageInterval)
        {
            damageTimer = 0f;
            player.GetComponent<PlayerHealthScript>().TakeDamage(damage);
        }
    }
}
