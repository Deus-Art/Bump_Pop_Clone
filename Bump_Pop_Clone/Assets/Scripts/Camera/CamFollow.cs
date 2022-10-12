using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CamFollow : MonoBehaviour
{
    
    public CinemachineVirtualCamera vCam;
  
    
    private void Awake() 
    {   
        vCam = gameObject.GetComponent<CinemachineVirtualCamera>();    
    }
    
}
