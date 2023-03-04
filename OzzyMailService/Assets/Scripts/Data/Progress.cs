using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

[System.Serializable]
public class PlayerInfo
{
    public int Level;

    public int Collectibles;
    public int Width;
    public int Height;
}

namespace OzzyMailService.Data
{
    public class Progress : MonoBehaviour
    {
        public PlayerInfo PlayerInfo;

        public static Progress Instance;


        private void Awake()
        {
            if (Instance == null)
            {
                transform.parent = null;
                DontDestroyOnLoad(gameObject);

                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void Save()
        {
            string jsonString = JsonUtility.ToJson(PlayerInfo);
        }

        public void SetPlayerInfo(string value)
        {
            PlayerInfo = JsonUtility.FromJson<PlayerInfo>(value);
        }
    }
}

