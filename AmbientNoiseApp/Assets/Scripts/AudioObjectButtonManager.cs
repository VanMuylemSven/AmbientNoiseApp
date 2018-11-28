using HoloToolkit.Unity.SpatialMapping;
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
        //search for present TapToPlace component
        if (!audioObject.GetComponent<TapToPlace>())
        {
            audioObject.AddComponent<TapToPlace>();
        }
        TapToPlace tapToPlace = audioObject.GetComponent<TapToPlace>();
        //set needed properties 
        tapToPlace.IsBeingPlaced = true;
        tapToPlace.AllowMeshVisualizationControl = true;
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
