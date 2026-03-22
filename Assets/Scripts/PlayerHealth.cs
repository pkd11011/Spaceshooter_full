using UnityEngine;

public class PlayerHealth : Health
{
    public GameObject gameOverCanvas; // [cite: 771]

    protected override void Die()
    {
        // Goi ham tao vu no tu lop cha (Health)
        base.Die(); // [cite: 768]

        // Hien bang Game Over bao gom ca Text va Button
        if (gameOverCanvas != null)
        {
            gameOverCanvas.SetActive(true); // [cite: 771]
        }
    } // Ket thuc ham Die
} // Ket thuc lop PlayerHealth - THIEU DAU NAY SE BI LOI CS1513