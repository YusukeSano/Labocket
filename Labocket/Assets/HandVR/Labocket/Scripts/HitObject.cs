using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObject : MonoBehaviour
{
    public bool hit = false;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Atom")
        {
            hit = true;
        }
    }
}