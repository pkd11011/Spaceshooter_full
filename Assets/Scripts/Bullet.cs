using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed; // Tốc độ bay của đạn

    void Update()
    {
        // Tính toán vị trí mới dựa trên tốc độ và thời gian
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
    }
}