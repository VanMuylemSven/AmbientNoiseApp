using HoloToolkit.Unity.SpatialMapping;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MoveObject()
    {
        TapToPlaceOnce tapToPlace = this.GetComponent<TapToPlaceOnce>();

        //set needed properties 
        tapToPlace.HasBeenPlaced = false;
        tapToPlace.IsBeingPlaced = true;
    }
}
