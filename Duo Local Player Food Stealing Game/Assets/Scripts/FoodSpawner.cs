using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject Food;

    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;

    private Vector3 SpawnPosition;

    private void Start()
    {
        SpawnPosition = new Vector3(Random.Range(minX, maxX), 1.5f, Random.Range(minZ, maxZ));
        Instantiate(Food, SpawnPosition, Quaternion.identity);
        Debug.Log(SpawnPosition);
    }

    private void Update()
    {
        //Instantiate Food At Random Positions
    }
}
