using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampAI : MonoBehaviour
{
    public GameObject[] clamps;
    public float clampScale = 1f;

    public float clampAttackCooldown = 10f;
    public float lockOnTime = 1f;
    public bool isClamping;
    [SerializeField] private float clampAttackTimer = 10f;

    private GameObject player;
    private EnemyAI eai;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        eai = gameObject.GetComponent<EnemyAI>();
        clampAttackTimer = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        clampAttackTimer -= Time.deltaTime;
        if (clampAttackTimer <= 0)
        {
            ClampAttack(player.transform.position);
        }
    }

    public void ClampsSetActive(bool state)
    {
        for (int i = 0; i < clamps.Length; i++)
        {
            clamps[i].SetActive(state);
        }
    }

    public Vector3 ClampAttack(Vector3 target)
    {
        
        return target;
    }
}
