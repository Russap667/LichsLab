using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public int floor;
    public int PlayerLocation;
    public string[] Inventory = new string[10];
    public int[] Decision; 

    public void SavePlayer ()
    {
        SaveSystem.SavePlayerData(this);
    }

    public void LoadPlayer1 ()
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
    }
    public void PickUp(string NewItem)
    {
        string[] ItemArray = Inventory;

        int i = 0;
        while (i < 10)
        {
            string temp = ItemArray[i];
            if (temp == "")
            {

                ItemArray[i] = NewItem;
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
                    ItemArray[i] = (temp2.ToString() + ' ' + temp.Substring(2) + "S");
                }
                else
                {
                    ItemArray[i] = ("2 " + temp + "S");
                    
                }
            }
            i++;
        }
        
       
            Inventory = ItemArray;
        
    }
}
