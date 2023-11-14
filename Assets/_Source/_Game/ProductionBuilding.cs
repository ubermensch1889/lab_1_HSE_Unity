using UnityEngine;

namespace _Source._Game
{
    public class ProductionBuilding : MonoBehaviour
    {
        [SerializeField] 
        private GameManager _gameManager;
        
        [SerializeField]
        private ProductionTime _productionTime;
        
        public void AddResource(ResourceVisual resourceVisual)
        {
            StartCoroutine(_productionTime.Coroutine(resourceVisual.GameResource, _gameManager.ResourceBank));
        }
    }
}