using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public static class SaveSystem 
{
    public static PlayerData LoadPlayerData()
    {
        string path = Application.persistentDataPath + "/player.txt";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Open);
            PlayerData data = formatter.Deserialize(fileStream) as PlayerData;

            fileStream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Player data not foun in " + path + "/nPlease check again");
            return null;
        }

    }
    public static void SavePlayerData(Player p)
    {
        BinaryFormatter formatter1 = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.txt";
        FileStream fileStream = new FileStream(path, FileMode.Create);

        PlayerData playerData = new PlayerData(p);

        formatter1.Serialize(fileStream, playerData);
        fileStream.Close();
    }
}
