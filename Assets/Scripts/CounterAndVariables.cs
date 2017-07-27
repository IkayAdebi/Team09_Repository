using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterAndVariables : MonoBehaviour {
    public static int shipHealth = 100;
    public static int playerEnergy = 100;
    public static int fire1Time = 0;
   // public static int fire2Time = 0;
    private int fire1Counter = 0;
    //  private int fire2Counter = 0;
    public GameObject fireMonitor;
    public GameObject noFireMonitor;

	// Use this for initialization
	void Start () {
        Instantiate(fireMonitor);
        Instantiate(noFireMonitor);
        fireMonitor.SetActive(false);
        noFireMonitor.SetActive(true);

	}

    // Update is called once per frame
    void Update()
    {
        if (shipHealth > 0)
        {
            fire1Counter++;
            Debug.Log(fire1Counter);
            // fire2Counter++;
            if (fire1Counter > 300)
            {
                noFireMonitor.SetActive(false);
                fireMonitor.SetActive(true);
                fire1Time++;
                if (fire1Time > 3000)
                {
                    //shipHealth = shipHealth - 5;
                }
            }
           /* if (fire2Counter > 1000)
            {
                fire2Time++;
                if (fire2Time > 3000)
                {
                    shipHealth = shipHealth - 5;
                }
            }*/
        }
    }
}
