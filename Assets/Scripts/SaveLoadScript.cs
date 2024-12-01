using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class SaveLoadScript : MonoBehaviour, SaveInterface
{


    public void SaveGame(GameObject causer)
    {
        if (causer.GetComponent<GetInfoInterface>() != null)
        {
            causer.GetComponent<GetInfoInterface>().TryGetData(this);

            Debug.Log("saved");
        }
        else
        {
            Debug.Log("Cant save");
        }

    }

    public void LoadGame(GameObject causer)
    {
        if (File.Exists(Application.dataPath + "GameDataFile.json"))
        {

            string Json = File.ReadAllText(Application.dataPath + "GameDataFile.json");
            PlayerData data = JsonUtility.FromJson<PlayerData>(Json);

            if (causer.GetComponent<GetInfoInterface>() != null)
            {
                causer.GetComponent<GetInfoInterface>().LoadGame(data);
            }
        }


    }

    public void DeleteGame()
    {

        if (File.Exists(Application.dataPath + "GameDataFile.json"))
        {
            File.Delete(Application.dataPath + "GameDataFile.json");
        }
    }

    void SaveInterface.GiveData(PlayerData data, Vector2 playerPos)
    {
        Debug.Log("GameSaved");

        if (playerPos == new Vector2(0, 0))
        {


            string Json = JsonUtility.ToJson(data, true);
            File.WriteAllText(Application.dataPath + "GameDataFile.json", Json);
        }
        else
        {
            data.playerPos = playerPos;

            string Json = JsonUtility.ToJson(data, true);
            File.WriteAllText(Application.dataPath + "GameDataFile.json", Json);
        }

    }


}

