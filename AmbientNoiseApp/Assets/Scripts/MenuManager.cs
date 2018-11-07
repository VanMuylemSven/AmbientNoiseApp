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
        if (Input.GetKeyDown("z"))
        {
            //Menu
            MenuObject.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown("e"))
        {
            //Menu
            MenuObject.gameObject.SetActive(true);
        }
    }
}
