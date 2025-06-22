using UnityEngine;
// Clase RangedEnemy que representa un enemigo que dispara flechas al jugador.
// Hereda de Enemy y aplica herencia, polimorfismo, lógica condicional e instanciación dinámica.
public class RangedEnemy : Enemy //Herencia
{
    public GameObject arrowPrefab;
    public float shootCooldown = 2f;
    public float shootRange = 5f;
    private Transform player;
    private float lastShootTime;

    private void Start()
    {
        player = GameObject.FindWithTag("Player")?.transform;
    }

    private void Update()
    {
        if (player == null) return;

        float distance = Vector2.Distance(transform.position, player.position);

        if (distance <= shootRange && Time.time > lastShootTime + shootCooldown)
        {
            Shoot();
            lastShootTime = Time.time;
        }
    }

    private void Shoot()
    {
        Debug.Log("¡Dispara una flecha!");
        Instantiate(arrowPrefab, transform.position, Quaternion.identity);
    }
    // Implementación del método Interact heredado de TempleObject.
    // Muestra un mensaje indicando detección del jugador. (Polimorfismo)
    public override void Interact()
    {
        Debug.Log("Enemigo a distancia te detectó.");
    }
}
