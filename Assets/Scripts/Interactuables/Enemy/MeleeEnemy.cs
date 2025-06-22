using UnityEngine;
// Clase MeleeEnemy que representa un enemigo que persigue al jugador y lo ataca cuerpo a cuerpo.
// Hereda de Enemy y aplica herencia, polimorfismo, lógica condicional y comportamiento dinámico.
public class MeleeEnemy : Enemy
{
    private Transform player;
    public float speed = 2f;

    private void Start()
    {
        player = GameObject.FindWithTag("Player")?.transform;
    }

    private void Update()
    {
        if (player != null)
        {
            Vector2 direction = player.position - transform.position;
            transform.position += (Vector3)direction.normalized * speed * Time.deltaTime;
        }
    }
    // Implementación del método Interact heredado de TempleObject.
    // Aplica polimorfismo: el comportamiento de la interacción es específico del tipo de enemigo.
    public override void Interact()
    {
        Debug.Log("Te ataca cuerpo a cuerpo.");
        
    }
}
