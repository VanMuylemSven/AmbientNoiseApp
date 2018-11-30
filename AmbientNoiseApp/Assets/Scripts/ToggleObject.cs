using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObject : MonoBehaviour {

    public GameObject DeleteButton;
    public GameObject ToggleSliderButton;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ToggleSlider()
    {
        if (this.gameObject.activeSelf)
        {
            this.gameObject.SetActive(false);
            Vector3 delPos = DeleteButton.gameObject.transform.localPosition;
            DeleteButton.gameObject.transform.localPosition = new Vector3(25, delPos.y);
            Vector3 togglePos = ToggleSliderButton.gameObject.transform.localPosition;
            ToggleSliderButton.gameObject.transform.localPosition = new Vector3(-25, togglePos.y);
        }

        else
        {
            this.gameObject.SetActive(true);
            Vector3 delPos = DeleteButton.gameObject.transform.localPosition;
            DeleteButton.gameObject.transform.localPosition = new Vector3(50, delPos.y);
            Vector3 togglePos = ToggleSliderButton.gameObject.transform.localPosition;
            ToggleSliderButton.gameObject.transform.localPosition = new Vector3(-50, togglePos.y);
        }
            

    }
}
