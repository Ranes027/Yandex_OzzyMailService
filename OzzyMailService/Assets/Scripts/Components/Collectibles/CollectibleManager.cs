using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using OzzyMailService.Data;

namespace OzzyMailService.Components.Collectibles
{
    public class CollectibleManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _valueText;

        public int NumberOfCollectibles;

        private void Start()
        {
            NumberOfCollectibles = Progress.Instance.PlayerInfo.Collectibles;
            _valueText.text = NumberOfCollectibles.ToString();
            transform.parent = null;
        }

        public void AddOne()
        {
            NumberOfCollectibles++;
            _valueText.text = NumberOfCollectibles.ToString();
        }

        public void SaveToProgress()
        {
            Progress.Instance.PlayerInfo.Collectibles = NumberOfCollectibles;
        }

        public void SpendCollectibles(int value)
        {
            NumberOfCollectibles -= value;
            _valueText.text = NumberOfCollectibles.ToString();
        }
    }
}

