using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleChisuru : MonoBehaviour
{
    
    public float hsp = 8f;
    public float xgoal = 920f;
    public float xpos = 2300f;
    public float hspslower = 0.005f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hspslower = hspslower + 0.001f;
        hsp = hsp - hspslower;
        if (hsp <= 0)
        {
            hsp = 0;
        }

        if (xpos >= xgoal)
        {

            xpos = xpos - hsp;
            transform.position += new Vector3(hsp, 0, 0);
        }
        
        
        
    }
}
