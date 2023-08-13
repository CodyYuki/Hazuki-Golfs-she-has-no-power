using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopScript : MonoBehaviour
{

    static public float ShopCash;
    static public float ShopUpGrade;

    public GameObject ShootingUpgrades;
    public GameObject GolfBallUpgrades;

    public TMP_Text ShopCashText;

//---------------Button Text---------------------------------------------------------------------------------
    public TMP_Text IceMagic;
    public TMP_Text ExtraTime;
    public TMP_Text EXPGain;
    public TMP_Text MoreMaxHP;

    public TMP_Text IceMagicPriceTxt;
    public TMP_Text ExtraTimePriceTxt;
    public TMP_Text EXPGainPriceTxt;
    public TMP_Text MoreMaxHPPriceTxt;



    public TMP_Text HigherCombo;
    public TMP_Text BiggerSprings;
    public TMP_Text BouncierBall;
    public TMP_Text StrongerVortex;

    public TMP_Text HigherComboPriceTxt;
    public TMP_Text BiggerSpringsPriceTxt;
    public TMP_Text BouncierBallPriceTxt;
    public TMP_Text StrongerVortexPriceTxt;

    //----------------Levels--------------------------------------------------------------------------------


    static public int IceLevel;
    static public int ExtraTimeLevel;
    static public int ExpLevel;
    static public int MoreMaxHPLevel;

    static public int HigherComboLevel;
    static public int BiggerSpringsLevel;
    static public int BouncierBallLevel;
    static public int StrongerVortexLevel;


//----------------Prices--------------------------------------------------------------------------------


    static public int IceMagicPrice;
    static public int ExtraTimePrice;
    static public int EXPGainPrice;
    static public int MoreMaxHPPrice;

    static public int HigherComboPrice;
    static public int BiggerSpringsPrice;
    static public int BouncierBallPrice;
    static public int StrongerVortexPrice;

    public GameObject Dialogue;
    static public bool AlreadyShownDialogue = false;

    void Start()
    {
        ShopCash += GolfDistance.CashCollected;
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    static void Init()
    {
        ShopCash = 0;
        ShopUpGrade = 0;
        IceLevel = 0;
        ExtraTimeLevel = 0;
        ExpLevel = 0;
        MoreMaxHPLevel = 0;
        HigherComboLevel = 0;
        BiggerSpringsLevel = 0;
        BouncierBallLevel = 0;
        StrongerVortexLevel = 0;
        IceMagicPrice = 1;
        ExtraTimePrice = 0;
        EXPGainPrice = 1;
        MoreMaxHPPrice = 2;
        HigherComboPrice = 2;
        BiggerSpringsPrice = 3;
        BouncierBallPrice = 4;
        StrongerVortexPrice = 4;
        AlreadyShownDialogue = false;
    }




    // Update is called once per frame
    void Update()
    {
        //GolfDistance.CashEarened = ShopCash;

        //public float ShopCash = GolfDistance.CashEarened;

        if (ShopUpGrade >= 8)
        {
            ShootingUpgrades.transform.SetPosY(160);
            GolfBallUpgrades.transform.SetPosY(-17);
        }

        if (!AlreadyShownDialogue)
        {
            Dialogue.SetActive(true);
            AlreadyShownDialogue = true;
        }

        // Dollar sign prices on button
        IceMagicPriceTxt.text = "$" + IceMagicPrice;
        ExtraTimePriceTxt.text = "$" + ExtraTimePrice;
        EXPGainPriceTxt.text = "$" + EXPGainPrice;
        MoreMaxHPPriceTxt.text = "$" + MoreMaxHPPrice;

        HigherComboPriceTxt.text = "$" + HigherComboPrice;
        BiggerSpringsPriceTxt.text = "$" + BiggerSpringsPrice;
        BouncierBallPriceTxt.text = "$" + BouncierBallPrice;
        StrongerVortexPriceTxt.text = "$" + StrongerVortexPrice;



        //Shows the Number of the current Level
        IceMagic.text = "Level: " + IceLevel;
        ExtraTime.text = "Level: " + ExtraTimeLevel;
        EXPGain.text = "Level: " + ExpLevel;
        MoreMaxHP.text = "Level: " + MoreMaxHPLevel;

        HigherCombo.text = "Level: " + HigherComboLevel;
        BiggerSprings.text = "Level: " + BiggerSpringsLevel;
        BouncierBall.text = "Level: " + BouncierBallLevel;
        StrongerVortex.text = "Level: " + StrongerVortexLevel;

        
        ShopCashText.text = "Cash \n$" + (int)ShopCash;
    }



    //Shooting game upgrades
        public void IceText()
    {
        if ((ShopCash >= IceMagicPrice) && (IceLevel < 20))
        {
            ShopCash = ShopCash - IceMagicPrice;
            IceMagicPrice = IceMagicPrice + 4;
            IceLevel = IceLevel + 1;
            ClickThug.Speed -= 0.04f;  //originally 0.035f
            ClickThug.AnimationSpeedValue -= 0.09f;
            ShopUpGrade += 1;
        }
    }
        public void ExtraText()
    {
        if ((ShopCash >= ExtraTimePrice) && (ExtraTimeLevel < 20))
        {
            ShopCash = ShopCash - ExtraTimePrice;
            ExtraTimePrice = ExtraTimePrice + 5;
            ExtraTimeLevel = ExtraTimeLevel + 1;
            ShopUpGrade += 1;
        }
    }
        public void EXPText()
    {
        if ((ShopCash >= EXPGainPrice) && (ExpLevel < 10))
        {
            ShopCash = ShopCash - EXPGainPrice;
            EXPGainPrice = EXPGainPrice + 4;
            ExpLevel = ExpLevel + 1;
            ShopUpGrade += 1;
        }        
    }
        public void MaxHPText()
    {
        if ((ShopCash >= MoreMaxHPPrice) && (MoreMaxHPLevel < 20))
        {
            ShopCash = ShopCash - MoreMaxHPPrice;
            MoreMaxHPPrice = MoreMaxHPPrice + 4;
            MoreMaxHPLevel = MoreMaxHPLevel + 1;
            ShopUpGrade += 1;
        }         
    }




    //Golf game Upgrades
    public void HigherLVL()
    {
        if ((ShopCash >= HigherComboPrice) && (HigherComboLevel < 5))
        {
            ShopCash = ShopCash - HigherComboPrice;
            HigherComboPrice = HigherComboPrice + 6;
            HigherComboLevel = HigherComboLevel + 1;
            ShopUpGrade += 1;
        }
    }

    public void BiggerSpringsLVL()
    {
        if ((ShopCash >= IceMagicPrice) && (BiggerSpringsLevel < 20))
        {
            ShopCash = ShopCash - BiggerSpringsPrice;
            BiggerSpringsPrice = BiggerSpringsPrice + 2;
            BiggerSpringsLevel = BiggerSpringsLevel + 1;
            GolfBall.SpringLvl = GolfBall.SpringLvl + 1;
            ShopUpGrade += 1;
        }
    }

    public void BouncierBallLVL()
    {
        if ((ShopCash >= BouncierBallPrice) && (BouncierBallLevel < 20))
        {
            ShopCash = ShopCash - BouncierBallPrice;
            BouncierBallPrice = BouncierBallPrice + 4;
            BouncierBallLevel = BouncierBallLevel + 1;
            GolfBall.bounce = GolfBall.bounce + 0.03f;
            ShopUpGrade += 1;
        }
    }

    public void StrongerVortexLVL()
    {
        if ((ShopCash >= StrongerVortexPrice) && (StrongerVortexLevel < 20))
        {
            ShopCash = ShopCash - StrongerVortexPrice;
            StrongerVortexPrice = StrongerVortexPrice + 2;
            StrongerVortexLevel = StrongerVortexLevel + 1;
            GolfBall.VortexLvl = GolfBall.VortexLvl + 1;
            ShopUpGrade += 1;
        }
    }





}
