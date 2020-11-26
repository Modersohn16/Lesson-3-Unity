using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public Transform SpawnPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            GameObject g;
            g = Instantiate(ObjectToSpawn, SpawnPoint.position, Quaternion.identity);
        }
    }
}
