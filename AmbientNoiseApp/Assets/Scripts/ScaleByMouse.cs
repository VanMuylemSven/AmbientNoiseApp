using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleByMouse : MonoBehaviour
{

    private Vector3 _lastMousePos;
    private Vector3 cubeScale;

    private float yMinScale = 10;
    private float yMaxScale = 200;
    private float _lastScaleValue;
	// Use this for initialization
	void Start () {
        cubeScale = this.gameObject.transform.localScale;
        _lastScaleValue = this.transform.localScale.y;
        SetObjectScale(10);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //lastMousePosition = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            /*o.transform.localScale += ((Input.mousePosition - lastMousePosition) * Time.deltaTime * scaleSensitivity);
            lastMousePosition = Input.mousePosition;*/
        }
    }

    public void OnMouseDown()
    {
        _lastMousePos = Input.mousePosition;
        //Last known mouse pos
    }
    private void OnMouseEnter()
    {
        _lastScaleValue = transform.localScale.y;
    }
    public void OnMouseDrag()
    {
        var diff = CalculatePosDifference(Input.mousePosition.y);
        SetObjectScale(diff);
    }

    private float CalculatePosDifference(float yMousePos)
    {
        //Gets the difference in Y Mouse position since starting the mousedrag, and uses that difference for the scaling of the object
        float difference = yMousePos - _lastMousePos.y;
        Debug.Log("Difference = " + difference);
        return difference;
    }
    private void SetObjectScale(float yScale)
    {
        //Check if larger or smaller than min/max values of scale
        if (yScale + _lastScaleValue < 10)
        {
            this.gameObject.transform.localScale = new Vector3(cubeScale.x, 10, cubeScale.z);
        }
        else if (yScale + _lastScaleValue > 200)
        {
            this.gameObject.transform.localScale = new Vector3(cubeScale.x, 200, cubeScale.z);
        }
        else
        {
            yScale = 200 - _lastScaleValue;
            //Scale, and set position correctly again
            Debug.Log("yscale = " + yScale);
            Debug.Log("lastscale = " + _lastScaleValue);
            this.gameObject.transform.localScale = new Vector3(cubeScale.x, _lastScaleValue + yScale, cubeScale.z);
            this.gameObject.transform.localPosition = new Vector3(transform.localPosition.x, -200 + transform.localScale.y / 2);
        }
    }

    public float getPercentage()
    {
        //Get scale to percentage (scale 200 == 100%, 100 = 50%, ...)
        return 0;
    }
    
}
