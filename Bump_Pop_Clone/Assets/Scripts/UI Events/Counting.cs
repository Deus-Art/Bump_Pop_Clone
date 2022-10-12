using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Counting : MonoBehaviour
{   
    InstantiateEvent instantiateEvent;
    List<GameObject> gList, g2List , g3List, g4List, 
    yList, y2List, y3List ,y4List,
    pList, p2List, p3List, p4List, 
    bList, b2List, b3List, b4List,
    r2List, r3List, r4List, r5List, r6List, r7List;
    float gMoney, g2Money , g3Money, g4Money, 
    yMoney, y2Money, y3Money ,y4Money,
    pMoney,p2Money,p3Money, p4Money, 
    bMoney, b2Money, b3Money, b4Money,
    r2Money, r3Money, r4Money, r5Money, r6Money, r7Money;

    int gBalls, g2Balls , g3Balls, g4Balls, 
    yBalls, y2Balls, y3Balls ,y4Balls,
    pBalls,p2Balls,p3Balls, p4Balls, 
    bBalls, b2Balls, b3Balls, b4Balls,
    r2Balls, r3Balls, r4Balls, r5Balls, r6Balls, r7Balls,
    totalBalls;
    

    [SerializeField] TextMeshProUGUI txt_money, txt_balls, txt_lvClone, txt_lvIncome, txt_costClone, txt_costIncome;
    [SerializeField] GameObject green, green2, green3, green4,
    yellow, yellow2, yellow3, yellow4,
    purple, purple2, purple3, purple4,
    blue, blue2, blue3, blue4,
    red2, red3, red4, red5, red6, red7;

    public float totalMoney, moneyLimit;
    public float startingMoney;
    public int ballsLimit, costClone, costIncome, lvClone, lvIncome;
    
    #region Awake
    private void Awake() 
    {
        startingMoney = 1000f;

        gList = green.GetComponent<InstantiateEvent>().insList;
        g2List = green2.GetComponent<InstantiateEvent>().insList;
        g3List = green3.GetComponent<InstantiateEvent>().insList;
        g4List = green4.GetComponent<InstantiateEvent>().insList;

        yList = yellow.GetComponent<InstantiateEvent>().insList;
        y2List = yellow2.GetComponent<InstantiateEvent>().insList;
        y3List = yellow3.GetComponent<InstantiateEvent>().insList;
        y4List = yellow4.GetComponent<InstantiateEvent>().insList;

        pList = purple.GetComponent<InstantiateEvent>().insList;
        p2List = purple2.GetComponent<InstantiateEvent>().insList;
        p3List = purple3.GetComponent<InstantiateEvent>().insList;
        p4List = purple4.GetComponent<InstantiateEvent>().insList;
        
        bList = blue.GetComponent<InstantiateEvent>().insList;
        b2List = blue2.GetComponent<InstantiateEvent>().insList;
        b3List = blue3.GetComponent<InstantiateEvent>().insList;
        b4List = blue4.GetComponent<InstantiateEvent>().insList;

        r2List = red2.GetComponent<InstantiateEvent>().insList;
        r3List = red3.GetComponent<InstantiateEvent>().insList;
        r4List = red4.GetComponent<InstantiateEvent>().insList;
        r5List = red5.GetComponent<InstantiateEvent>().insList;
        r6List = red6.GetComponent<InstantiateEvent>().insList;
        r7List = red7.GetComponent<InstantiateEvent>().insList;


        moneyLimit = 0.9f;
        ballsLimit = 9;
        lvClone = 1;
        lvIncome = 1;
        costClone = 5;
        costIncome = 6;
    }
    #endregion
    void Update() 
    {  
        #region foreach

        foreach (var obj in gList)
            {
                
                if(gMoney <= moneyLimit)
                {
                    gMoney += 0.1f;
                }
                
            
                if(gBalls <= ballsLimit)
                {
                    gBalls += 1;
                }
                
            }

        foreach (var obj in g2List)
            {
                
                if(g2Money <= moneyLimit)
                {
                    g2Money += 0.1f;
                }
                
            
                if(g2Balls <= ballsLimit)
                {
                    g2Balls += 1;
                }
                
            }
        
        foreach (var obj in g3List)
            {
                
                if(g3Money <= moneyLimit)
                {
                    g3Money += 0.1f;
                }
                
            
                if(g3Balls <= ballsLimit)
                {
                    g3Balls += 1;
                }
                
            }

        foreach (var obj in g4List)
            {
                
                if(g4Money <= moneyLimit)
                {
                    g4Money += 0.1f;
                }
                
            
                if(g4Balls <= ballsLimit)
                {
                    g4Balls += 1;
                }
                
            }
        
        foreach (var obj in yList)
            {
                
                if(yMoney <= moneyLimit)
                {
                    yMoney += 0.1f;
                }
                
            
                if(yBalls <= ballsLimit)
                {
                    yBalls += 1;
                }

            }
        
        foreach (var obj in y2List)
            {
                
                if(y2Money <= moneyLimit)
                {
                    y2Money += 0.1f;
                }
                
            
                if(y2Balls <= ballsLimit)
                {
                    y2Balls += 1;
                }

            }

        foreach (var obj in y3List)
            {
                
                if(y3Money <= moneyLimit)
                {
                    y3Money += 0.1f;
                }
                
            
                if(y3Balls <= ballsLimit)
                {
                    y3Balls += 1;
                }

            }
        
        foreach (var obj in y4List)
            {
                
                if(y4Money <= moneyLimit)
                {
                    y4Money += 0.1f;
                }
                
            
                if(y4Balls <= ballsLimit)
                {
                    y4Balls += 1;
                }

            }

        foreach (var obj in pList)
            {
                
                if(pMoney <= moneyLimit)
                {
                    pMoney += 0.1f;
                }
                
            
                if(pBalls <= ballsLimit)
                {
                    pBalls += 1;
                }

            }
        
        foreach (var obj in p2List)
            {
                
                if(p2Money <= moneyLimit)
                {
                    p2Money += 0.1f;
                }
                
            
                if(p2Balls <= ballsLimit)
                {
                    p2Balls += 1;
                }

            }

        foreach (var obj in p3List)
            {
                
                if(p3Money <= moneyLimit)
                {
                    p3Money += 0.1f;
                }
                
            
                if(p3Balls <= ballsLimit)
                {
                    p3Balls += 1;
                }

            }

        foreach (var obj in p4List)
            {
                
                if(p4Money <= moneyLimit)
                {
                    p4Money += 0.1f;
                }
                
            
                if(p4Balls <= ballsLimit)
                {
                    p4Balls += 1;
                }

            }

        foreach (var obj in bList)
            {
                
                if(bMoney <= moneyLimit)
                {
                    bMoney += 0.1f;
                }
                
            
                if(bBalls <= ballsLimit)
                {
                    bBalls += 1;
                }

            }

        foreach (var obj in b2List)
            {
                
                if(b2Money <= moneyLimit)
                {
                    b2Money += 0.1f;
                }
                
            
                if(b2Balls <= ballsLimit)
                {
                    b2Balls += 1;
                }

            }

        foreach (var obj in b3List)
            {
                
                if(b3Money <= moneyLimit)
                {
                    b3Money += 0.1f;
                }
                
            
                if(b3Balls <= ballsLimit)
                {
                    b3Balls += 1;
                }

            }

        foreach (var obj in b4List)
            {
                
                if(b4Money <= moneyLimit)
                {
                    b4Money += 0.1f;
                }
                
            
                if(b4Balls <= ballsLimit)
                {
                    b4Balls += 1;
                }

            }

        foreach (var obj in r2List)
            {
                
                if(r2Money <= moneyLimit)
                {
                    r2Money += 0.1f;
                }
                
            
                if(r2Balls <= ballsLimit)
                {
                    r2Balls += 1;
                }

            }

        foreach (var obj in r3List)
            {
                
                if(r3Money <= moneyLimit)
                {
                    r3Money += 0.1f;
                }
                
            
                if(r3Balls <= ballsLimit)
                {
                    r3Balls += 1;
                }

            }
        
        foreach (var obj in r4List)
            {
                
                if(r4Money <= moneyLimit)
                {
                    r4Money += 0.1f;
                }
                
            
                if(r4Balls <= ballsLimit)
                {
                    r4Balls += 1;
                }

            }

        foreach (var obj in r5List)
            {
                
                if(r5Money <= moneyLimit)
                {
                    r5Money += 0.1f;
                }
                
            
                if(r5Balls <= ballsLimit)
                {
                    r5Balls += 1;
                }

            }

        foreach (var obj in r6List)
            {
                
                if(r6Money <= moneyLimit)
                {
                    r6Money += 0.1f;
                }
                
            
                if(r6Balls <= ballsLimit)
                {
                    r6Balls += 1;
                }

            }

        foreach (var obj in r7List)
            {
                
                if(r7Money <= moneyLimit)
                {
                    r7Money += 0.1f;
                }
                
            
                if(r7Balls <= ballsLimit)
                {
                    r7Balls += 1;
                }

            }
        #endregion

            totalMoney = gMoney + g2Money + g3Money + g4Money + 
                         yMoney + y2Money + y3Money + y4Money +
                         pMoney + p2Money + p3Money + p4Money + 
                         bMoney + b2Money + b3Money + b4Money +
                         r2Money + r3Money + r4Money + r5Money + r6Money + r7Money +
                         startingMoney;

            
            txt_money.text = " "+ totalMoney.ToString();         
            

            totalBalls = gBalls + g2Balls + g3Balls + g4Balls + 
                         yBalls + y2Balls + y3Balls + y4Balls +
                         pBalls + p2Balls + p3Balls + p4Balls + 
                         bBalls + b2Balls + b3Balls + b4Balls +
                         r2Balls + r3Balls + r4Balls + r5Balls + r6Balls + r7Balls;

            txt_balls.text = " "+totalBalls.ToString();

            
            
            txt_lvClone.text = " " +lvClone +" LVL".ToString();
            txt_costClone.text = " "+costClone.ToString();
            
            txt_lvIncome.text = " "+lvIncome +" LVL".ToString(); 
            txt_costIncome.text = " "+costIncome.ToString();
            
    }

}
