﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SliderToMasterBehaviour : MonoBehaviour {

    private Master m;
    private Slider s;
    private UnityEngine.Events.UnityAction<float> v;
    public bool Is_SFX;

	// Use this for initialization
	void Start () {
        m = GameObject.FindGameObjectWithTag("Master").GetComponent<Master>();
        v = SetVolume;
        s = GetComponent<Slider>();
        
        s.onValueChanged.AddListener(v);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //private delegate void VolumeListener(float x);

    private void SetVolume(float setAmt)
    {
        Debug.Log("Setting Volume via Delegate.");
        if(Is_SFX){
            m.SetSFXVolume(setAmt);
        }else{
            m.SetMSXVolume(setAmt);
        }
    }
}
