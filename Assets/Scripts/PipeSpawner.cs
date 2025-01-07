using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;  // Đường ống mẫu
    public float spawnInterval = 2f;  // Khoảng thời gian giữa các lần spawn
    public float heightOffset = 1.7f;  // Độ lệch chiều cao của đường ống
    private Vector3 pipeSpawnPoint; // Điểm spawn đường ống

    void Start()
    {
        pipeSpawnPoint = transform.position;
        InvokeRepeating("SpawnPipe", 1.7f, spawnInterval);
    }

    void SpawnPipe()
    {
        // GameObject pipe = pipePool.GetObject();
        float randomHeight = Random.Range(-heightOffset, heightOffset);
        Vector3 spawnPosition = new Vector3(pipeSpawnPoint.x, randomHeight, 0);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);
        // pipe.GetComponent<Transform>().position = spawnPosition;
    }
}
