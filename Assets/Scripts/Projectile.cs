using UnityEngine;
// Clase abstracta base para todos los proyectiles (flechas, fireballs, etc).
// Aplica el principio de abstracci�n: define el comportamiento com�n sin implementar detalles espec�ficos.
// Hereda de MonoBehaviour para poder usarse como componente en Unity.
public abstract class Projectile : MonoBehaviour
{
    // Velocidad del proyectil, encapsulada como campo protegido para que las subclases puedan acceder. (Encapsulamiento)
    [SerializeField] protected float speed = 5f;

    //Es abstracto y ser� implementado por cada tipo espec�fico de proyectil.
    protected virtual void Update()
    {
        Move();
    }

    // M�todo abstracto que obliga a las subclases a definir c�mo se mueve el proyectil,
    // aplicando polimorfismo.
    protected abstract void Move();

    // M�todo que se ejecuta al colisionar con otro collider.
    // Destruye el proyectil para evitar que quede en la escena.
    // Se puede sobrescribir en subclases para l�gica personalizada.
    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        
        Destroy(gameObject);
    }
}
