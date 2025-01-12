using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;  // Đường ống mẫu
    public float spawnInterval = 1.5f;  // Khoảng thời gian giữa các lần spawn
    public float heightOffset = 1.7f;  // Độ lệch chiều cao của đường ống
    public Transform pipeSpawnPoint; // Điểm spawn đường ống

    public void Spawner()
    {
        InvokeRepeating("SpawnPipe", 1.5f, spawnInterval);
    }

    void SpawnPipe()
    {
        // GameObject pipe = pipePool.GetObject();
        float randomHeight = Random.Range(-heightOffset, heightOffset);
        Vector3 spawnPosition = new Vector3(pipeSpawnPoint.position.x, randomHeight, 0);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
        // pipe.GetComponent<Transform>().position = spawnPosition;
    }
}
