using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public Transform muzzlePoint;
    public float shootingInterval = 0.1f;
    private float lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        Instantiate(bulletPrefabs, muzzlePoint.position, muzzlePoint.rotation);
    }
}