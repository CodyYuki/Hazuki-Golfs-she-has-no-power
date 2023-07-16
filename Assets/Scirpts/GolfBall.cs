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
    public Entity Hazuki;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hsp -= 0.04f;
        if (hsp <= 0)
        {
        hsp = 0;
        }

        vsp -= 0.1f;
        if (vsp <= 0)
        {
        vsp = 0;
        }

    if (!LaunchButton.activeSelf)
    {
        if (hsp == 0 && vsp == 0)
        {
            toShopButton.SetActive(true);
        }
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
                hsp = hsp + 10;
                vsp = vsp + 5;
            }
        }
    }

  

    static public float Power = UpdateEXP.levels;
    static public float PowerButVertical = UpdateEXP.levels / 2;


    public void GolfBallHit()
    {
        hsp = Power;
        vsp = PowerButVertical;
    }
}
