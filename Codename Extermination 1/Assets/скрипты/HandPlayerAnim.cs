using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HandPlayerAnim : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Animator PlayerAnimator;
    private string openTrigger = "walking";
    private string openTrigger2 = "stop";
    public bool isPressed;

    public void Update()
    {
        if (isPressed)
        {
            PlayerAnimator.SetTrigger(openTrigger);
        }
        else
        {
            PlayerAnimator.SetTrigger(openTrigger2);
        }
    }

    public void OnPointerDown(PointerEventData data)
    {
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        isPressed = false;
    }
}
