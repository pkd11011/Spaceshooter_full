using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public EnemyHealth health;
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra có đâm trúng player không
        var playerHealth = collision.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);

            // đảm bảo không null
            if (health != null)
            {
                health.TakeDamage(1000); // enemy tự nổ
            }
        }
    }
}