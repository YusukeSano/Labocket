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
                for(int i = 0; i < 10 ; i++){
                    //btb.materials[2].color = Color.red;
                    StartCoroutine(DilayMethod(0.5f , () =>
                    {
                        //rbga, r:0->1, g:1->0
                        btb.materials[2].color = new Color(0.1f * (i+1), 0.0f, 1.0f - 0.1f * (i+1), 1.0f);
                    }));
                }
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
                //btb.materials[2].color = Color.blue;
                for(int i = 0; i < 10; i++){
                    StartCoroutine(DilayMethod(0.5f , () =>
                    {
                        //rbga, r:0->1, b:1->0
                        btb.materials[2].color = new Color(0.0f, 0.1f * (i+1), 1.0f - 0.1f * (i+1), 1.0f);
                    }));
                }
            }
            else if (collision.gameObject.name == "HCL")
            {
                //だめ
            }
        }
    }
}
