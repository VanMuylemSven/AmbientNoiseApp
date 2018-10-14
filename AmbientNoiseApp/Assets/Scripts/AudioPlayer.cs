using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPlayer : MonoBehaviour {

    public GameObject AudioSource;
    public Image FilledImage;

    private Slider _slider;

	// Use this for initialization
	void Start () {
        this.gameObject.GetComponent<Slider>().onValueChanged.AddListener(delegate { ChangeVolume(); });
        _slider = this.gameObject.GetComponent<Slider>();

        //Calling at the start so the volume gets set to it's actual value instead of 1.
        ChangeVolume();

    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void ChangeVolume()
    {
        AudioSource.GetComponent<AudioSource>().volume = _slider.value;
        //Also Change Image transition
        Color imgColor = FilledImage.color;
        imgColor.a = _slider.value; //Change image transparancy
        FilledImage.color = imgColor;
    }
}
