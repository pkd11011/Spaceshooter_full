using UnityEngine;

public class PlayerHealth : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Player died"); // Thông báo người chơi chết [cite: 196]
    }
}