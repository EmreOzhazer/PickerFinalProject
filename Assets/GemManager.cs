using System.Collections;
using System.Collections.Generic;
using Controllers.Player;
using UnityEngine;
using UnityEngine.UI;

public class GemManager : MonoBehaviour
{
    public PlayerMovementController playerMovementController;
    public float necessaryTime = 2f;
    float elapsed20;
    float elapsed50;
    float elapsed100;

    public bool gem20;
    public bool gem50;
    public bool gem100;
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "20")
        {
            elapsed20 += Time.fixedDeltaTime;
           // Debug.Log(elapsed20 +" 20gems");
            if (elapsed20 > necessaryTime)
            {
                gem20 = true;
                Debug.Log("20gems");
                
            }
        }
        if (other.tag == "50")
        {
            elapsed50 += Time.fixedDeltaTime;
            //Debug.Log(elapsed50 +" 50gems");
            if (elapsed50 > necessaryTime)
            {
                gem50 = true;
                Debug.Log("50gems");
                
            }
        }
        if (other.tag == "100")
        {
            elapsed100 += Time.fixedDeltaTime;
            //Debug.Log(elapsed100 +" 100gems");
            if (elapsed100 > necessaryTime)
            {
                gem100 = true;
                Debug.Log("100gems");
                
            }
        }
    }
}
