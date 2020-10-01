using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class Menubutton : MonoBehaviour{
    void Start()
    {
        XRSettings.enabled = false;
    }

    public void ToTitle(){
        SceneManager.LoadScene("Title");
    }

    public void ToMenu(){
        SceneManager.LoadScene("Menu");
    }
    public void ToAtom(){
        SceneManager.LoadScene("AtomMenu");
    }

    public void ToGrade() {
        SceneManager.LoadScene("GradeMenu");
    }

    public void ToLab() {
        SceneManager.LoadScene("LabMenu");
        //Debug.Log("Lab!!");
    }

    public void ToCollection() {
        SceneManager.LoadScene("AtomCollection");
    }

    public void AtomVR() {
        //SceneManager.LoadScene("");
        Debug.Log("VRで見れるよ！！！");
    }


    //同一シーンに遷移するが変数として学年に相当するものを渡す。
    public static string LG = "NO";
    public void GradeButton() {
        switch (transform.name) {
            case "E3":
                LG = "E3";
                break;
            case "E4":
                LG = "E4";
                break;
            case "E5":
                LG = "E5";
                break;
            case "E6":
                LG = "E6";
                break;
            case "J1":
                LG = "J1";
                break;
            case "J2":
                LG = "J2";
                break;
            case "J3":
                LG = "J3";
                break;
            case "tutorial":
                LG = "tutorial";
                XRSettings.enabled = true;
                SceneManager.LoadScene("Main");
                break;
        }
        if (LG != "tutorial")
        {
            SceneManager.LoadScene("LabMenu");
        }
    }

    
}

