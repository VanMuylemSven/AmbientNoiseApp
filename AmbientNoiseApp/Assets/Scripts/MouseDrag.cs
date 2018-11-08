using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDrag : MonoBehaviour {

    public float _distance = 10;

    private void OnMouseDrag()
    {
        Debug.Log("Dragging from " + transform.position);
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _distance); //distance instead of pos.z?
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
        Debug.Log("To pos: " + objectPos); ///////////////////

        this.transform.position = mousePos;
    }
}
