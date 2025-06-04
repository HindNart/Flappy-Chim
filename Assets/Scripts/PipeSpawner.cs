using System.Collections;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public ObjectPool pipePool;
    public float spawnInterval = 1.5f;  // Khoảng thời gian giữa các lần spawn
    public float heightOffset = 1.7f;  // Độ lệch chiều cao của đường ống
    public Transform pipeSpawnPoint; // Điểm spawn đường ống

    public void Spawner()
    {
        StartCoroutine(SpawnPipe());
    }

    private IEnumerator SpawnPipe()
    {
        while (true)
        {
            GameObject pipe = pipePool.GetObject();
            float randomHeight = Random.Range(-heightOffset, heightOffset);
            Vector3 spawnPosition = new Vector3(pipeSpawnPoint.position.x, randomHeight, transform.position.z);
            pipe.transform.SetPositionAndRotation(spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
