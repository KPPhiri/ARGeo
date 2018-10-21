using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class updateGPSText : MonoBehaviour {
    //public Text coordinates;
    public Canvas PopupCanvas;
    public Canvas popup;
    Boolean wasPressed = false;
    Dictionary<int, Marker> notFound = new Dictionary<int, Marker>();
    Dictionary<int, Marker> found = new Dictionary<int, Marker>();    //Marker a = new Marker(33.778, -84.397, "NA");
    public GameObject obj;



    // Use this for initialization
    void Start () {
        obj.SetActive(false);

        notFound.Add(0, new Marker(33.77753, -84.39650, "Klaus"));
        notFound.Add(1, new Marker(33.77446, -84.39646, "Culc")); 
        notFound.Add(2, new Marker(33.77582, -84.40399, "CRC"));
        notFound.Add(3, new Marker(33.77408, -84.39881, "Student Center")); 

    }

    // Update is called once per frame
    void Update () {
        //float found = 
        //if(true) {
        //    obj.SetActive(false);
        //}
        double lat = Math.Round(location.Instance.latitude, 5);
        double longd = Math.Round(location.Instance.longitude, 5);

        Debug.Log("ROUNDDDDD" + " lat " + lat + " longd " + longd);
        Debug.Log("!!!!!!! " + " latitude " + location.Instance.latitude + " longitude " + location.Instance.longitude);


        //coordinates.text = "Lat:" + lat.ToString() + "      Lon:" + longd.ToString();
        foreach (var key in notFound.Keys) {
            if ((notFound[key].latitude + .00100 > lat) && (notFound[key].latitude - .00100 < lat) &&
               (notFound[key].longitude + .00100 > longd) && (notFound[key].longitude - .00100 < longd)) {
                makeAppear();
                Debug.Log("WE FOUND ITTT !! KEY: " +   key + " latitude " + lat + " longitude " + longd);

            }
        }
        //Debug.Log("GPS: LATITUDE " + lat + "LONG " + longd);

    }

    void makeAppear() {
        Canvas popup = PopupCanvas.GetComponent<Canvas>();
        if (!popup.enabled && !wasPressed)
        {
            popup.enabled = !(popup.enabled);
            wasPressed = !wasPressed;
        }
    }
}
