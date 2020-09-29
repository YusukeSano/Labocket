using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AtomDB", menuName = "CreateAtomDB")]
public class AtomDB : ScriptableObject {

    [SerializeField]
    private List<Atom> AtomLists = new List<Atom>();

    public List<Atom> GetAtomLists() {
        return AtomLists;
    }
}