using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerData 
{
    public int floor;
    public int PlayerLocation;
    readonly List<string> TempInv = new List<string>();
    public int[] Decision;
    

    public PlayerData (Player p)
    {
        floor = p.floor;
        PlayerLocation = p.PlayerLocation;
        //Inventory = p.Inventory;
        Decision = p.Decision;
    }


}
