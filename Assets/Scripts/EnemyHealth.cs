using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject explosionPrefab; // Ô để kéo hiệu ứng nổ vào

    // Hàm này chạy khi có đối tượng (đạn) chạm vào Trigger của kẻ địch
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    private void Die()
    {
        // Tạo hiệu ứng nổ tại vị trí kẻ địch
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, transform.rotation);
        }
        Destroy(gameObject); // Xóa kẻ địch khỏi màn hình
    }
}