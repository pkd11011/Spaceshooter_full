using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    public float delay = 1f; // Sau 1 giây sẽ xóa

    void Start()
    {
        // Lệnh tự xóa chính nó sau khoảng thời gian 'delay'
        Destroy(gameObject, delay);
    }
}