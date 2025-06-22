using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractions : MonoBehaviour
{
    private IInteractable interactableNearby;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<IInteractable>(out IInteractable interactable))
        {
            interactableNearby = interactable;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent<IInteractable>(out IInteractable interactable) && interactable == interactableNearby)
        {
            interactableNearby = null;
        }
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed && interactableNearby != null)
        {
            interactableNearby.Interact();
        }
    }
}
