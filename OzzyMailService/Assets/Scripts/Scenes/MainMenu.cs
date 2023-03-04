using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using OzzyMailService.Data;

namespace OzzyMailService.Scenes
{
    public class MainMenu : MonoBehaviour
    {
        public void StartStoryMode()
        {
            SceneManager.LoadScene(Progress.Instance.PlayerInfo.Level + 1);
        }
    }

}
