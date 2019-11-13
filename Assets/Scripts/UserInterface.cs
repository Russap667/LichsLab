using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UserInterface : MonoBehaviour
{
    
    




    public void ForwardDirection(Player p)
    {
        switch (p.PlayerLocation)
        {
            case 0: case 2:
                p.PlayerLocation++;
                break;
            case 1:
                p.PlayerLocation += 3;
                break;
            case 3:
                p.PlayerLocation += 4;
                break;
        }
        
    }
    public void LeftDirection(Player p)
    {
        switch (p.PlayerLocation)
        {
            case 1:
                p.PlayerLocation++;
                break;
            case 4:
                p.PlayerLocation += 4;
                break;
            case 3:
                p.PlayerLocation += 2;
                break;
            case 9:
                p.PlayerLocation -= 5;
                break;
            case 6:
                p.PlayerLocation -= 3;
                break;
        }

    }
    public void RightDirection(Player p)
    {
        switch (p.PlayerLocation)
        {
            
            case 4:
                p.PlayerLocation += 5;
                break;
            case 3:
                p.PlayerLocation += 3;
                break;
            case 2:
                p.PlayerLocation--;
                break;
            case 8:
                p.PlayerLocation -= 4;
                break;
            case 5:
                p.PlayerLocation -= 2;
                break;
        }

    }
    public void BackDirection(Player p)
    {
        switch (p.PlayerLocation)
        {

            case 1:
            case 3:
                p.PlayerLocation--;
                break;
            case 4:
                p.PlayerLocation -= 3;
                break;
            case 7:
                p.PlayerLocation -= 4;
                break;
        }

    }
    public void PauseButton()
    {
        SceneManager.LoadScene(0);
    }

    
}
