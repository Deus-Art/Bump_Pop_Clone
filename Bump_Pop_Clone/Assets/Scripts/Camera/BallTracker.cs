using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTracker : MonoBehaviour
{
    CamFollow camFollow;
    PushOnRoad pushOnRoad;
    public GameObject camTwo;
    public GameObject nearestGameobject;
    public bool foundNearest;
    

    void Awake() 
    {

        camFollow = camTwo.GetComponent<CamFollow>();
        
    }
    
    void Update()
    {

        FindNearestBall();
        
    }

    public void FindNearestBall()
    {   
        float distToNearBall = Mathf.Infinity;
        Empty nearestBall = null;
        Empty[] allBalls = GameObject.FindObjectsOfType<Empty>();

        foreach (Empty currentBall in allBalls)
        {
            float distToBall = (currentBall.transform.position - this.transform.position).sqrMagnitude;
            if(distToBall < distToNearBall)
            {
                
                distToNearBall = distToBall;
                nearestBall = currentBall;
                camFollow.vCam.Follow = currentBall.transform;
                nearestGameobject = currentBall.gameObject;
                foundNearest = true;
                
            }

        }
        Debug.DrawLine(this.transform.position, nearestGameobject.transform.position); 
    }
}
