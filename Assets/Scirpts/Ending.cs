using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public float PlanetTimer;
    public float TextTimer;

    public GameObject Planet;
    public GameObject SplitPlanet;
    public GameObject Explosion;
    public GameObject Text;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlanetTimer -= 1 * Time.deltaTime;
        TextTimer -= 1 * Time.deltaTime;

        if (PlanetTimer <= 0)
        {
            //spawn explosion
            //change planet to split planet
            Planet.SetActive(false);
            SplitPlanet.SetActive(true);
        }


        if (TextTimer <= 0)
        {
            //spawn explosion
            //change planet to split planet
            Text.SetActive(true);
        }



    }
}
