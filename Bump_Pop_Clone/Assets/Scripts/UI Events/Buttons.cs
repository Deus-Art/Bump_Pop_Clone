using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    Counting counting;
    InstantiateEvent instantiateEvent;
    int addOne, countUp;

    [SerializeField]
    GameObject countingUi;

    public GameObject settingsDropDown, settingsIcon;
    
    private void Awake() 
    {
        counting = countingUi.GetComponent<Counting>();        
    }
    
    public void CloneIncreaseButton()
    {   
        if(counting.totalMoney >= counting.costClone)
        {
            counting.totalMoney -= counting.costClone;
            counting.startingMoney -= counting.costClone;

            addOne = 1;
            counting.ballsLimit += 1;
            counting.costClone += counting.costClone * 2;
            counting.lvClone += 1;

            InstantiateEvent[] instantiateEvent = GameObject.FindObjectsOfType<InstantiateEvent>();

            foreach (InstantiateEvent item in instantiateEvent)
            {
                countUp = item.GetComponent<InstantiateEvent>().instantValue += addOne;
            }
        }
    }

    public void IncomeIncreaseButton()
    {
        if(counting.totalMoney >= counting.costIncome)
        {
            counting.totalMoney -= counting.costIncome;
            counting.startingMoney -= counting.costIncome;

            counting.moneyLimit += 0.2f;
            counting.costIncome += counting.costIncome * 2;
            counting.lvIncome += 1;
        }
    }

    public void RestartGame()
    {

        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;

    }

    public void SettingsIconButtonClose()
    {
        settingsIcon.SetActive(false);
        settingsDropDown.SetActive(true);
    }

    public void SettingsIconButtonOpen()
    {
        settingsIcon.SetActive(true);
        settingsDropDown.SetActive(false);
    }

    public void NextLevel()
    {
        
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;

    }
}
