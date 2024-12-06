using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetroidSpawner : MonoBehaviour
{
    [Header("Spawning Parameters")]
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private Transform targetPosition;
    [SerializeField] private float minVelocity = 1.0f;
    [SerializeField] private float maxVelocity = 5.0f;
    [SerializeField] private float spawnDelay = 1.0f;

    private void Start()
    {
        // Start spawning at regular intervals
        StartCoroutine(SpawnMetroidRoutine());
    }

    private IEnumerator SpawnMetroidRoutine()
    {
        while (true)
        {
            SpawnMetroid();
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    private void SpawnMetroid()
    {
        // Pick a random spawn point
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        // Instantiate the prefab at the chosen spawn point
        GameObject newMetroid = Instantiate(prefab, spawnPoint.position, Quaternion.identity);

        // Apply velocity towards the target position
        if (targetPosition != null)
        {
            Rigidbody rb = newMetroid.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 direction = (targetPosition.position - spawnPoint.position).normalized;
                float velocity = Random.Range(minVelocity, maxVelocity);
                rb.velocity = direction * velocity;
            }
        }
    }
}
