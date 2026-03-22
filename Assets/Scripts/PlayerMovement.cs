using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        // Kiểm tra nếu đang đè chuột trái
        if (Input.GetMouseButton(0))
        {
            // 1. Lấy vị trí chuột (tọa độ Pixel màn hình)
            Vector3 mousePos = Input.mousePosition;
            Debug.Log("1. Chuột đang ở Pixel: " + mousePos);

            // 2. Chuyển sang tọa độ Game (World Point)
            if (Camera.main != null)
            {
                Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

                // 3. Ép Z về 0 (Rất quan trọng)
                worldPos.z = 0;
                Debug.Log("2. Tọa độ Game tính được: " + worldPos);

                // 4. Gán vị trí cho tàu
                transform.position = worldPos;
                Debug.Log("3. Đã gán vị trí tàu xong!");
            }
            else
            {
                Debug.LogError("LỖI: Không tìm thấy Camera có Tag là MainCamera!");
            }
        }
    }
}