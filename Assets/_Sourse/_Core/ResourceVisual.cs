using TMPro;
using UnityEngine;

namespace _Core
{
    public class ResourceVisual : MonoBehaviour
    {
        [SerializeField] private GemeResource _resource;
        [SerializeField] private TextMeshProUGUI _text;
        private ResourceBank _resourceBank;

        public GemeResource GemeResource => _resource;
        public void Start()
        { 
            GameManager gameManager = Object.FindAnyObjectByType<GameManager>();
            _resourceBank = gameManager.ResourceBank;
            int amount = _resourceBank.GetResource(_resource); 
            _text.text = _resource.ToString() + "\n" + amount.ToString();
            Debug.Log($"Resourse {_resource} is: {amount}");
        }
        
        void Update()
        {
            int amount = _resourceBank.GetResource(_resource);
            _text.text = _resource.ToString() + "\n" + amount.ToString();
        }
    }
}
