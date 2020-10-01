using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using System.Threading.Tasks;

public class HitObject : MonoBehaviour
{
    public MeshRenderer btb;
    public GameObject beaker;
    private VideoPlayer cutin;
    private bool playing = false;

    void Start()
    {
        //beaker.SetActive(false);
        beaker.transform.localScale = Vector3.zero;
        cutin = beaker.GetComponent<VideoPlayer>();
    }

    float delta = 0;
    void Update()
    {
        if(playing == true)
        {
            delta += Time.deltaTime;
            if ((cutin.isPlaying == false) & (delta > 2))
            {
                delta = 0;
                playing = false;
                beaker.transform.localScale = Vector3.zero;
                //beaker.SetActive(false);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (this.name == "HCL")
        {
            if (collision.gameObject.name == "BTB")
            {
                if (playing == false)
                {
                    playing = true;
                    //beaker.SetActive(true);
                    beaker.transform.localScale = new Vector3(350, 350, 1);
                    cutin.Play();
                }

                //btb.materials[2].color = Color.red;
                for (int i = 0; i < 10; i++)
                {
                    Task.Delay(500);
                    //rbga, r:0->1, g:1->0
                    btb.materials[2].color = new Color(0.1f * (i + 1), 0.0f, 1.0f - 0.1f * (i + 1), 1.0f);
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
                if (playing == false)
                {
                    playing = true;
                    //beaker.SetActive(true);
                    beaker.transform.localScale = new Vector3(350, 350, 1);
                    cutin.Play();
                }

                //btb.materials[2].color = Color.blue;
                for (int i = 0; i < 10; i++)
                {
                    Task.Delay(500);
                    //rbga, r:0->1, b:1->0
                    btb.materials[2].color = new Color(0.0f, 0.1f * (i + 1), 1.0f - 0.1f * (i + 1), 1.0f);
                }
            }
            else if (collision.gameObject.name == "HCL")
            {
                //だめ
            }
        }
    }
}