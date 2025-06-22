using UnityEngine;
// Clase abstracta que sirve como base para todos los objetos del templo que pueden ser interactuados.
// Aplica los principios de abstracción, herencia y polimorfismo.
// Hereda de MonoBehaviour para poder ser usada como componente en Unity.
// También implementa la interfaz IInteractable, obligando a sus subclases a definir el método Interact().
public abstract class TempleObject : MonoBehaviour, IInteractable
{
    // Método abstracto que debe ser implementado por todas las clases que hereden de TempleObject.
    // Representa la acción a realizar cuando el jugador interactúa con el objeto.
    public abstract void Interact();

    
   
}
