using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickThug : MonoBehaviour
{
    public float risetime = 0.3f;    //default 0.3f
    public float risedistance = 0.05f;   //default 0.05f
    public float lowerdistance = -0.03f;   //default -0.03f
    public float lowertime = 2f;           //default 2f
    public float deletetime = 3f;         //default 3f
    public int TempLvlcapExp = 1;






    public float TempLvlcapice = 1;
    //public float TempLvlcapTime = 1;



    public GameObject explosion;


    void OnMouseDown()
    {
        GameObject explosionclone = Instantiate(explosion) as GameObject;
        explosionclone.transform.position = transform.position; //new Vector3(0,0,0)


        UpdateEXP.money += TempLvlcapExp;

        Destroy(gameObject);
        
    }



    // Update is called once per frame
    void Update()
    {
        TempLvlcapExp = 1 + ShopScript.ExpLevel;

        


        //Uses time to call when to go up and down, not the best way to do it but
        //This was what i figured out at the time
        //basicly im saying i didnt put in the time to find a better way becuase im lazy LOL


        if (risetime > 0)
        {
            risetime -= Time.deltaTime;
            transform.position += new Vector3(0, risedistance, 0);
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

                transform.position += new Vector3(0, lowerdistance, 0);


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




        if (ShopScript.IceLevel >= TempLvlcapice)
        {
            risetime = risetime + 0.006f;    //default 0.3f
            risedistance = risedistance - 0.02f;   //default 0.05f
            lowerdistance = lowerdistance + 0.01f;   //default -0.03f
            lowertime = lowertime + 0.02f;           //default 2f
            deletetime = deletetime + 0.1f;         //default 3f
            TempLvlcapice = TempLvlcapice + 1;
        }







    }
}
