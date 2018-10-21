using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class togglePopup : MonoBehaviour {

    public Button ButtonPrize;
    public bool buttonClicked;
    public Button btn;
    public Canvas PopupCanvas;
    public Canvas popup;
    public GameObject iobj;

	// Use this for initialization
	void Start () {
        Button btn = ButtonPrize.GetComponent<Button>();
        buttonClicked = false;
        Canvas popup = PopupCanvas.GetComponent<Canvas>();
        btn.onClick.AddListener(Toggle);
    }
    void Toggle() {
        iobj.SetActive(true);
        buttonClicked = !buttonClicked;
        popup.enabled = !(popup.enabled);
    }
	// Update is called once per frame
    void Update () {
        
    }
   
}
