using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData 
{
    public int floor;
    public int PlayerLocation;
    public string[] Inventory;
    public int[] Decision;
    

    public PlayerData (Player p)
    {
        floor = p.floor;
        PlayerLocation = p.PlayerLocation;
        Inventory = p.Inventory;
        Decision = p.Decision;
    }


}
