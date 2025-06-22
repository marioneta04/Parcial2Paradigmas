using UnityEngine;
// Interfaz que define un comportamiento com�n para todos los objetos interactuables.
// Aplica el principio de abstracci�n y polimorfismo.
// Cualquier objeto (puerta, cofre, trampa, etc.) que implemente esta interfaz debe definir su propia versi�n del m�todo Interact().
public interface IInteractable
{
    // M�todo que ser� implementado por cualquier clase que permita interacci�n con el jugador.
    void Interact();
}
