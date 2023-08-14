using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOutScript : MonoBehaviour
{
    public float xmove;
    public bool FadeOutTrue;
    public bool FadeOutCanvasTrue;
    public int scenenumber = 1;

    static public FadeOutScript Singleton;

    public string FadeOutNumber;

    private void Awake()
    {
        Singleton = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FadeOutNumber == "Menu")
        {
            if (FadeOutTrue == true)
            {
                xmove -= 1 * Time.deltaTime;
                if (xmove <= 0)
                {
                    xmove = 0;
                    SceneManager.LoadScene(scenenumber);
                }

                transform.Translate(xmove, 0, 0);
            }
        }


        if (FadeOutNumber == "Thug")
        {
            if (FadeOutTrue == true)
            {
                xmove -= 1 * Time.deltaTime;
                if (xmove <= 0)
                {
                    xmove = 0;
                    SceneManager.LoadScene(scenenumber);
                }

                transform.Translate(xmove, 0, 0);
            }
        }



        if (FadeOutNumber == "Golf")
        {
            if (FadeOutCanvasTrue == true)
            {
                xmove -= 1 * Time.deltaTime;
                if (xmove <= 18.8)
                {
                    xmove = 0;
                    SceneManager.LoadScene(scenenumber);
                }

                transform.Translate(xmove, 0, 0);
            }
        }



        if (FadeOutNumber == "Shop")
        {
            if (FadeOutCanvasTrue == true)
            {
                xmove -= 1 * Time.deltaTime;
                if (xmove <= 19.4)
                {
                    xmove = 0;
                    SceneManager.LoadScene(scenenumber);
                }

                transform.Translate(xmove, 0, 0);
            }
        }



    }

    public void FadeOut()
    {
        FadeOutCanvasTrue = true;
        FadeOutTrue = true;
    }

    

}
