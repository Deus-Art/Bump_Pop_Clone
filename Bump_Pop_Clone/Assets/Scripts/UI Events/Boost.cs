using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{   
    void OnCollisionStay(Collision other) 
    {
        if(other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("PlayerTwo"))
        {

            other.gameObject.GetComponent<Rigidbody>();
            other.rigidbody.AddForce(0f, 0f, 4f);
            other.rigidbody.drag = 0f;
            
        }
    }
}
