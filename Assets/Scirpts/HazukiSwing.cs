using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazukiSwing : MonoBehaviour
{
    public Entity Hazuki;
    public GolfBall Golfball;
    public void HazukiSwinging()
    {
        Hazuki.PlayAnimation();
    }
    public void BallHit()
    {
        Golfball.GolfBallHit();
    }    

}
