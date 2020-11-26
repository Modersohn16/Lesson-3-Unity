using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vinna : MonoBehaviour
{
    public SpelHanteraren spelHanteraren;
    void OnTriggerEnter()
    {
        spelHanteraren.seger();
    }
}
