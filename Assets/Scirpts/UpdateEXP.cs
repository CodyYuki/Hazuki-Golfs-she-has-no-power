using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//include line 4 if using TPM

public class UpdateEXP : MonoBehaviour
{
    public TMP_Text moneyText;
    // if not using TMP, make line 8 public Text moneyText;
    static public int money;
    static public int expCap = 5;
    static public float levels = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (money == expCap)
        {
            money = 0;
            levels++;
            expCap = expCap + ((expCap * 2)/4);
        }

        
        
        moneyText.text = "EXP: " + money + "\n Level: " + levels;
    }

    // public void AddMoney()
    // {
    //     money++;
    //     moneyText.text = "EXP: " + money;
    // }
}