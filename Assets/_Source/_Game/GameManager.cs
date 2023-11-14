using System.Collections.Generic;
using _Source._Core;
using UnityEngine;

namespace _Source._Game
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] 
        private List<GameObject> _list = new();
        private ResourceBank _resourceBank;
        
        public void Awake()
        {
            _resourceBank = new ResourceBank();
            
            _resourceBank.ChangeResource(GameResource.Humans, 0);
            _resourceBank.ChangeResource(GameResource.Food, 0);
            _resourceBank.ChangeResource(GameResource.Wood, 0);
            _resourceBank.ChangeResource(GameResource.Stone, 0);
            _resourceBank.ChangeResource(GameResource.Gold, 0);

            foreach (var gameObj in _list)
            {
                if (gameObj.TryGetComponent(out ResourceVisual resourceVisual))
                {
                    resourceVisual.Init(_resourceBank);
                }
            }
            
            _resourceBank.ChangeResource(GameResource.Humans, 10);
            _resourceBank.ChangeResource(GameResource.Food, 5);
            _resourceBank.ChangeResource(GameResource.Wood, 5);
        }
    }
}