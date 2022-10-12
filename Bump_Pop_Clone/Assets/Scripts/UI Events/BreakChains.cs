using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BreakChains : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI first, second, third, fourth, fifth;
    [SerializeField] 
    GameObject firstC, secondC, thirdC, fourthC, fifthC, box;

    int five, ten, fifteen, twenty, twentyFive;
    public List<GameObject> fiveList, tenList, fifteenList, twentyList, twentyFiveList;
    

    void Awake() 
    {
        five = 5;
        ten = 10;
        fifteen = 15;
        twenty = 20;
        twentyFive = 25;

        fiveList = new List<GameObject>();
        tenList = new List<GameObject>();
        fifteenList = new List<GameObject>();
        twentyList = new List<GameObject>();
        twentyFiveList = new List<GameObject>();

    }

    void Update() 
    {
        if(five <= 0)
            {
                box.transform.position = Vector3.forward * 760f;
                five = 0;
                first.text = " ";
            }
        if(ten <= 0)
            {
                box.transform.position = Vector3.forward * 790f;
                ten = 0;
                second.text = " ";
            }
        if(fifteen <= 0)
            {
                box.transform.position = Vector3.forward * 820f;
                fifteen = 0;
                third.text = " ";
            }
        if(twenty <= 0)
            {
                
                box.transform.position = Vector3.forward * 850f;
                twenty = 0;
                fourth.text = " ";
            }
        if(twentyFive <= 0)
            {
                box.transform.position = Vector3.forward * 900f;
                twentyFive = 0;
                fifth.text = " ";
            }
            
    }
    
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("PlayerTwo"))
        {

            if(fiveList.Count < 5)
            {
                other.gameObject.tag = "CantBreak";
                five --;
                
                fiveList.Add(other.gameObject);

                if(fiveList.Count == 5)
                {
    
                    firstC.SetActive(false);
                    SoundEvents.PlaySound(SoundEvents.Sound.BallsToChains);

                }
                first.text = " " +five.ToString();
            }
            
        
                if(tenList.Count < 10 && five == 0)
                {
                    other.gameObject.tag = "CantBreak";
                    ten --;
                
                    tenList.Add(other.gameObject);

                    if(tenList.Count == 10)
                    {
                    
                        secondC.SetActive(false);
                        SoundEvents.PlaySound(SoundEvents.Sound.BallsToChains);


                    }
                    second.text = " " +ten.ToString();
                }
            
            
            
                if(fifteenList.Count < 15 && ten == 0)
                {
                    other.gameObject.tag = "CantBreak";
                    fifteen --;
                
                    fifteenList.Add(other.gameObject);

                    if(fifteenList.Count == 15)
                    {

                        thirdC.SetActive(false);
                        SoundEvents.PlaySound(SoundEvents.Sound.BallsToChains);

                    }
                    third.text = " " +fifteen.ToString();
                }
            
            
            

                if(twentyList.Count < 20 && fifteen == 0)
                {
                    other.gameObject.tag = "CantBreak";
                    twenty --;
                
                    twentyList.Add(other.gameObject);

                    if(twentyList.Count == 20)
                    {
                    
                        fourthC.SetActive(false);
                        SoundEvents.PlaySound(SoundEvents.Sound.BallsToChains);

                    }
                    fourth.text = " " +twenty.ToString();
                }
            
            
            
                if(twentyFiveList.Count < 25 && twenty == 0)
                {
                    other.gameObject.tag = "CantBreak";
                    twentyFive --;
                
                    twentyFiveList.Add(other.gameObject);

                    if(twentyFiveList.Count == 25)
                    {

                        fifthC.SetActive(false);
                        SoundEvents.PlaySound(SoundEvents.Sound.BallsToChains);

                    }
                    fifth.text = " " +twentyFive.ToString();
                }
            
        }
    }
}
