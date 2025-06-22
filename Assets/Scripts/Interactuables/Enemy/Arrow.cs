using UnityEngine;

// Hereda de la clase abstracta Projectile y define su comportamiento concreto.
// Aplica herencia, polimorfismo y lógica condicional.
public class Arrow : Projectile //(Herencia)
{
    // Implementación del método abstracto Move() definido en la clase Projectile. (Polimorfismo)
    protected override void Move()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    // Llama al comportamiento base, que destruye la flecha. (Polimorfismo)
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            Debug.Log("El jugador fue alcanzado por una flecha");
            
        }
        // Llama al método base que destruye la flecha en cualquier caso.
        base.OnTriggerEnter2D(other);
    }
}
