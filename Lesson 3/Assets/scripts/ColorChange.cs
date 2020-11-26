using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material PlayerMaterial;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            PlayerMaterial.SetColor("_Color", Color.red);
        }

        if (Input.GetKey("g"))
        {
            PlayerMaterial.SetColor("_Color", Color.green);
        }

        if (Input.GetKey("b"))
        {
            PlayerMaterial.SetColor("_Color", Color.blue);
        }

        if (Input.GetKey("v"))
        {
            PlayerMaterial.SetColor("_Color", Color.white);
        }
    }
}
