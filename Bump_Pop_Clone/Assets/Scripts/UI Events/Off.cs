using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Off : MonoBehaviour
{
    public GameObject winPanel;
    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("PlayerTwo"))
        {
            
            Destroy(other.gameObject);
            Invoke("Win", 1.5f);
        }
    }

    void Win()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
