using UnityEngine;
public class Blinking : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    void Start() { spriteRenderer = GetComponent<SpriteRenderer>(); } // Lấy thành phần vẽ [cite: 504]
    void Update() { spriteRenderer.enabled = !spriteRenderer.enabled; } // Bật/tắt liên tục [cite: 529]
}