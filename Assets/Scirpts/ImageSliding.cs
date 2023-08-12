using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageSliding : MonoBehaviour
{
    public float slideSpeed = 10f;          // unity units per second
    public float slideAcceleration = -10f;  // speed per second
    public float slideWaitTime = 0f;        // seconds to wait before starting
    public bool slideRight = true;

    // Update is called once per frame
    void Update()
    {
        // Wait until the wait time is at 0 and clamp it at 0.
        if(slideWaitTime > 0f)
        {
            slideWaitTime -= Time.deltaTime;
            if(slideWaitTime < 0f)
            {
                slideWaitTime = 0f;
            }
        }

        if(slideWaitTime <= 0f)
        {
            slideSpeed += slideAcceleration * Time.deltaTime;
            if(slideSpeed < 0f)
            {
                slideSpeed = 0f;
            }

            float directionMultiplier;
            if(slideRight) { directionMultiplier = 1.0f; }
            else           { directionMultiplier = -1.0f; }

            transform.Translate(slideSpeed * directionMultiplier * Time.deltaTime, 0f, 0f);
        }



        //randomTimer -= Time.deltaTime;
        //slideSpeed -= 0.01f * Time.deltaTime;

        //if (slideSpeed <= 0)
        //{
        //    slideSpeed = 0;
        //}

        //if (entityName == "Hazuki")
        //{
        //    transform.Translate(slideSpeed * (-1) * Time.deltaTime, 0, 0);
        //}

        //if (entityName == "Title")
        //{
        //    if (randomTimer <= 0)
        //    {
        //        randomTimer = 0;
        //        transform.Translate(slideSpeed * (-1) * Time.deltaTime, 0, 0);
        //    }
        //}


        //if (entityName == "Menu")
        //{
        //    if (randomTimer <= 0)
        //    {
        //        randomTimer = 0;
        //        transform.Translate(slideSpeed * (-1) * Time.deltaTime, 0, 0);
        //    }
        //}


        //if (entityName == "Chizuru")
        //{
        //    if (randomTimer <= 0)
        //    {
        //        randomTimer = 0;
        //        transform.Translate(slideSpeed * Time.deltaTime, 0, 0);
        //    }
            
        //}

    }
}
