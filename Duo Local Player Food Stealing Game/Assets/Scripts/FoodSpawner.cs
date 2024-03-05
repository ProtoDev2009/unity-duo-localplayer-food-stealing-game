using System.Collections;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject Food;
    private GameObject foodSpawned;

    public float instantiateDelay = 2f;
    public float destroyDelay = 3f;

    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    private Vector3 spawnPosition;

    private void Start()
    {
        StartCoroutine(SpawnAndDestroyFood());
    }

    private IEnumerator SpawnAndDestroyFood()
    {
        while (true)
        {
            yield return new WaitForSeconds(instantiateDelay);
            SpawnFood();
            yield return new WaitForSeconds(destroyDelay);
            DestroyFood();
        }
    }

    private void SpawnFood()
    {
        spawnPosition = new Vector3(Random.Range(minX, maxX), 1.5f, Random.Range(minZ, maxZ));
        foodSpawned = Instantiate(Food, spawnPosition, Quaternion.identity);
    }

    public void DestroyFood()
    {
        if (foodSpawned != null)
        {
            Destroy(foodSpawned);
            foodSpawned = null;
        }
    }
}
