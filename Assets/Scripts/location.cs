using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class location : MonoBehaviour
{
    public static location Instance { set; get; }

    public float latitude;
    public float longitude;
    // Use this for initialization
    void Start()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        StartCoroutine(StartLocationService());
    }
    private IEnumerator StartLocationService()
    {
        if (!Input.location.isEnabledByUser)
        {
            //Debug.Log("User has not enabled GPS");
            yield break;
        }

        Input.location.Start(0.1f, 0.1f);
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait>0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        if (maxWait <= 0)
        {
            Debug.Log("GPS: Timed out");
            yield break;
        }
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            //Debug.Log("GPS: Unable to determine");
            yield break;
        }
        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.longitude;

    }
    // Update is called once per frame
    void Update()
    {
        latitude = Input.location.lastData.latitude;
        longitude = Input.location.lastData.longitude;
        //Debug.Log("GPS: LAT " + latitude + " GPS: LONG" + longitude);


    }
}
