using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverlayTextManager : MonoBehaviour {

    // array with all parts of Tutorial
    public GameObject[] TutorialParts = new GameObject[5];
    private int _currentTutorial = 0;

    public string SceneNameToLoad;

    // Use this for initialization
    void Start () {

        GameObject.FindGameObjectWithTag("Menu").SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToNextTutorial()
    {
        _currentTutorial++;
        for (int i = 0; i < TutorialParts.Length; i++)
        {
            if (i == _currentTutorial)
            {
                TutorialParts[i].SetActive(true);

            }
            else
            {
                TutorialParts[i].SetActive(false);
            }
        }

        if(_currentTutorial == 5)
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        SceneManager.LoadScene(SceneNameToLoad);
        yield return null;
    }


}
