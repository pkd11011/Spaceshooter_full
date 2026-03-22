using UnityEngine;
public class ShowLog : MonoBehaviour
{
    void Start() { Debug.Log("Hello World!"); } // Chạy 1 lần [cite: 452, 454]
    void Update() { Debug.Log("Update gọi tại khung hình: " + Time.frameCount); } // Chạy liên tục [cite: 467, 469]
}