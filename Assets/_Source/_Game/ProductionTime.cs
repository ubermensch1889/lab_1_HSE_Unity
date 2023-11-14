using System;
using System.Collections;
using _Source._Core;
using UnityEngine;
using UnityEngine.UI;

namespace _Source._Game
{
    public class ProductionTime : MonoBehaviour
    {
        [SerializeField] 
        private Button _button;

        [SerializeField] 
        private Slider _slider;

        private readonly float disableTime = 5;

        public void Start()
        {
            _slider.enabled = false;
        }

        public IEnumerator Coroutine(GameResource gameResource, ResourceBank resourceBank)
        {
            _button.enabled = false;
            for (float timeLeft = disableTime; timeLeft > 0; timeLeft -= Time.deltaTime)
            {
                yield return null;
                _slider.value = (disableTime - timeLeft) / disableTime;
            } 
            resourceBank.ChangeResource(gameResource, 1);
            _button.enabled = true;
        }
    }
}