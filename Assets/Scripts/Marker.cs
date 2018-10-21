using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker {
    public double latitude;
    public double longitude;
    public string clue;

    public Marker(double latitude, double longitude,string clue)
    {
        this.latitude = latitude;
        this.longitude = longitude;
        this.clue = clue;


    }
}
