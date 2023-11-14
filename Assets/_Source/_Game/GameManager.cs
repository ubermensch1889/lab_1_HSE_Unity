using _Source._Core;
using UnityEngine;

namespace _Source._Game
{
    public class GameManager : MonoBehaviour
    {
        private ResourceBank _resourceBank;
        
        public void Awake()
        {
            _resourceBank = new ResourceBank();
            
            _resourceBank.ChangeResource(GameResource.Humans, 10);
            _resourceBank.ChangeResource(GameResource.Food, 5);
            _resourceBank.ChangeResource(GameResource.Wood, 5);
        }
    }
}