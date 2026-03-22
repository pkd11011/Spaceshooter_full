using UnityEngine;
using UnityEngine.SceneManagement; // Bắt buộc phải có dòng này

public class MainMenu : MonoBehaviour
{
    // Hàm dùng cho nút Play Game ở cảnh Menu
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }

    // Hàm dùng cho nút Return ở cảnh Game Over
    public void OnReturnButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }
}