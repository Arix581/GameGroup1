using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultGunScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position + Vector3.forward, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(Vector3.forward * bulletSpeed);
    }
}
