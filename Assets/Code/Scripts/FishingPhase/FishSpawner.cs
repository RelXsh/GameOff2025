using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public FishData[] availableFish;
    public GameObject fishPrefab;

    public float spawnInterval = 2f;
    public Vector2 spawnYRange = new(-2f, 2f);
    public float spawnX = 10f; // distance from center (both sides)

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            SpawnFish();
        }
    }

    void SpawnFish()
    {
        FishData data = availableFish[Random.Range(0, availableFish.Length)];

        // Decide direction: left→right or right→left
        bool goRight = Random.value > 0.5f;
        float xPos = goRight ? -spawnX : spawnX;
        float yPos = Random.Range(spawnYRange.x, spawnYRange.y);

        GameObject fishObj = Instantiate(fishPrefab, new Vector3(xPos, yPos, 0f), Quaternion.identity, transform);

        // Pass data + direction
        FishBehaviour behaviour = fishObj.GetComponent<FishBehaviour>();
        behaviour.Initialize(data, goRight);
    }
}
