using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveUtility
{
    static string gameDataPath = Application.dataPath + "/gamedata.json";
    static string playerDataPath = Application.dataPath + "/playerdata.json";
    static string opponentDataPath = Application.dataPath + "/opponentdata.json";

    public static void Save(ProfileData player, ProfileData opponent, GameUpdateData gameData)
    {
        SavePlayer(player);
        SaveOpponent(opponent);
        SaveGameData(gameData);
    }

    public static ProfileData LoadPlayer()
    {
        if(File.Exists(playerDataPath))
        {
            return (ProfileData)(JsonUtility.FromJson(File.ReadAllText(playerDataPath), typeof(ProfileData)));
        }
        ProfileData tmp = GlobalData.Instance.MockPlayerProfile.ProfileData;
        SavePlayer(tmp);
        return tmp;
    }

    public static void SavePlayer(ProfileData player)
    {
        File.WriteAllText(playerDataPath, JsonUtility.ToJson(player));
    }

    public static ProfileData LoadOpponent()
    {
        if (File.Exists(opponentDataPath))
        {
            return (ProfileData)(JsonUtility.FromJson(File.ReadAllText(opponentDataPath), typeof(ProfileData)));
        }
        ProfileData tmp = GlobalData.Instance.MockOpponentProfile.ProfileData;
        SaveOpponent(tmp);
        return tmp;
    }

    public static void SaveOpponent(ProfileData opponent)
    {
        File.WriteAllText(opponentDataPath, JsonUtility.ToJson(opponent));
    }

    public static GameUpdateData LoadGameData()
    {
        if (File.Exists(gameDataPath))
        {
            return (GameUpdateData)(JsonUtility.FromJson(File.ReadAllText(gameDataPath), typeof(GameUpdateData)));
        }
        GameUpdateData tmp = GlobalData.Instance.MockGameUpdateProfile.ProfileData;
        SaveGameData(tmp);
        return tmp;
    }

    public static void SaveGameData(GameUpdateData gamedata)
    {
        File.WriteAllText(gameDataPath, JsonUtility.ToJson(gamedata));
    }
}
