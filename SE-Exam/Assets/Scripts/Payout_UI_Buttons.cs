using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Handles Information menu buttons and interactions
public class Payout_UI_Buttons : MonoBehaviour
{
    public GameObject PO_Menu;

    public GameObject Layout_1, Layout_2, Layout_3;
    private float Current_Layout = 1f;

    //to be called by buttons to open and close the info menu
    public void Click_PO_Close()
    {
        PO_Menu.SetActive(false);
    }

    public void Click_PO_Menu()
    {
        PO_Menu.SetActive(true);
    }
    
    //information menu switching screens
    public void Next_LayoutScreen()
    {
        Current_Layout += 1;
        if(Current_Layout >= 4)
        {
            Current_Layout = 1;
        }

        switch (Current_Layout)
        {
            case 1:
                Layout_1.SetActive(true);
                Layout_2.SetActive(false);
                Layout_3.SetActive(false);
                return;
            case 2:
                Layout_1.SetActive(false);
                Layout_2.SetActive(true);
                Layout_3.SetActive(false);
                return;
            case 3:
                Layout_1.SetActive(false);
                Layout_2.SetActive(false);
                Layout_3.SetActive(true);
                return;
        }
    }
    public void Previous_LayoutScreen()
    {
        Current_Layout -= 1;
        if (Current_Layout <= 0)
        {
            Current_Layout = 3;
        }

        switch (Current_Layout)
        {
            case 1:
                Layout_1.SetActive(true);
                Layout_2.SetActive(false);
                Layout_3.SetActive(false);
                return;
            case 2:
                Layout_1.SetActive(false);
                Layout_2.SetActive(true);
                Layout_3.SetActive(false);
                return;
            case 3:
                Layout_1.SetActive(false);
                Layout_2.SetActive(false);
                Layout_3.SetActive(true);
                return;
        }
    }
}
