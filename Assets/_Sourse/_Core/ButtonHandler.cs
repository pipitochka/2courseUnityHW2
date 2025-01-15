using _Core;
using Mono.Cecil;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnButtonClick()
    {
        ResourceVisual resourceVisual = GetComponentInParent<ResourceVisual>();
        GemeResource resource = resourceVisual.GemeResource;
        GameManager gameManager = Object.FindAnyObjectByType<GameManager>();
        gameManager.ResourceBank.ChangeResource(resource, 1);
        Debug.Log("Button clicked!");
    }
}
