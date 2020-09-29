using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AqueousControl : MonoBehaviour
{
    public MeshRenderer alkali;
    public MeshRenderer middle;
    public MeshRenderer acid;

    void Start()
    {
        alkali.materials[1].color = Color.blue;
        middle.materials[1].color = Color.green;
        middle.materials[2].color = Color.green;
        acid.materials[1].color = Color.red;
    }
}
