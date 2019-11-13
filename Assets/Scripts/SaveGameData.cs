using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class NewBehaviourScript
{
    
    public static void SavePlayerData (Player p)
    {
        BinaryFormatter formatter1 = new BinaryFormatter();
        string path = "D:/Users/admin/Desktop/Text Based Adventure Game IntroClass/Adventure Game/Data/player.txt";
        FileStream fileStream = new FileStream(path, FileMode.Create);

        PlayerData playerData = new PlayerData(p);

        formatter1.Serialize(fileStream, playerData);
        fileStream.Close();
    }
    public static PlayerData LoadPlayerData()
    {
        string path = "D:/Users/admin/Desktop/Text Based Adventure Game IntroClass/Adventure Game/Data/player.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formatter2 = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Open);
            PlayerData data = formatter2.Deserialize(fileStream) as PlayerData;

            fileStream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Player data not foun in " + path + "/nPlease check again");
            return null;
        }





    }



}
