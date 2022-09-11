using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakePistol : MonoBehaviour
{
    public Button fire;
    public GameObject HandsWithPistol;
    public GameObject HandsWithoutAll;
    public GameObject pistol;
    void Start()
    {
        fire.gameObject.SetActive(false);
        HandsWithPistol.gameObject.SetActive(false);       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            fire.gameObject.SetActive(true);
            HandsWithPistol.gameObject.SetActive(true);
            HandsWithoutAll.gameObject.SetActive(false);
            Destroy(pistol);
        }
       
    }
    
}
