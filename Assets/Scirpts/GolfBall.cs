using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolfBall : MonoBehaviour
{
    static public float hsp = 0f;
    static public float vsp = 0f;
    static public float grv = 2f;
    public GameObject toShopButton;
    public GameObject LaunchButton;
    public bool ButtonActive = true;
    public float bubbletime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hsp -= 0.01f;
        if (hsp <= 0)
        {
        hsp = 0;
        }

        vsp -= 0.1f;
        if (vsp <= 0)
        {
        vsp = 0;
        }

    // if (!LaunchButton.activeSelf)
    // {
    //     if (hsp == 0 && vsp == 0)
    //     {
    //      toShopButton.SetActive(true);
    //     }
    // }



    if (!LaunchButton.activeSelf)
    {
        if (hsp >= 0.0001)
        {
            ButtonActive = false;
        }
    }


        if (hsp == 0 && vsp == 0 && ButtonActive == false)
        {
            toShopButton.SetActive(true);
        }



        transform.position += new Vector3(hsp, vsp, 0);



        if (bubbletime > 0)
        {
            vsp = vsp + 0.25f;
            hsp = 4;
        }
        bubbletime = bubbletime - 1;



    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Entity entity = collision.gameObject.GetComponent<Entity>();
        if(entity != null)
        {
            if(entity.EntityName == "Spring")
            {
                hsp = 5;
                vsp = vsp + 20;
            }
            if (entity.EntityName == "Vortex")
            {
                hsp = hsp + 10;
                vsp = 2;
            }
            if (entity.EntityName == "Sandpit")
            {
                hsp = hsp - 4;
                vsp = vsp - 2;
            }
            if (entity.EntityName == "Speedpad")
            {
                hsp = hsp + 10;
                vsp = 1;
            }
            if (entity.EntityName == "MoneyCrate")
            {
                GolfDistance.CashCollected += 20;
                entity.DisabledWhenTouchedOnce();
            }
            if (entity.EntityName == "Bubble")
            {
                bubbletime = 300;
                entity.DisabledWhenTouchedOnce();
            }
        }





    }

  

    static public float Power = UpdateEXP.levels;
    static public float PowerButVertical = UpdateEXP.levels / 2;


    public void GolfBallHit()
    {
        hsp = Power;
        vsp = PowerButVertical;
        ButtonActive = false;
    }
}
