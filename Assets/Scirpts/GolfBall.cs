using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class GolfBall : MonoBehaviour
{
    static public float hsp;
    static public float ground;
    static public float bounce;
    static public float SpringLvl;
    static public float VortexLvl;
    static public bool AlreadyShownDialogue;

    public float vsp = 0f;
    public float grv = 0.1f;
    public GameObject toShopButton;
    public GameObject LaunchButton;
    public GameObject Diologue;
    public GameObject BonusCrate;
    public GameObject Ballimage;
    public TMP_Text CrateBonusLvlText;
    public bool ButtonActive = true;
    public float bubbletime = 0;
    public float StillTimer = 40;
    public float StillTimerLimit = 40;

    public float Cratebonustime = 0;
    public float Cratecash = 5;
    public float CrateBonusLvl = 1;

    public float Power = UpdateEXP.levels;
    public float PowerButVertical = UpdateEXP.levels;

    // This makes the function run at the start of every play, even in editor
    // It's required to initialize static things in this function if you have Reload Domain turned off
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    static void Init()
    {
        hsp = 0f;
        ground = -80;
        bounce = 0.2f;
        SpringLvl = 12;
        VortexLvl = 10;
        AlreadyShownDialogue = false;
    }

    void Update()
    {
        Power = UpdateEXP.levels;
        PowerButVertical = UpdateEXP.levels;

        vsp -= grv;
        //transform.position += new Vector3(hsp, vsp, 0);
        //Translate does above ^
        transform.Translate(hsp/2, vsp/2, 0);

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

        Ballimage.transform.Rotate(new Vector3(0, 0, hsp * (-1)), Space.Self);

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
                if (AlreadyShownDialogue == false)
                {
                    Diologue.SetActive(true);
                    AlreadyShownDialogue = true;
                }
                toShopButton.SetActive(true);
                StillTimer = 0;
            }
            
        }
        else
        {
            StillTimer = StillTimerLimit;
        }


        if (Cratebonustime > 0)
        {
            BonusCrate.SetActive(true);
        }
        else
        {
            BonusCrate.SetActive(false);
        }
        Cratebonustime -= 1;
        if (Cratebonustime <= 0)
        {
            Cratebonustime = 0;
            Cratecash = 5;
            CrateBonusLvl = 1;
        }
        if (CrateBonusLvl >= ShopScript.HigherComboLevel)
        {
            CrateBonusLvl = ShopScript.HigherComboLevel;
        }
        CrateBonusLvlText.text = "Combo Bonus:\n" + CrateBonusLvl;



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
                GolfDistance.CashCollected += Cratecash;
                if (Cratebonustime == 0)
                {
                    Cratebonustime = 600;
                    Cratecash += 5;
                }
                else
                {
                    Cratebonustime = 600;
                    CrateBonusLvl += 1;
                    if (CrateBonusLvl == 2)
                    {
                        Cratecash += 5;
                    }
                    if (CrateBonusLvl == 3)
                    {
                        Cratecash += 5;
                    }
                    if (CrateBonusLvl == 4)
                    {
                        Cratecash += 5;
                    }
                    if (CrateBonusLvl == 5)
                    {
                        Cratecash += 5;
                    }
                }
                entity.DisabledWhenTouchedOnce();
            }
            if (entity.EntityName == "Bubble")
            {
                bubbletime = 300;
                entity.DisabledWhenTouchedOnce();
            }
        }





    }

  




    public void GolfBallHit()
    {
        hsp = Power/2;
        vsp = PowerButVertical/2;
        ButtonActive = false;
    }
}
