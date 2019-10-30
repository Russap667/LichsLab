using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
