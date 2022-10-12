using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(LineRenderer))]
public class ThrowBall : MonoBehaviour
{
    public int reflections;
    public float maxLength;
    public Vector2 turn;
    public float speed = 50f;
    public bool isLaunched, isDragging, isTouching, hasBallStopped, hasCollided;


    LineRenderer lineRenderer;
    Ray ray;
    RaycastHit hit;
    Rigidbody rb;
    

    private void Awake() 
    {
        lineRenderer = GetComponent<LineRenderer>();    
        rb = GetComponent<Rigidbody>();
    }

    private void Update() 
    {
        if(isTouching == true)
        {
            ray = new Ray(transform.position, transform.forward);

            lineRenderer.positionCount = 1;
            lineRenderer.SetPosition(0, transform.position);
            float remainingLength = maxLength;

            for (int i = 0; i < reflections; i++)
            {
                if(Physics.Raycast(ray.origin, ray.direction, out hit, remainingLength))
                {
                    lineRenderer.positionCount += 1;
                    lineRenderer.SetPosition(lineRenderer.positionCount -1, hit.point);
                    remainingLength -= Vector3.Distance(ray.origin, hit.point);
                    ray = new Ray(hit.point, Vector3.Reflect(ray.direction, hit.normal));
                
                        if(hit.collider.tag != "Wall" && hit.collider.tag != "Player")
                            break;
                }
                else
                {
                    lineRenderer.positionCount += 1;
                    lineRenderer.SetPosition(lineRenderer.positionCount -1, ray.origin + ray.direction * remainingLength);
                }
            }
            
            
        }
        
        
        if(Input.GetMouseButtonDown(0) && !IsMouseTouching())
        {
            
            isTouching = true;
            isDragging = true;           
            
        }

        if(isDragging == true)
        {

            turn.x += Input.GetAxis("Mouse X");
            turn.y += Input.GetAxis("Mouse Y");
            transform.localRotation = Quaternion.Euler(0, turn.x, 0f);

        }


        if(Input.GetMouseButtonUp(0) && !IsMouseTouching())
        {
        
            isLaunched = true;
        
        }

        if(isLaunched == true)
        {
            rb.velocity = this.transform.forward * speed;
            lineRenderer.GetComponent<LineRenderer>().enabled = false;
            this.GetComponent<ThrowBall>().enabled = false;
        }

        if(hasBallStopped == true)
        {
            rb.drag = 50f;
        }
        
     
    }

    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("PlayerTwo"))
        {
            other.gameObject.tag = "PlayerTwo";
            hasBallStopped = false;
            hasCollided = true;
        }
    }

    public bool IsMouseTouching()
    {
        return EventSystem.current.IsPointerOverGameObject();
    }
}
