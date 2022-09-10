using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    
    public float speed;
    public Transform Spawn;
    public GameObject bullet;
    public float fireRate = 0.5f;
    public float nextFire = 0.0f;
   

    public void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, Spawn.transform.position, Spawn.rotation);
        }

    }
}
