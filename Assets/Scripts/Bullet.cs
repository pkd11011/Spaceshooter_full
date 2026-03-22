using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed;
    public int damage;

    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
    }

    // Hàm xử lý va chạm khi đạn bay trúng mục tiêu
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kiểm tra xem đối tượng có EnemyHealth không
        var enemy = collision.GetComponent<EnemyHealth>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }

        Destroy(gameObject); // hủy đạn
    }
}