using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagChanger : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("CantBreak"))
        {
            other.gameObject.tag = "Player";
        }
    }
    
    void OnTriggerStay(Collider other) 
    {
        if(other.CompareTag("CantBreak"))
        {
            other.gameObject.tag = "Player";
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("CantBreak"))
        {
            other.gameObject.tag = "Player";
        }
    }
}
