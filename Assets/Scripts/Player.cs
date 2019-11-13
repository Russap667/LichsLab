using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public int floor;
    public int PlayerLocation;
    public List<string> TempInv = new List<string>();
    public int[] Decision; 
    //dank memes
    public void SavePlayer ()
    {
        //SaveSystem.SavePlayerData(this);
    }

   /* public void LoadPlayer1 ()
    {
        PlayerData data = SaveSystem.LoadPlayerData();
        floor = data.floor;
        for (int i = 0; i < data.Inventory.Length; i++)
        {
            Inventory[i] = data.Inventory[i];
        }
        for (int i = 0; i < data.Decision.Length; i++)
        {
            Decision[i] = data.Decision[i];
        }
    }*/
    public void PickUp(string NewItem)
    {
        //List<string> TempInv = new List<string>();
        for (int x = 0; x < 10; x++)
        {
            //TempInv.Add(Inventory[x]);
        }

        int i = 0;
        while (i < 10)
        {
            string temp = TempInv[i];
            if (temp == "")
            {

                TempInv.Add( NewItem);
                break;
            }
            if (temp[temp.Length - 1] == 'S')
            {
                temp = temp.Substring(0, temp.Length - 1);
            }
            if (NewItem == temp.Substring(2) || NewItem == temp)
            {

                if (temp[0] >= 48 && temp[0] < 58)
                {
                    int temp2 = Int32.Parse(temp[0].ToString());
                    temp2++;
                    TempInv[i] = (temp2.ToString() + ' ' + temp.Substring(2) + "S");
                }
                else
                {
                    TempInv[i] = ("2 " + temp + "S");
                    
                }
            }
            i++;
        }
        for (int x = 0; x < 10; x++)
        {
           // Inventory[x] = TempInv[x];
        }
    }
}
