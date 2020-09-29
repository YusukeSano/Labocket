using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="LabDB", menuName ="CreateLabDB")]
public class LabDB : ScriptableObject {

    [SerializeField]
    private List<Lab> LabLists = new List<Lab>();

    public List<Lab> GetLabLists() {
        return LabLists;
    }
}