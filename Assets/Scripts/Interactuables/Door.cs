using UnityEngine;

// Clase Door (Puerta) que hereda de TempleObject.
// Representa una puerta que se abre autom�ticamente cuando el jugador entra en su zona.
// Aplica herencia, encapsulamiento, l�gica condicional e interacci�n sin tecla.
public class Door : TempleObject //Herencia
{
    //Encapsulamiento
    private Collider2D doorCollider;

    private void Start()
    {
        doorCollider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        if (doorCollider != null)
        {
            doorCollider.enabled = false;
            Debug.Log("La puerta se abri� autom�ticamente");
        }
    }

    // M�todo Interact() requerido por la clase base TempleObject.
    // No se utiliza en este caso porque la puerta se abre autom�ticamente,
    // pero se deja definido para cumplir con el contrato de la herencia. (polimorfismo)
    public override void Interact()
    {
        
    }
}
