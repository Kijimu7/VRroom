using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Clock_Analog_Red : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
     GameObject secondHand;
     GameObject hourHand;
     GameObject minutHand;
    string oldSeconds;

    void Start()
    {

    }

    void Update()
    {
        DateTime currentTime = DateTime.Now;

        float secondsDegree = -(currentTime.Second / 60f) * 360f;
        Debug.Log(secondsDegree);
        secondHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, secondsDegree));



/*        string seconds = System.DateTime.UtcNow.ToString("ss");
        print(seconds);

        if (seconds != oldSeconds)
        {
            UpdateTimer();
        }
        oldSeconds = seconds;
        
        void UpdateTimer()
        {
            int secondsInt = int.Parse(System.DateTime.UtcNow.ToString("ss"));
            int minutesInt = int.Parse(System.DateTime.UtcNow.ToString("mm"));
            int hoursInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("hh"));
            print( hoursInt + " : " + minutesInt + " : " + secondsInt);
        }
*/
        
    }
}
