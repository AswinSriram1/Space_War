using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour
{
    //public static Ads instance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Updatee()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            Advertisement.Show();
        }
    }
    public void Updates()
    {
        if (Advertisement.IsReady("video"))
        {
            Advertisement.Show();
        }
    }
}