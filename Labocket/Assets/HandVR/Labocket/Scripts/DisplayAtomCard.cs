using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class DisplayAtomCard : MonoBehaviour {
    private GameObject content;
    private GameObject AtomCard;
    private AtomDB atom;

    private void Start() {
        content = GameObject.Find("Content");
        AtomCard = GameObject.Find("AtomCard");
        atom = Resources.Load<AtomDB>("Atom/AtomDB");
        List<Atom> AtomLists = atom.GetAtomLists();
        int sz = AtomLists.Count;
        Debug.Log(sz);
        
        for(int i = 0; i < sz; i++) {
            GameObject card = Instantiate(AtomCard, content.transform);
            string cardname = "AtomCard" + i;
            card.name = cardname;

            Text JPName = GameObject.Find(cardname + "/JPName").GetComponent<Text>();
            Text USName = GameObject.Find(cardname + "/USName").GetComponent<Text>();
            Text Symbol = GameObject.Find(cardname + "/Symbol").GetComponent<Text>();
            Text Num = GameObject.Find(cardname + "/Num").GetComponent<Text>();
            Text State = GameObject.Find(cardname + "/State").GetComponent<Text>();

            JPName.text = AtomLists[i].GetAJPName();
            USName.text = AtomLists[i].GetAUSName();
            Symbol.text = AtomLists[i].GetASymbol();
            Num.text = AtomLists[i].GetANum();
            State.text = AtomLists[i].GetAState();
        }
        Destroy(AtomCard);
    }
}

/*
public class DisplayAtomCard : MonoBehaviour{
    private GameObject content;
    private GameObject AtomCard;
    private AtomDB atom;

    private void Start() {
        content = GameObject.Find("Content");
        AtomCard = (GameObject)Resources.Load("AtomCard");
        atom = Resources.Load<AtomDB>("Atom/AtomDB");
        Debug.Log(atom);
        List<Atom> AtomLists = atom.GetAtomLists();
        int sz = AtomLists.Count;
        Debug.Log(sz);

        for(int i = 0; i < sz; i++) {
            GameObject card = Instantiate(AtomCard, content.transform);
            string cardname = "AtomCard" + i;
            card.name = cardname;

            Text JPName = GameObject.Find(cardname + "/JPName").GetComponent<Text>();
            Text USName = GameObject.Find(cardname + "/USName").GetComponent<Text>();
            Text Symbol = GameObject.Find(cardname + "/Symbol").GetComponent<Text>();
            Text Num = GameObject.Find(cardname + "/Num").GetComponent<Text>();
            Text State = GameObject.Find(cardname + "/State").GetComponent<Text>();

            JPName.text = AtomLists[i].GetAJPName();
            USName.text = AtomLists[i].GetAUSName();
            Symbol.text = AtomLists[i].GetASymbol();
            Num.text = AtomLists[i].GetANum();
            State.text = AtomLists[i].GetAState();
            
            GameObject aa;
            GameObject detailPanel;
            detailPanel = GameObject.Find("detailPanel");
            

            //Debug.Log(AtomLists[i].GetAName());
        }
    }
}
*/