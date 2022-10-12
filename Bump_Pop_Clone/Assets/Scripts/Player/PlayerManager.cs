using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    ThrowBall throwBall;
    public GameObject player;
    public GameObject losePanel, buttons, inGameRestart, dragAndReleaseUi, dragAndReleaseUiTwo;


    float HorizontalSpeed = 1;
    float MaxPos = 200;
    float MinPos = -200;
    RectTransform rectTransform;

    
    bool speedDown;
    Rigidbody rb;


    void Awake() 
    {
        throwBall = player.GetComponent<ThrowBall>();
        rb = player.GetComponent<Rigidbody>();
        rectTransform = dragAndReleaseUi.GetComponent<RectTransform>();
    }

    private void Update() 
    {
        if(Input.GetMouseButtonUp(0) && !throwBall.IsMouseTouching())
            {

                speedDown = true;
                
            }

        if(speedDown == true)
        {
            throwBall.speed -= 0.05f;

                if(throwBall.speed <= 0)
                {
                    throwBall.speed = 0;
                    throwBall.hasBallStopped = true;
                }

                if(throwBall.hasBallStopped == true && throwBall.hasCollided == false)
                {
                    rb.drag = 100f;
                    player.GetComponent<SphereCollider>().enabled = false;
                    losePanel.SetActive(true);
                }
        }

        if(Input.GetMouseButtonDown(0) && !throwBall.IsMouseTouching())
        {
            
            buttons.SetActive(false);
            inGameRestart.SetActive(true);
            dragAndReleaseUi.SetActive(false);
            dragAndReleaseUiTwo.SetActive(false);
            
        }

        Vector2 position = rectTransform.anchoredPosition;
        position.x += HorizontalSpeed;
        if(position.x > MaxPos)
        {
            position.x = MinPos ;
        }
        rectTransform.anchoredPosition = position;

        
    }
}
