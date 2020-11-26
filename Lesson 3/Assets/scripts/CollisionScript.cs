using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public Movement movement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Hinder")
        {
            Debug.Log("Du förlorar");
            movement.enabled = false;
            FindObjectOfType<SpelHanteraren>().gameOver();
        }
    }
}
