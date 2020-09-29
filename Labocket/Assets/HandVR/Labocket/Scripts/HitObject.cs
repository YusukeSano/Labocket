using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObject : MonoBehaviour
{
    public MeshRenderer btb;

    void OnCollisionEnter(Collision collision)
    {
        if (this.name == "HCL")
        {
            if (collision.gameObject.name == "BTB")
            {
                btb.materials[2].color = Color.red;
            }
            else if (collision.gameObject.name == "NAOH")
            {
                //だめ
            }
        }
        else if (this.name == "NAOH")
        {
            if (collision.gameObject.name == "BTB")
            {
                btb.materials[2].color = Color.blue;
            }
            else if (collision.gameObject.name == "HCL")
            {
                //だめ
            }
        }
    }
}