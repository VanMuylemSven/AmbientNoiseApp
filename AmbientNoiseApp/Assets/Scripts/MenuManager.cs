using HoloToolkit.Unity.SpatialMapping;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour {

    public GameObject MenuObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(MenuObject.GetComponent<TapToPlaceOnce>().IsBeingPlaced == false)
        {
            MenuObject.transform.LookAt(Camera.main.transform);
            var rotation = new Vector3(Camera.main.transform.eulerAngles.x, Camera.main.transform.eulerAngles.y + 180.0f, Camera.main.transform.eulerAngles.z);
            MenuObject.transform.Rotate(rotation);
        }
    }
}
