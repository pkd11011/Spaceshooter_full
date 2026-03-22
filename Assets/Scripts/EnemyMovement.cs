using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 2f; // Tốc độ di chuyển của kẻ địch

    void Update()
    {
        // Di chuyển kẻ địch xuống dưới theo trục Y
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        // Tự xóa kẻ địch nếu bay quá thấp để tránh làm nặng máy
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}