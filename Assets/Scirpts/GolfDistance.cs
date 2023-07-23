using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GolfDistance : MonoBehaviour
{
    public TMP_Text GolfDistanceText;
    public TMP_Text CashEarenedText;
    public int CashEarened = 0;
    public GameObject GolfBall;





    // if not using TMP, make line 8 public Text moneyText;



    public float CurrentFrame;
    public float LastFrame;
    public float DistanceInBetween;
    static public float CashCollected;

    private void Start()
    {
        LastFrame = GolfBall.transform.position.x;
        DistanceInBetween = 0;
        CashCollected = 0;
    }




    // Update is called once per frame
    void Update()
    {
        //Vector2 GolfBallCoordinates = GolfBall.transform.position;
        //GolfBallCoordinates = GolfBallCoordinates / 200;

        //Vector2 GolfPosition = GolfBall.transform.position;
        //CashEarened = (int)(GolfPosition.x / 250);


        //GolfDistanceText.text = "Distance: " + TextUtility.ConvertSecondsToTimeDisplayString(GolfBallCoordinates[0], 0, "", ".");

        //CashEarenedText.text = "Cash \n$" + CashEarened;
        //ShopScript.Cash = CashEarened;



        CurrentFrame = GolfBall.transform.position.x;

        DistanceInBetween = CurrentFrame - LastFrame;



        CashCollected += DistanceInBetween/250;

        CashEarenedText.text = "Cash \n$" + (int)CashCollected;
        GolfDistanceText.text = "Distance: " + (int)CashCollected + "ft";



        LastFrame = GolfBall.transform.position.x;


    }


    //public void GainMoneyForDistance()
    //{
        
    //    Vector3 gStartingPosition = GolfBallCoordinates;

    //    Vector3 gCurrentPosition = GolfBall.transform.position - gStartingPosition;

    //    CashCollected = gCurrentPosition - gStartingPosition;

    //}




}
