using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteThisObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Delete()
    {
        Destroy(this.gameObject);
    }
}
