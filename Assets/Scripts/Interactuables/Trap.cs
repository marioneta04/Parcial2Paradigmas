using UnityEngine;
using System.Collections;

// Clase Trap (Trampa) que hereda de TempleObject e implementa el método Interact().
// Dispara una serie de flechas hacia una dirección cuando el jugador entra en su zona.
// Aplica herencia, polimorfismo, lógica condicional e instanciación dinámica.
public class Trap : TempleObject //Herencia
{
    public GameObject arrowTrapPrefab;
    public float fireInterval = 1f;
    public int arrowCount = 3;
    public Vector2 shootDirection = Vector2.down;

    private bool isActivated = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isActivated && other.CompareTag("Player"))
        {
            Interact();
        }
    }
    // Implementación del método abstracto heredado de TempleObject.
    // Se asegura de no activarse más de una vez. (Polimorfismo)
    public override void Interact()
    {
        if (isActivated) return;

        isActivated = true;
        StartCoroutine(FireArrows());
    }

    private IEnumerator FireArrows()
    {
        for (int i = 0; i < arrowCount; i++)
        {
            GameObject arrow = Instantiate(arrowTrapPrefab, transform.position, Quaternion.identity);
            arrow.transform.up = shootDirection;
            yield return new WaitForSeconds(fireInterval);
        }
    }
}
