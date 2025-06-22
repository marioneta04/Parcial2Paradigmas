using UnityEngine;
// Clase MeleeEnemy que representa un enemigo que persigue al jugador y lo ataca cuerpo a cuerpo.
// Hereda de Enemy y aplica herencia, polimorfismo, l�gica condicional y comportamiento din�mico.
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
    // Implementaci�n del m�todo Interact heredado de TempleObject.
    // Aplica polimorfismo: el comportamiento de la interacci�n es espec�fico del tipo de enemigo.
    public override void Interact()
    {
        Debug.Log("Te ataca cuerpo a cuerpo.");
        
    }
}
