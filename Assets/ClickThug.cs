using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickThug : MonoBehaviour
{
    public float risetime = 0.3f;
    public float lowertime = 2f;
    public float deletetime = 3f;


    void OnMouseDown()
    {
        UpdateEXP.money += 1;
        Destroy(gameObject);
    }








    // Update is called once per frame
    void Update()
    {
        
        
        //Debug.Log("Clicked");


        if (risetime > 0)
        {
            risetime -= Time.deltaTime;
            transform.position += new Vector3(0, 0.05f, 0);
        }
        else
        {
            transform.position += new Vector3(0, 0.0f, 0);

            if (lowertime > 0)
            {
                lowertime -= Time.deltaTime;
            }
            else
            {

                transform.position += new Vector3(0, -0.03f, 0);


            }
        }

        if (deletetime > 0)
        {
            deletetime -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }



      

    }
}
