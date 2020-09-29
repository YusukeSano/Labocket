using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
[CreateAssetMenu(fileName = "Lab", menuName ="CrateLab")]
public class Lab: ScriptableObject {
    public enum GradeOfLab {
        E3,E4,E5,E6,J1,J2,J3
    }

    //実験の学年
    [SerializeField]
    private GradeOfLab Grade;
    //実験の名前
    [SerializeField]
    private string LabName;
    //実験の説明
    [SerializeField]
    private string Info;

    public GradeOfLab GetGrade() {
        return Grade;
    }

    public string GetName() {
        return LabName;
    }

    public string GetInfo() {
        return Info;
    }


}
