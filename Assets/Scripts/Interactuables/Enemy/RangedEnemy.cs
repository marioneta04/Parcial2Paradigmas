using UnityEngine;
// Clase RangedEnemy que representa un enemigo que dispara flechas al jugador.
// Hereda de Enemy y aplica herencia, polimorfismo, l�gica condicional e instanciaci�n din�mica.
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
        Debug.Log("�Dispara una flecha!");
        Instantiate(arrowPrefab, transform.position, Quaternion.identity);
    }
    // Implementaci�n del m�todo Interact heredado de TempleObject.
    // Muestra un mensaje indicando detecci�n del jugador. (Polimorfismo)
    public override void Interact()
    {
        Debug.Log("Enemigo a distancia te detect�.");
    }
}
