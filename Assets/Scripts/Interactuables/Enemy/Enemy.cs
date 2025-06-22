using UnityEngine;
// Clase abstracta Enemy que representa la base común para todos los enemigos del juego.
// Hereda de TempleObject para ser interactuable y reutiliza su estructura.
// Aplica herencia, abstracción, encapsulamiento, lógica condicional y polimorfismo.
public abstract class Enemy : TempleObject //Herencia
{
    // Vida del enemigo. Campo protegido para permitir acceso en subclases,
    // pero sin exponerlo directamente al exterior (encapsulamiento).
    [SerializeField] protected int health = 100;

    // Método virtual que permite que los enemigos reciban daño.
    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // Método virtual que maneja la muerte del enemigo.
    // Se puede sobrescribir en subclases para animaciones o efectos específicos.
    protected virtual void Die()
    {
        Debug.Log($"{gameObject.name} murió");
        Destroy(gameObject);
    }
}
