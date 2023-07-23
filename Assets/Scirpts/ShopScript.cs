using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopScript : MonoBehaviour
{

    static public float ShopCash = 0;


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


    static public int IceLevel = 0;
    static public int ExtraTimeLevel = 0;
    static public int ExpLevel = 0;
    static public int MoreMaxHPLevel = 0;

    static public int HigherComboLevel = 0;
    static public int BiggerSpringsLevel = 0;
    static public int BouncierBallLevel = 0;
    static public int StrongerVortexLevel = 0;


//----------------Prices--------------------------------------------------------------------------------


    static public int IceMagicPrice = 10;
    static public int ExtraTimePrice = 0;
    static public int EXPGainPrice = 2;
    static public int MoreMaxHPPrice = 8;

    static public int HigherComboPrice = 15;
    static public int BiggerSpringsPrice = 10;
    static public int BouncierBallPrice = 8;
    static public int StrongerVortexPrice = 14;    


    void Start()
    {
        ShopCash += GolfDistance.CashCollected;
    }


    

    // Update is called once per frame
    void Update()
    {
        //GolfDistance.CashEarened = ShopCash;

        //public float ShopCash = GolfDistance.CashEarened;





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
            IceMagicPrice = IceMagicPrice + 8;
            IceLevel = IceLevel + 1;
        }
    }
        public void ExtraText()
    {
        if ((ShopCash >= ExtraTimePrice) && (ExtraTimeLevel < 20))
        {
            ShopCash = ShopCash - ExtraTimePrice;
            ExtraTimePrice = ExtraTimePrice + 4;
            ExtraTimeLevel = ExtraTimeLevel + 1;
        }
    }
        public void EXPText()
    {
        if ((ShopCash >= EXPGainPrice) && (ExpLevel < 20))
        {
            ShopCash = ShopCash - EXPGainPrice;
            EXPGainPrice = EXPGainPrice + 4;
            ExpLevel = ExpLevel + 1;
        }        
    }
        public void MaxHPText()
    {
        if ((ShopCash >= MoreMaxHPPrice) && (MoreMaxHPLevel < 5))
        {
            ShopCash = ShopCash - MoreMaxHPPrice;
            MoreMaxHPPrice = MoreMaxHPPrice + 8;
            MoreMaxHPLevel = MoreMaxHPLevel + 1;
        }         
    }




    //Golf game Upgrades
    public void HigherLVL()
    {
        if ((ShopCash >= HigherComboPrice) && (HigherComboLevel < 20))
        {
            ShopCash = ShopCash - HigherComboPrice;
            HigherComboPrice = HigherComboPrice + 8;
            HigherComboLevel = HigherComboLevel + 1;
        }
    }

    public void BiggerSpringsLVL()
    {
        if ((ShopCash >= IceMagicPrice) && (BiggerSpringsLevel < 20))
        {
            ShopCash = ShopCash - BiggerSpringsPrice;
            BiggerSpringsPrice = BiggerSpringsPrice + 8;
            BiggerSpringsLevel = BiggerSpringsLevel + 1;
        }
    }

    public void BouncierBallLVL()
    {
        if ((ShopCash >= BouncierBallPrice) && (BouncierBallLevel < 20))
        {
            ShopCash = ShopCash - BouncierBallPrice;
            BouncierBallPrice = BouncierBallPrice + 8;
            BouncierBallLevel = BouncierBallLevel + 1;
        }
    }

    public void StrongerVortexLVL()
    {
        if ((ShopCash >= StrongerVortexPrice) && (StrongerVortexLevel < 20))
        {
            ShopCash = ShopCash - StrongerVortexPrice;
            StrongerVortexPrice = StrongerVortexPrice + 8;
            StrongerVortexLevel = StrongerVortexLevel + 1;
        }
    }





}
