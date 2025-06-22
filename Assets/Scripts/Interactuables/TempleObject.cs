using UnityEngine;
// Clase abstracta que sirve como base para todos los objetos del templo que pueden ser interactuados.
// Aplica los principios de abstracci�n, herencia y polimorfismo.
// Hereda de MonoBehaviour para poder ser usada como componente en Unity.
// Tambi�n implementa la interfaz IInteractable, obligando a sus subclases a definir el m�todo Interact().
public abstract class TempleObject : MonoBehaviour, IInteractable
{
    // M�todo abstracto que debe ser implementado por todas las clases que hereden de TempleObject.
    // Representa la acci�n a realizar cuando el jugador interact�a con el objeto.
    public abstract void Interact();

    
   
}
