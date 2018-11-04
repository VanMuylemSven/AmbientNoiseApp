﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCategory : MonoBehaviour {

    /*public enum Direction { Next, Previous };
    public Direction direction;*/
    public GameObject[] Categories;

    private int _currentCategory = 0;

	// Use this for initialization
	void Start () {
        //Set category at start to prevent Active/inactive issues
        SetCategory();
	}
	
	// Update is called once per frame
	void Update () {
    }

    //Next or prev button gets called
    public void SwitchNextCategory()
    {
        _currentCategory++;
        if (_currentCategory > Categories.Length-1)
            _currentCategory = 0;
        //Debug.Log("++ = " + _currentCategory);
        SetCategory();
    }
    public void SwitchPreviousCategory()
    {
        _currentCategory--;
        if (_currentCategory < 0)
            _currentCategory = Categories.Length - 1;
        //Debug.Log("-- = " + _currentCategory);
        SetCategory();
    }

    private void SetCategory()
    {
        //Debug.Log("currentcat = " + _currentCategory);
        for (int i = 0; i < Categories.Length; i++)
        {
            Debug.Log("i = " + i);
            if (i == _currentCategory)
            {
                Categories[i].SetActive(true);
                //Debug.Log("Setting " + i + " active");
            }
            else
            {
                Categories[i].SetActive(false);
                //Debug.Log("Setting " + i + " INactive");
            }
        }
    }
}
