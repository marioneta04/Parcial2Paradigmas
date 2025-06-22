using UnityEngine;
// Clase abstracta Enemy que representa la base com�n para todos los enemigos del juego.
// Hereda de TempleObject para ser interactuable y reutiliza su estructura.
// Aplica herencia, abstracci�n, encapsulamiento, l�gica condicional y polimorfismo.
public abstract class Enemy : TempleObject //Herencia
{
    // Vida del enemigo. Campo protegido para permitir acceso en subclases,
    // pero sin exponerlo directamente al exterior (encapsulamiento).
    [SerializeField] protected int health = 100;

    // M�todo virtual que permite que los enemigos reciban da�o.
    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // M�todo virtual que maneja la muerte del enemigo.
    // Se puede sobrescribir en subclases para animaciones o efectos espec�ficos.
    protected virtual void Die()
    {
        Debug.Log($"{gameObject.name} muri�");
        Destroy(gameObject);
    }
}
