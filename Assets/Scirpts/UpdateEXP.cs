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
    public int expCap = 3;
    static public float levels;

    static public int Health;
    public TMP_Text HealthText;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    static void Init()
    {
        money = 0;
        levels = 60;
        Health = 3;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (money >= expCap)
        {
            money = 0;
            levels++;
            expCap = (expCap + 3);
        }

        
        
        moneyText.text = "EXP: " + money + "\n Level: " + levels;
        HealthText.text = "HP:" + Health;

        if (Health <= 0)
        {
            Timer.time = 0;
        }
    }

    // public void AddMoney()
    // {
    //     money++;
    //     moneyText.text = "EXP: " + money;
    // }
}
