using UnityEngine;

// Kế thừa từ Health thay vì MonoBehaviour 
public class EnemyHealth : Health
{
    protected override void Die()
    {
        base.Die(); // chạy logic từ class cha
        Debug.Log("Enemy died");
    }
}