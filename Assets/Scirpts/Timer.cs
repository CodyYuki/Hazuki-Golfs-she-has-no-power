using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text Timertime;
    public GameObject timeUpMessage;
    public GameObject continueButton;
    public float time = 60f;
    static public bool roundStart = false;

    // Start is called before the first frame update
    void Start()
    {
        roundStart = false;
    }

    // Update is called once per frame
    void Update()
    {
         
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
            }
         }



        Timertime.text = "Time\n" + TextUtility.ConvertSecondsToTimeDisplayString(time, 0, ":", ".");



    }
}
