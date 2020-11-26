using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLoop : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public Transform SpawnPoint;
    public int Quantity;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            for(int i = 0; i < Quantity; i++)
            {
                GameObject g;
                g = Instantiate(ObjectToSpawn, SpawnPoint.position, Quaternion.identity);
            }

        }
    }
}
