using UnityEngine;
// Interfaz que define un comportamiento común para todos los objetos interactuables.
// Aplica el principio de abstracción y polimorfismo.
// Cualquier objeto (puerta, cofre, trampa, etc.) que implemente esta interfaz debe definir su propia versión del método Interact().
public interface IInteractable
{
    // Método que será implementado por cualquier clase que permita interacción con el jugador.
    void Interact();
}
