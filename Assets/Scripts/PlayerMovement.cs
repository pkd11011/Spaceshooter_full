using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float minX, maxX, minY, maxY;

    void Start()
    {
        // Lấy giới hạn màn hình theo Camera
        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));

        // Giới hạn theo kích thước sprite (để không bị lọt ra ngoài)
        float halfWidth = GetComponent<SpriteRenderer>().bounds.extents.x;
        float halfHeight = GetComponent<SpriteRenderer>().bounds.extents.y;

        minX = bottomLeft.x + halfWidth;
        maxX = topRight.x - halfWidth;
        minY = bottomLeft.y + halfHeight;
        maxY = topRight.y - halfHeight;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;

            // Chuyển sang world đúng chuẩn
            mousePos.z = -Camera.main.transform.position.z;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

            worldPos.z = 0;

            // Clamp theo màn hình
            float clampedX = Mathf.Clamp(worldPos.x, minX, maxX);
            float clampedY = Mathf.Clamp(worldPos.y, minY, maxY);

            transform.position = new Vector3(clampedX, clampedY, 0);
        }
    }
}