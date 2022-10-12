using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushOnRoad : MonoBehaviour
{
    ThrowBall throwBall;
    BallTracker ballTracker;
    public GameObject tracker;

    [SerializeField] float insSpeed;
    [SerializeField] float boostSpeed = 3f;
    Rigidbody rb;
    public bool force, boostForce, stopped;

    void Awake() 
    {
        throwBall = this.gameObject.AddComponent<ThrowBall>();
        throwBall = this.gameObject.GetComponent<ThrowBall>();
        gameObject.GetComponent<ThrowBall>().enabled = false;
        rb = GetComponent<Rigidbody>();
        insSpeed = 5;
    }

    void Start()
    {
        throwBall.enabled = false;
    }
    void Update()
    {
        if(force == true)
        {
            rb.AddForce(0f, 0f, insSpeed);
            rb.drag += 0.0025f;

                if(rb.drag >= 10f)
                {
                    rb.drag = 100f;
                    stopped = true;
                    MoveAgain();
                }
        }

        if(boostForce == true)
        {
            rb.AddForce(0f, 0f, boostSpeed);
        }

        
    }

    void OnCollisionEnter(Collision collide) 
    {
       if (collide.gameObject.CompareTag("Player"))
       {
            force = true;
       }

       if (collide.gameObject.CompareTag("Boost"))
       {
            boostForce = true;
            rb.drag = 0f;
       } 
    }

    public void MoveAgain()
    {

        if(stopped == true)
        {
            throwBall.enabled = true;
            rb.drag = 0f;
            throwBall.reflections = 2;
            throwBall.maxLength = 25;
            throwBall.isLaunched = false;
            throwBall.isDragging = false;
            throwBall.isTouching = false;
            throwBall.hasBallStopped = false;
            throwBall.hasCollided = false;
            this.GetComponent<PushOnRoad>().enabled = false;
            
        }
    }
}
