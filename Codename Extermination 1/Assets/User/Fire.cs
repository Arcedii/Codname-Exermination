using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fire : MonoBehaviour
{
    private bool isState;   
    public Animator PistolAnimator;
    private string openTrigger = "fire";
    private string openTrigger2 = "stop";
    public AudioSource FireSound;  

    public Transform Spawn;
    public GameObject bullet;
    public float fireRate = 0.5f;
    public float nextFire = 0.0f;

    private void Start()
    {
        FireSound.Stop();      
    }

    void Update()
    {
        if (isState)
        {
           
            PistolAnimator.SetTrigger(openTrigger2);
            FireSound.Play();
           
        }    
        else
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, Spawn.transform.position, Spawn.rotation);
            PistolAnimator.SetTrigger(openTrigger);          
           
        }
           
    }

   
    public void KeyFire(bool state) => isState = state;
}
