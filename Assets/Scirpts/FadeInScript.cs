using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeInScript : MonoBehaviour
{

    public float xmove;
    static public bool FadeOutTrue;
    public string FadeInName;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            xmove -= 1 * Time.deltaTime;
            if (xmove <= 0)
            {
                xmove = 0;
            }

            transform.Translate(xmove, 0, 0);

        if (FadeInName == "canvas")
        {
            if (xmove <= 19)
            {
                Destroy(gameObject);
            }
        }

    }
}
