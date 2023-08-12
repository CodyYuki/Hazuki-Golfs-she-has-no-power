using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    static public float time;
    static public bool roundStart;

    public TMP_Text Timertime;
    public GameObject timeUpMessage;
    public GameObject continueButton;
    public float TempLvlcapTime = 0;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    static void Init()
    {
        time = 5f; // default 5
        roundStart = false;
    }

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
            time = 5 + (2 * ShopScript.ExtraTimeLevel);
            TempLvlcapTime++;
        }

        if (roundStart == false)
        {
            UpdateEXP.Health = 3 + ShopScript.MoreMaxHPLevel;
        }
    


        if (roundStart == true)
         {
            
            if (time > 0)
            {
                time -= Time.deltaTime;
            }
            else
            {
                roundStart = false;
                timeUpMessage.SetActive(true);
                continueButton.SetActive(true);
                time = 5f;
            }
         }


        Timertime.text = "Time\n" + TextUtility.ConvertSecondsToTimeDisplayString(time, 0, ":", ".");



    }
}
