using HoloToolkit.Unity.SpatialMapping;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CategoryManager : MonoBehaviour {


    /*public enum Direction { Next, Previous };
    public Direction direction;*/
    //public GameObject TitleObject;
    public GameObject[] Categories;
    public GameObject CategoryContainer;
    //public string[] CategoryTitles = new string[4] { "Beach", "City", "Desert", "Forest" };


    public enum ROOMSIZE { Small, Medium, Large, None };
    public ROOMSIZE room = ROOMSIZE.Small;

    private int _currentCategory = 0;
    public enum Category
    {
        Beach,
        City,
        Desert,
        Forest
    }

	// Use this for initialization
	void Start () {
        //Set category at start to prevent Active/inactive issues
        SetCategory();
        //SetTitle();
        SetGrayScaleCategories();

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
        //SetTitle();
        SetGrayScaleCategories();
    }
    public void SwitchPreviousCategory()
    {
        _currentCategory--;
        if (_currentCategory < 0)
            _currentCategory = Categories.Length - 1;
        //Debug.Log("-- = " + _currentCategory);
        SetCategory();
        //SetTitle();
        SetGrayScaleCategories();
    }
    public void SwitchToCategory(int categoryNumber/*Category category*/)
    {
        /*if(category == Category.Beach)
        {
            _currentCategory = 0;
        }
        else if (category == Category.City)
        {
            _currentCategory = 1;
        }
        else if (category == Category.Desert)
        {
            _currentCategory = 2;
        }
        else if (category == Category.Forest)
        {
            _currentCategory = 3;
        }*/
        _currentCategory = categoryNumber;
        SetCategory();
        //SetTitle();
        SetGrayScaleCategories();
    }


    public void SpawnAudioObject(GameObject audioObject)
    {
        //Spawns the selected Audio Object via the button in the menu at the position of the mouse/menu
        //and afterwards plays the Menu-close animation, and disables the menu.
        Debug.Log("Clicked audio button");
        Debug.Log("MENU pos = " + this.gameObject.transform.position);
        Debug.Log("BUTTON pos = " + Input.mousePosition);

        Vector3 newPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);

        Instantiate(audioObject, newPos, Quaternion.identity);

        //set audioObject settings
        AudioSource attachedAudio = audioObject.GetComponentInChildren<AudioSource>();
        attachedAudio.spatialize = true;
        attachedAudio.spread = 0;
        //spatialBlend allows to hear spatialized sounds
        attachedAudio.spatialBlend = 1;
        //optional: set space size, see enum ROOMSIZES
        //attachedAudio.SetSpatializerFloat(1, (float)room);

        //search for present TapToPlace component
        if(!audioObject.GetComponent<TapToPlace>())
        {
            audioObject.AddComponent<TapToPlace>();
        }
        TapToPlace tapToPlace = audioObject.GetComponent<TapToPlace>();
        //set needed properties 
        tapToPlace.IsBeingPlaced = true;
        tapToPlace.AllowMeshVisualizationControl = true;

        if (GameObject.FindGameObjectWithTag("Menu").GetComponent<TapToPlace>() == true)
        {
            //GameObject.FindGameObjectWithTag("Menu").GetComponent<TapToPlace>().enabled = false;
            //GameObject.FindGameObjectWithTag("Menu").GetComponentInChildren<TapToPlace>().enabled = true;
            //Destroy(GameObject.FindGameObjectWithTag("Menu").GetComponent<TapToPlace>());
        }
    }

    // ===========
    // Private methods
    // ===========
    //Update category items in the Menu
    private void SetCategory()
    {
        //Debug.Log("currentcat = " + _currentCategory);
        for (int i = 0; i < Categories.Length; i++)
        {
            //Debug.Log("i = " + i);
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
    //Update the category title text
    /*private void SetTitle()
    {
        TitleObject.GetComponent<Text>().text = CategoryTitles[_currentCategory];
    }*/

    //Called everytime object becomes active
    private void OnEnable()
    {
        //On activate, perform the animation
        //...
    }
    private void OnDisable()
    {
        //Perform the animation, then disable
    }


    /* GRAYSCALING */
    public void SetGrayScaleCategories()
    {
        //Nonselected categories get gray color overlayed, selected one gets full color
        //Gets all child buttons
        Color grayCol = new Color(0.3f, 0.3f, 0.3f);
        int iterator = 0;
        foreach (Transform cat in CategoryContainer.transform)
        {
            //Debug.Log(cat);
            if(_currentCategory == iterator)
            {
                cat.GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f);
            }
            else
            {
                cat.GetComponent<Image>().color = grayCol;
            }
            iterator++;

        }
    }
}
