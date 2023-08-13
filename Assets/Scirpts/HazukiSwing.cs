using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (UpdateEXP.levels >= 200)
        {
            SceneManager.LoadScene(4);
        }
    }    

}
