using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5f;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

    // Update is called once per frame
    void Update()
    {
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
}
