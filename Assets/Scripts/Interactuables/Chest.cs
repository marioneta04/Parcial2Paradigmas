using UnityEngine;

// Clase Chest (Cofre) que hereda de TempleObject.
// Representa un objeto interactuable que suelta un power-up al ser activado.
// Aplica herencia, polimorfismo, encapsulamiento y lógica condicional.
public class Chest : TempleObject
{
    // Campo privado que controla si el cofre ya fue abierto.
    // Está encapsulado con una propiedad pública de solo lectura.
    [SerializeField] private bool isOpened = false;

    // Propiedad pública que permite leer el estado del cofre desde otros scripts,
    // pero evita que se modifique desde afuera (encapsulamiento).
    public bool IsOpened
    {
        get { return isOpened; }
        private set { isOpened = value; } 
    }
    // Prefab del power-up que se va a instanciar cuando se abra el cofre.
    public GameObject powerUpPrefab;

    // Detecta al jugador usando un trigger. Si el cofre no está abierto, llama a Interact().
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!IsOpened && other.CompareTag("Player"))
        {
            Interact();
        }
    }

    // Implementación del método abstracto heredado de TempleObject.
    // Aplica lógica condicional: solo permite abrir el cofre si aún no fue abierto.
    // Polimorfismo
    public override void Interact()
    {
        if (!IsOpened)
        {
            OpenChest();
        }
    }

    // Método que cambia el estado del cofre a abierto e instancia el power-up.
    private void OpenChest()
    {
        IsOpened = true;
        Debug.Log("Cofre abierto, soltando power-up");
        Instantiate(powerUpPrefab, transform.position, Quaternion.identity);
    }
}
