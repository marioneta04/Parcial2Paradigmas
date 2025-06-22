using UnityEngine;
// Clase abstracta base para todos los proyectiles (flechas, fireballs, etc).
// Aplica el principio de abstracción: define el comportamiento común sin implementar detalles específicos.
// Hereda de MonoBehaviour para poder usarse como componente en Unity.
public abstract class Projectile : MonoBehaviour
{
    // Velocidad del proyectil, encapsulada como campo protegido para que las subclases puedan acceder. (Encapsulamiento)
    [SerializeField] protected float speed = 5f;

    //Es abstracto y será implementado por cada tipo específico de proyectil.
    protected virtual void Update()
    {
        Move();
    }

    // Método abstracto que obliga a las subclases a definir cómo se mueve el proyectil,
    // aplicando polimorfismo.
    protected abstract void Move();

    // Método que se ejecuta al colisionar con otro collider.
    // Destruye el proyectil para evitar que quede en la escena.
    // Se puede sobrescribir en subclases para lógica personalizada.
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        
        Destroy(gameObject);
    }
}
