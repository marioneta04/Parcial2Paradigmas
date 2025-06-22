using NUnit.Framework;
using UnityEngine;

// Hereda de la clase abstracta Projectile y define su comportamiento espec�fico.
// Aplica herencia, polimorfismo y l�gica condicional.
public class ArrowTrap : Projectile //Herencia
{
    // Implementaci�n del m�todo Move() espec�fico para las trampas.
    // Mueve la flecha hacia abajo (eje Y negativo) de forma constante.
    // Polimorfismo
    protected override void Move()
    {
        
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    // Detecta colisiones con otros objetos.
    // Si el objeto colisionado es el jugador, muestra un mensaje en consola.
    // Luego llama al comportamiento base para destruir la flecha.
    // Polimorfismo
    protected override void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            Debug.Log("El jugador fue alcanzado por una flecha");

        }

        base.OnTriggerEnter2D(other);
    }
}
