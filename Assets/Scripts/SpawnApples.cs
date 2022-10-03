using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnApples : MonoBehaviour
{
    // public GameObject[] apples;
    public float spawnDelay = 1.0F;
    public float spawnRate = 1.0F;

    public GameObject apple;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnRate);
    }

    void Spawn()
    {
        // int appleIndex = Random.Range(0, apples.Length);
        Vector3 pos = GameObject.Find("tree").transform.position;

        Instantiate(apple, new Vector3(pos.x + 0.6F, pos.y - 0.4F, pos.z), Quaternion.identity);
    }
}
