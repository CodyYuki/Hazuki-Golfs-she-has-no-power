using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomOut : MonoBehaviour
{
    public float targetSize = 10;

    public float cameraSize;
    public float currentSize;

    //instead of setting the size directly
    //set the target size

    //and every update step

    //check if the current size is less than the target size
    //if it is, increase the size, and clamp it so it doesnt overshoot
    //if it is more, then decrease the size and clamp it

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        

        if (currentSize < targetSize)
        {
            cameraSize = 250 + (GolfBall.hsp * 10); ;
            cameraSize = Mathf.Clamp(cameraSize, 250f, 500f);
            //clamp Camerazise -- not bigger than 500 i guess?????????
            //nor smaller than 250;
        }


        GetComponent<Camera>().orthographicSize = cameraSize;

    }
}
