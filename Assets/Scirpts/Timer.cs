using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text Timertime;
    public GameObject timeUpMessage;
    public GameObject continueButton;
    public float time = 5f;
    static public bool roundStart = false;
    public float TempLvlcapTime = 1;


    // Start is called before the first frame update
    void Start()
    {
        roundStart = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ShopScript.ExtraTimeLevel >= TempLvlcapTime)
        {
            time = time + 2 * ShopScript.ExtraTimeLevel;
            TempLvlcapTime++;
        }


        if (roundStart == true)
         {
            UpdateEXP.Health = 3 + ShopScript.MoreMaxHPLevel;
            if (time > 0)
            {
                time -= Time.deltaTime;
            }
            else
            {
                roundStart = false;
                timeUpMessage.SetActive(true);
                continueButton.SetActive(true);
            }
         }


        Timertime.text = "Time\n" + TextUtility.ConvertSecondsToTimeDisplayString(time, 0, ":", ".");



    }
}
