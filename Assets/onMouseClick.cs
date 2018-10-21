using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class onMouseClick : MonoBehaviour {
    public Text hint;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnMouseDown (){
        hint.text = "Current Quest: I love working out";
        Destroy(gameObject);
     }
}
