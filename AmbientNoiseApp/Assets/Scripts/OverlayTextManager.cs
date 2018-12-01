using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlayTextManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(SelfDestructAfterTimer());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator SelfDestructAfterTimer()    
    {
        yield return new WaitForSeconds(3);
        Destroy(this.gameObject);
    }    

}
