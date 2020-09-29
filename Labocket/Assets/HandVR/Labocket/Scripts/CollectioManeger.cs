using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectioManeger : MonoBehaviour{
    [SerializeField] GameObject detailPanel;

    private void Start() {
        detailPanel = GameObject.Find("detailPanel");
        OffDetail();
    }
    public void OffDetail() {
        detailPanel.SetActive(false);
    }
    public void OnDetail() {
        detailPanel.SetActive(true);
    }
    
}
