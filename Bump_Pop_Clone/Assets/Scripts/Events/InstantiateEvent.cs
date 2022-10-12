using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstantiateEvent : MonoBehaviour
{
    Empty empty;
    public GameObject ballPrefab;
    public List<GameObject> insList = new List<GameObject>();
    public int instantValue;

    private void Awake() 
    {
        instantValue = 9;
    }

    void CreateBalls() 
    {
        if(insList.Count == instantValue)
        {
            return;
        }

        else if(instantValue >= insList.Count - 1)
        {
            for (int i = 0; i < instantValue; i++) 
            {
                
                GameObject cloneBall = Instantiate(ballPrefab);
                insList.Add(cloneBall);
                
                
            }
        }
    }

    void OnCollisionEnter(Collision impact) 
    {
        if(impact.gameObject.CompareTag("Player") || impact.gameObject.CompareTag("PlayerTwo"))
        {
            if(empty == null)
            {
                empty = gameObject.AddComponent<Empty>();
            }
            CreateBalls();
            SoundEvents.PlaySound(SoundEvents.Sound.BallsToBalls);
        }
    }
}
