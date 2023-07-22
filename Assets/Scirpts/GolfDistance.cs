using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GolfDistance : MonoBehaviour
{
    public TMP_Text GolfDistanceText;
    public TMP_Text CashEarenedText;
    public int CashEarened = 20;
    public GameObject GolfBall;
    // if not using TMP, make line 8 public Text moneyText;

    static public float leDisvels = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 GolfBallCoordinates = GolfBall.transform.position;
        GolfBallCoordinates = GolfBallCoordinates / 200;

        Vector2 GolfPosition = GolfBall.transform.position;
        CashEarened = (int)(GolfPosition.x / 250);





        GolfDistanceText.text = "Distance: " + TextUtility.ConvertSecondsToTimeDisplayString(GolfBallCoordinates[0], 0, "", ".");

        CashEarenedText.text = "Cash \n$" + CashEarened;
        ShopScript.Cash = CashEarened;








    }




}
