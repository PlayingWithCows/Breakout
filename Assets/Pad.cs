using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour {

    public Transform[] launchSlots;
    public float padSize = 1;

    void Start()
    {
       
    }

    public void AdjustPadSize()
    {
        transform.localScale = new Vector3(padSize, 1f, 1f);
    }



}
