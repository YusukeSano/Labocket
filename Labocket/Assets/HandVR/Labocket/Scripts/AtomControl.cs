using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtomControl : MonoBehaviour
{
    public Text log;

    public GameObject H;
    public GameObject O;

    GameObject[] atoms;
    GameObject[] temp;

    void Start()
    {
        log.text += "IN!\n";
        atoms = new GameObject[] {H, O};
        temp = new GameObject[] {};
        log.text += "CreateGameObject!\n";
        //for (int loop = 0; loop < 5; loop++)
        for (int loop = 0; loop < 1; loop++)
        {
            Vector3 position = new Vector3(1.0f, 0.25f, 1.0f);
            temp[loop] = Instantiate(atoms[0], position, Quaternion.identity);
            temp[loop].SetActive(true);
            //Vector3 position = new Vector3(Random.Range(-2.0f, 2.0f), 0.25f, Random.Range(-2.0f, 2.0f));
            //temp[loop] = Instantiate(atoms[Random.Range(0,2)], position, Quaternion.identity);
            //temp[loop].SetActive(true);
            log.text += loop + ":" + temp[loop].name + "\n";
        }
    }

    void Update()
    {
        int hitcnt = 0;
        for (int loop = 0; loop < 5; loop++)
        {
            if (atoms[loop].GetComponent<HitObject>().hit == true)
            {
                log.text += "Hit\n";
                hitcnt += 1;
                //if (hitcnt == 2)
                //{
                    
                //}
                Destroy(temp[loop]);
                //名前から生成する分子を選択
                //ランダムで１つ生成
                Vector3 position = new Vector3(Random.Range(-2.0f, 2.0f), 0.25f, Random.Range(-2.0f, 2.0f));
                temp[loop] = Instantiate(atoms[Random.Range(0, 2)], position, Quaternion.identity);
                temp[loop].SetActive(true);
            }
        }
    }
}
