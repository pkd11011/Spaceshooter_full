using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Kéo Prefab Enemy_01 vào đây
    public float spawnInterval = 2f; // Cứ 2 giây sinh ra 1 con
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0;
        }
    }

    void SpawnEnemy()
    {
        // Sinh ra kẻ địch tại vị trí ngẫu nhiên theo chiều ngang (trục X)
        float randomX = Random.Range(-2.5f, 2.5f);
        Vector3 spawnPos = new Vector3(randomX, 6f, 0f);
        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}