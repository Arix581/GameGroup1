using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampAI : MonoBehaviour
{
    public GameObject clampHolder;
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
            ClampAttack();
        }
    }

    public void ClampsSetActive(bool state)
    {
        clampHolder.SetActive(state);
    }

    public void ClampAttack()
    {
        Vector3 target = eai.target;

        clampHolder.transform.position = target;
        clampHolder.transform.localScale = new Vector3(
            clampHolder.transform.localScale.x - Time.deltaTime, 
            clampHolder.transform.localScale.y - Time.deltaTime,
            clampHolder.transform.localScale.z - Time.deltaTime);
    }

    public void SetClamps(float size)
    {
        clampHolder.transform.localScale = new Vector3(size, size, size);
    }
}
