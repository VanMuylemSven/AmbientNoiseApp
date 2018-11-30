using HoloToolkit.Unity.SpatialMapping;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioObjectButtonManager : MonoBehaviour {

    public GameObject buttons;
    public GameObject[] ButtonObjects = new GameObject[3];
    public GameObject slider;
    public GameObject audioObject;

    // Use this for initialization
    void Start () {
        ToggleButtons();
        //ToggleSlider();
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
            //Also deactivate and reset buttons + slider
            ButtonObjects[0].gameObject.transform.localPosition = new Vector3(-50f, -40f);
            ButtonObjects[1].gameObject.transform.localPosition = new Vector3(0f, -40f);
            ButtonObjects[2].gameObject.transform.localPosition = new Vector3(50f, -40f);
            slider.SetActive(false);
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

        TapToPlaceOnce tapToPlace = audioObject.GetComponent<TapToPlaceOnce>();
        //find volumeSlider
        slider.SetActive(false);

        //set needed properties 
        tapToPlace.HasBeenPlaced = false;
        tapToPlace.IsBeingPlaced = true;
    }

    // delete object
    public void DeleteAudioObject()
    {
        Destroy(this.gameObject);
    }

    // toggle volume slider
    public void ToggleSlider()
    {
        Debug.Log("Toggled Slider");
        if (slider.activeSelf == true)
        {
            ButtonObjects[0].gameObject.transform.localPosition = new Vector3(-50f, -40f);
            ButtonObjects[1].gameObject.transform.localPosition = new Vector3(0f, -40f);
            ButtonObjects[2].gameObject.transform.localPosition = new Vector3(50f, -40f);
            slider.SetActive(false);
        }
        else
        {
            ButtonObjects[0].gameObject.transform.localPosition = new Vector3(40f, -40f);
            ButtonObjects[1].gameObject.transform.localPosition = new Vector3(40f, -70f);
            ButtonObjects[2].gameObject.transform.localPosition = new Vector3(40f, -100f);
            slider.SetActive(true);
        }

    }
}
