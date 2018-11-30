﻿using HoloToolkit.Unity.SpatialMapping;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioObjectButtonManager : MonoBehaviour {

    public GameObject buttons;
    public GameObject slider;
    public GameObject audioObject;

    // Use this for initialization
    void Start () {
        ToggleButtons();
        ToggleSlider();
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    // toggle buttons
    public void ToggleButtons()
    {
        if(buttons.activeSelf == true)
        {
            buttons.SetActive(false);
        }
        else
        {
            buttons.SetActive(true);
        }
    }

    // move object, doesn't work
    public void MoveAudioObject()
    {
        Debug.Log("clicked moveAudioObject");
        //search for present TapToPlace component
        if (!audioObject.GetComponent<TapToPlaceOnce>())
        {
            audioObject.AddComponent<TapToPlaceOnce>();
        }
        TapToPlaceOnce tapToPlace = audioObject.GetComponent<TapToPlaceOnce>();
        //set needed properties 
        tapToPlace.HasBeenPlaced = false;
        tapToPlace.IsBeingPlaced = true;
    }

    // delete object
    public void DeleteAudioObject()
    {
        Destroy(audioObject);
    }

    // toggle volume slider
    public void ToggleSlider()
    {
        if (slider.activeSelf == true)
        {
            slider.SetActive(false);
        }
        else
        {
            slider.SetActive(true);
        }

    }
}
