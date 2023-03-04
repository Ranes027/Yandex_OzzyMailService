using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OzzyMailService.Components.Collectibles;
using OzzyMailService.Player;
using UnityEngine.SceneManagement;

namespace OzzyMailService.Data
{
    public class GameManager : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private GameObject _startMenu;
        [SerializeField] private GameObject _finishWindow;

        [SerializeField] private CollectibleManager _collectibleManager;

        public void StartGame()
        {
            _startMenu.SetActive(false);
            FindObjectOfType<PlayerBehaviour>().Play();

            Progress.Instance.Save();
        }

        public void ShowFinishWindow()
        {
            _finishWindow.SetActive(true);
        }

        public void NextLevel()
        {
            int nextLevel = SceneManager.GetActiveScene().buildIndex + 1;
            if (nextLevel < SceneManager.sceneCountInBuildSettings)
            {
                _collectibleManager.SaveToProgress();

                Progress.Instance.PlayerInfo.Level = SceneManager.GetActiveScene().buildIndex;

                Progress.Instance.Save();
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
}
