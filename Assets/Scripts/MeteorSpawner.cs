using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    [SerializeField] float spawnRate = 6f;
    [SerializeField] GameObject meteorPrefab;


    float xMin;
    float ySpawn;
    float xMax;

    // Start is called before the first frame update
    void Start()
    {
        xMin = Camera.main.ViewportToWorldPoint(new Vector3(.1f, 0, 0)).x;
        xMax = Camera.main.ViewportToWorldPoint(new Vector3(.9f, 0, 0)).x;
        ySpawn = Camera.main.ViewportToWorldPoint(new Vector3(0, 1.25f, 0)).y;

        InvokeRepeating("SpawnMeteor", 0, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnMeteor()
    {
        float randx = Random.Range(xMin, xMax);
        Instantiate(meteorPrefab, new Vector3(randx, ySpawn, 0), Quaternion.identity);
    }
}
