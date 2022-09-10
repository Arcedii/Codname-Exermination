using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PistolFire : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    //пистолет
    public Animator PistolAnimator;
    private string openTrigger = "fire";
    private string openTrigger2 = "stop";
    public bool isPressed;
    public AudioSource FireSound;
    public int i = 0;
   
   
    private void Start()
    {
       
        FireSound.Stop();
    }
    public void FixedUpdate()
    {
        Fire();
      

    }
    public void OnPointerDown(PointerEventData data)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        isPressed = false;
    }
    void Fire()
    {
        if (isPressed)
        {
            i = 0;
            PistolAnimator.SetTrigger(openTrigger);
           
        }
        else
        {
            i = 1;          
            PistolAnimator.SetTrigger(openTrigger2);
           
        }
        if (i == 1)
        {
            FireSound.Play();
        }
    }
    
}
