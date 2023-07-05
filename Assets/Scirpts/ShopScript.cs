using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopScript : MonoBehaviour
{

    public TMP_Text IceMagic;
    public TMP_Text ExtraTime;
    public TMP_Text EXPGain;
    public TMP_Text CutePoint;


    static public int IceLevel = 0;
    static public int ExtraLevel = 0;
    static public int ExpLevel = 0;
    static public int CuteLevel = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        IceMagic.text = "Level: " + IceLevel;
        ExtraTime.text = "Level: " + ExtraLevel;
        EXPGain.text = "Level: " + ExpLevel;
        CutePoint.text = "Level: " + CuteLevel;

    }

        public void IceText()
    {
        IceLevel = IceLevel + 1;
    }
        public void ExtraText()
    {
        ExtraLevel = ExtraLevel + 1;
    }
        public void EXPText()
    {
        ExpLevel = ExpLevel + 1;
    }
        public void CuteText()
    {
        CuteLevel = CuteLevel + 1;
    }
    





}
