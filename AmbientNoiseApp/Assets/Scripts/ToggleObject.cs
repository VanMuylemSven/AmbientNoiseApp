using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToggleSlider()
    {
        if(this.gameObject.activeSelf)
            this.gameObject.SetActive(false);
        else
            this.gameObject.SetActive(true);
    }
}
