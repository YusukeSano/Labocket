using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour{
    private void Start() {
        var scrollView = GameObject.Find("Scroll View");

        var viewPort = scrollView.transform.Find("Viewport");
        Transform content = viewPort.transform.Find("Content");

        
    }
}
