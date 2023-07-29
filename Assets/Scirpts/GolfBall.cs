using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GolfBall : MonoBehaviour
{
    public float hsp = 0f;
    public float vsp = 0f;
    public float grv = 0.1f;
    public GameObject toShopButton;
    public GameObject LaunchButton;
    public bool ButtonActive = true;
    public float bubbletime = 0;
    public float StillTimer = 40;
    public float StillTimerLimit = 40;
    static public float ground = -67;
    static public float bounce = 0.2f;
    static public float SpringLvl = 10;
    static public float VortexLvl = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        vsp -= grv;
        //transform.position += new Vector3(hsp, vsp, 0);
        //Translate does above ^
        transform.Translate(hsp, vsp, 0);

        hsp -= 0.02f;
        if (hsp <= 0)
        {
        hsp = 0;
        }


        



        if (transform.position.y <= ground)
        {
            transform.SetPosY(ground);
            if (vsp < 0)
            {
                if (vsp < -1)
                {
                    vsp *= -1;
                    vsp *= bounce;
                }
                else
                {
                    vsp = 0;
                }
            }
        }

        if (Mathf.Abs(vsp) < 0.00001f)
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
            StillTimer -= 0.1f;
            if (StillTimer <= 0)
            {
                toShopButton.SetActive(true);
                StillTimer = 0;
            }
            
        }
        else
        {
            StillTimer = StillTimerLimit;
        }



        



        if (bubbletime > 0)
        {
            vsp = vsp + 0.25f;
            hsp = 4;

        }
        bubbletime = bubbletime - 1;

        if (bubbletime <= 0)
        {
            bubbletime = 0;
        }

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Entity entity = collision.gameObject.GetComponent<Entity>();
        if(entity != null)
        {
            Debug.Log(entity.EntityName);
            if (entity.EntityName == "Spring")
            {
                hsp = 3;
                vsp = SpringLvl;
            }
            if (entity.EntityName == "Vortex")
            {
                hsp = hsp + VortexLvl;
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

  

    public float Power = UpdateEXP.levels;
    public float PowerButVertical = UpdateEXP.levels / 2;


    public void GolfBallHit()
    {
        hsp = Power;
        vsp = PowerButVertical;
        ButtonActive = false;
    }
}
