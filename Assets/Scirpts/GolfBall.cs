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


    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Entity entity = collision.gameObject.GetComponent<Entity>();
        if(entity != null)
        {
            if(entity.EntityName == "Spring")
            {
                hsp = hsp + 5;
                vsp = vsp + 20;
            }
            if (entity.EntityName == "Vortex")
            {
                hsp = hsp + 20;
                vsp = vsp + 5;
            }
            if (entity.EntityName == "Sandpit")
            {
                hsp = hsp - 10;
                vsp = vsp - 5;
            }
            if (entity.EntityName == "Speedpad")
            {
                hsp = hsp + 10;
            }
            if (entity.EntityName == "MoneyCrate")
            {
                GolfDistance.CashCollected += 20;
                entity.DisabledWhenTouchedOnce();
            }
            if (entity.EntityName == "Bubble")
            {
                vsp = vsp + 20;
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
