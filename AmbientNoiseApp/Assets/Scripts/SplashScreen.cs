using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

    public string SceneNameToLoad;
    public GameObject ObjectToFade;
    public int SecondsToWaitForLoading = 5;

	void Start () {
        StartCoroutine(FadeOut());
    }


    void Update () {

    }

    IEnumerator FadeOut()
    {
        //ObjectToFade.SetActive(false);
        var color = ObjectToFade.GetComponent<Image>().color;
        while (color.a > 0.0f)
        {
            color.a -= Time.deltaTime / SecondsToWaitForLoading;
            ObjectToFade.GetComponent<Image>().color = color;
            yield return null;
        }
        SceneManager.LoadScene(SceneNameToLoad);
        yield return null;
        
    }
}
