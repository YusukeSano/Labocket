using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Atom", menuName = "CreateAtom")]
public class Atom: ScriptableObject {

    public enum state {
        固体,液体,気体
    }

    [SerializeField]
    private string JPName;
    [SerializeField]
    private string USName;
    [SerializeField]
    private string Symbol;
    [SerializeField]
    private string Num;
    [SerializeField]
    private state State;
    [SerializeField]
    private string Description;
    [SerializeField]
    private string Purpose;
    [SerializeField]
    private string Connection;

    public string GetAJPName() {
        return JPName;
    }
    public string GetAUSName() {
        return USName;
    }
    public string GetASymbol() {
        return Symbol;
    }
    public string GetANum() {
        return Num;
    }
    public string GetAState() {
        return State.ToString();
    }
    public string GetADescription() {
        return Description;
    }
    public string GetAPurpose() {
        return Purpose;
    }
    public string GetAConnection() {
        return Connection;
    }

    
    
}
