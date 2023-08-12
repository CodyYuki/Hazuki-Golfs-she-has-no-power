using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public GameObject Dialogue;
    public GameObject Button;
    static public bool AlreadyShownDialogue;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    static void Init()
    {
        AlreadyShownDialogue = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!AlreadyShownDialogue)
        {
            Button.SetActive(false);
            Dialogue.SetActive(true);
            AlreadyShownDialogue = true;
        }


    }



}
