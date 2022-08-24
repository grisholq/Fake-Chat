using UnityEngine;
using System.Collections.Generic;

public static class PlayerPrefsUtility
{
    public static void SaveAllData()
    {
        PlayerPrefs.Save();
    }

    public static void SaveInt(string key, int value)
    {
        PlayerPrefs.SetInt(key, value);
    }
    
    public static void SaveBool(string key, bool value)
    {
        PlayerPrefs.SetInt(key, value?1:0);
    }
    
    public static void SaveString(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
    }

    public static void SaveListInt(string amountKey, string elementKey, List<int> list)
    {
        SaveInt(amountKey, list.Count);

        for (int i = 0; i < list.Count; i++)
        {
            SaveInt(elementKey + i.ToString(), list[i]);
        }
    }

    public static int LoadInt(string key, int defaultValue)
    {
        if (PlayerPrefs.HasKey(key) == false)
        {
            PlayerPrefs.SetInt(key, defaultValue);
            return defaultValue;
        }

        return PlayerPrefs.GetInt(key);
    }

    public static string LoadString(string key, string defaultValue)
    {
        if (PlayerPrefs.HasKey(key) == false)
        {
            PlayerPrefs.SetString(key, defaultValue);
            return defaultValue;
        }

        return PlayerPrefs.GetString(key);
    }

    public static bool LoadBool(string key, bool defaultValue)
    {
        if (PlayerPrefs.HasKey(key) == false)
        {
            PlayerPrefs.SetInt(key, defaultValue ? 1:0);
            return defaultValue;
        }

        return PlayerPrefs.GetInt(key) == 1;
    }

    public static List<int> LoadListInt(string amountKey, string elementKey, List<int> defaultList)
    {
        if (PlayerPrefs.HasKey(amountKey))
        {
            int amount = LoadInt(amountKey, defaultList.Count);

            List<int> list = new List<int>(amount);

            for (int i = 0; i < list.Count; i++)
            {
                list.Add(LoadInt(elementKey + i.ToString(), 0));
            }

            return list;
        }

        return defaultList;
    }
}
