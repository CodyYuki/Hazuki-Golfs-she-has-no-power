using UnityEngine;

public class ClickThug : MonoBehaviour
{
    //public float risetime = 0.3f;    //default 0.3f
    //public float risedistance = 0.05f;   //default 0.05f
    //public float lowerdistance = -0.03f;   //default -0.03f
    //public float lowertime = 2f;           //default 2f
    //public float deletetime = 3f;         //default 3f
    public int TempLvlcapExp = 1;

    public float SpawnPos = 0f;
    public float CurrentPos = 0f;
    static public float Speed;
    public float Pos;
    public float PosTimer = 20;


    public Entity Thug;

    Animator ThugAnimator;
    static public float AnimationSpeedValue;


    public float TempLvlcapice = 1;
    //public float TempLvlcapTime = 1;


    public GameObject explosion;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    static void Init()
    {
        Speed = 1f;
        AnimationSpeedValue = 2.8f;
    }


    void OnMouseDown()
    {
        GameObject explosionclone = Instantiate(explosion) as GameObject;
        explosionclone.transform.position = transform.position; //new Vector3(0,0,0)

        UpdateEXP.money += TempLvlcapExp;

        PlayHitSound.PlayHit = true;

        Destroy(gameObject);
        
    }

    private void Start()
    {
        SpawnPos = transform.position.y;
        ThugAnimator = gameObject.GetComponent<Animator>();
    }



    // Update is called once per frame
    void Update()
    {
        TempLvlcapExp = 1 + (2 * ShopScript.ExpLevel);


        ThugAnimator.speed = AnimationSpeedValue;

        //Uses time to call when to go up and down, not the best way to do it but
        //This was what i figured out at the time
        //basicly im saying i didnt put in the time to find a better way becuase im lazy LOL


        //if (risetime > 0)
        //{
        //    risetime -= Time.deltaTime;
        //    transform.position += new Vector3(0, risedistance, 0);
        //}
        //else
        //{
        //    transform.position += new Vector3(0, 0.0f, 0);

        //    if (lowertime > 0)
        //    {
        //        lowertime -= Time.deltaTime;
        //    }
        //    else
        //    {

        //        transform.position += new Vector3(0, lowerdistance, 0);


        //    }
        //}

        //if (deletetime > 0)
        //{
        //    deletetime -= Time.deltaTime;
        //}
        //else
        //{
        //    Destroy(gameObject);
        //}

        //Okay maybe this wasnt the best way to do it, since the upgrade to slow down the thugs breaks this a bit

        //when spcawn save position in val
        //then move up with speed for a certain distance
        //when it reached that point stop, and then
        //timer starts,this plays the animation of shooting
        //thenwhen timer is up go back down and delete


        CurrentPos = transform.position.y;
        Pos = CurrentPos - SpawnPos;
        if (Pos < 6 && PosTimer > 0)
        {
            transform.position += new Vector3(0, Speed, 0);
        }

        if (Pos >= 6)
        {
            PosTimer -= 0.01f;
            
        }

        

        if (PosTimer <= 0)
        {          
            transform.position -= new Vector3(0, Speed, 0);
            Pos = SpawnPos - CurrentPos;
            if (Pos > 20)
            {
                Destroy(gameObject);
            }
        }



        





        if (ShopScript.IceLevel >= TempLvlcapice)
        {
            //risetime = risetime + 0.006f;    //default 0.3f
            //risedistance = risedistance - 0.02f;   //default 0.05f
            //lowerdistance = lowerdistance + 0.01f;   //default -0.03f
            //lowertime = lowertime + 0.02f;           //default 2f
            //deletetime = deletetime + 0.1f;         //default 3f
            
            TempLvlcapice = TempLvlcapice + 1;
            
        }



    }


    public void GetHit()
    {
        UpdateEXP.Health -= 1;
    }

    public void Despawn()
    {
        Destroy(gameObject);
    }


}
