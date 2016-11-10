using UnityEngine;
using System;
using System.Collections;

public class clockAnimator : MonoBehaviour {

    //Sets constant variables for how each arm needs to rotate around the clock
    const float
        hoursToDegrees = 360f / 12f,
        minutesToDegrees = 360f / 60f,
        secondsToDegrees = 360f / 60f;

    public Transform hours, minutes, seconds;

    public bool analog;

	// Update is called once per frame
	void Update () {
        if (analog)
        {
            TimeSpan timespan = DateTime.Now.TimeOfDay; //Similar to date time, but is represented by double values meaning it can account for the time in between each increment
            hours.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalHours * -hoursToDegrees);
            minutes.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalMinutes * -minutesToDegrees);
            seconds.localRotation = Quaternion.Euler(0f, 0f, (float)timespan.TotalSeconds * -secondsToDegrees);
        }
        else
        {
            DateTime time = DateTime.Now;
            hours.localRotation = Quaternion.Euler(0f, 0f, time.Hour * -hoursToDegrees); //Sets hour hand
            minutes.localRotation = Quaternion.Euler(0f, 0f, time.Minute * -minutesToDegrees); //Sets minutes hand
            seconds.localRotation = Quaternion.Euler(0f, 0f, time.Second * -secondsToDegrees); //Sets second hand
        }
        
        
	}
}
