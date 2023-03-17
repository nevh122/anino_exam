using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Slots_Controller : MonoBehaviour
{
    public Reel_Data[] Reels;

    private int Bet_Amount = 1000;
    private int Total_Player_Coins = 1000000;

    public TextMeshProUGUI Display_Bet_Amount;
    public TextMeshProUGUI Display_Total_Player_Coins;

    private bool Is_Rotating;

    //Constantly updates any variable that are needed to be dynamic
    public void Update()
    {
        Display_Total_Player_Coins.text = Total_Player_Coins.ToString();
    }

    //Adds and removes bet amount
    public void Add_Bet()
    {   
        Is_Reel_Spinning();
        if (Is_Rotating == false)
        {
            if (Bet_Amount >= 1000)
                Bet_Amount += 0;
            else
                Bet_Amount += 10;
        }
        Display_Bet_Amount.text = Bet_Amount.ToString();
    }
    public void Reduce_Bet()
    {
        Is_Reel_Spinning();
        if (Is_Rotating == false)
        {
            if (Bet_Amount <= 0)
                Bet_Amount -= 0;
            else
                Bet_Amount -= 10;
        }
        Display_Bet_Amount.text = Bet_Amount.ToString();
    }

    //Controls Spin button, starts when the reels are not spinning and deducts player Total Coins by the ammount of bet.
    public void Reels_Spin_Button()
    {
        Is_Reel_Spinning();
        if(Is_Rotating == false)
        {
            Total_Player_Coins -= Bet_Amount;
            for (int i = 0; i < Reels.Length; i++)
            {
                Reels[i].StartRotate();
            }
        }
    }

    //Checks if the reels are spinning
    public bool Is_Reel_Spinning()
    {
        for (int i = 0; i < Reels.Length; i++)
        {
            if (Reels[i].Is_Rotating == false)
            {
                return Is_Rotating = false;
            }
        }
        return Is_Rotating = true;
    }
}
