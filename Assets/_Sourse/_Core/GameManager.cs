using UnityEngine;

namespace _Core
{
    public class GameManager : MonoBehaviour
    {
        private ResourceBank _resourceBank;
        
        public ResourceBank ResourceBank => _resourceBank;
        void Awake()
        {
            _resourceBank = new ResourceBank();
            _resourceBank.ChangeResource(GemeResource.Humans, 10);
            _resourceBank.ChangeResource(GemeResource.Wood, 5);
            _resourceBank.ChangeResource(GemeResource.Food, 5);
        }
        
        
    }
}
