using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adtimer : MonoBehaviour
{
    [SerializeField] float AdTime;
    public Ads ads;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(callAD());
    }

    IEnumerator callAD()
    {
        yield return new WaitForSeconds(AdTime);
        ads.Updates();
    }
}

