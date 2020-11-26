using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset = new Vector3(0.0f, 5.0f, -10.0f);

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
