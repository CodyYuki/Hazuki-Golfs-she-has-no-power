using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GolfDistance : MonoBehaviour
{
    public TMP_Text GolfDistanceText;
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
        
        GolfDistanceText.text = "Distance: " + TextUtility.ConvertSecondsToTimeDisplayString(GolfBallCoordinates[0], 0, "", ".");
    }
}
