using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLabCard : MonoBehaviour{
    private GameObject content;
    private Image image;
    private Sprite sprite;
    private GameObject CardImage;
    private GameObject LabCard;
    private LabDB lab;
    

    private void Start() {
        content = GameObject.Find("Content");
        LabCard = GameObject.Find("LabCard");
        CardImage = GameObject.Find("CardImage");

        Debug.Log(Menubutton.LG);
        sprite = Resources.Load<Sprite>("Image/Card-" + Menubutton.LG);
        image = CardImage.GetComponent<Image>();
        image.sprite = sprite;
        lab = Resources.Load<LabDB>("Lab/Lab" + Menubutton.LG);
        List<Lab> LabLists = lab.GetLabLists();
        int sz = LabLists.Count;
        Debug.Log(sz);

        for(int i = 0; i < sz; i++) {
            GameObject card = Instantiate(LabCard, content.transform);
            string cardname = "LabCard" + i;
            card.name = cardname;
            Text LabName = GameObject.Find(cardname + "Name").GetComponent<Text>();

            LabName.text = LabLists[i].GetName();
        }
        Destroy(LabCard);
        
        
    }
}
