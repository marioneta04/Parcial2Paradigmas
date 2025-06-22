using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public float speedMultiplier = 1.5f;
    public float duration = 5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement player = other.GetComponent<PlayerMovement>();
            if (player != null)
            {
                player.ActivateSpeedBoost(speedMultiplier);
            }

            Destroy(gameObject);
        }
    }
}
