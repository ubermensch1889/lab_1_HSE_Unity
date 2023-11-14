using System;
using _Source._Core;
using TMPro;
using UnityEngine;

namespace _Source._Game
{
    public class ResourceVisual : MonoBehaviour
    {
        [SerializeField]
        private GameResource _gameResource;
        
        [SerializeField] 
        private TextMeshProUGUI _text;
        
        public GameResource GameResource => _gameResource;

        public void Init(ResourceBank resourceBank)
        {
            resourceBank.GetResource(_gameResource).OnChanged += UpdateValue;
        }
        
        private void UpdateValue(int value)
        {
            _text.text = value.ToString();
        }
    }
}