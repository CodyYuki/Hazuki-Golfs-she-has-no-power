using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform GolfBall;
    public Vector3 offset;

    void Update () 
    {
        transform.position = new Vector3 (GolfBall.position.x + offset.x, GolfBall.position.y + offset.y, offset.z); // Camera follows the player with specified offset position
    }
}
