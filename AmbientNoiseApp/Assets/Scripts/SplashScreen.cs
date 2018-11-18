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
        StartCoroutine(FadeToBlack());
        StartCoroutine(FadeOut());
    }


    void Update () {
        //FadeOut();
    }

    IEnumerator FadeOut()
    {
        //ObjectToFade.SetActive(false);
        var color = ObjectToFade.GetComponent<Image>().color;
        while (color.a > 0.0f)
        {
            color.a -= Time.deltaTime / 4;
            ObjectToFade.GetComponent<Image>().color = color;
            yield return null;
        }
        yield return null;
        
    }
    IEnumerator FadeToBlack()
    {
        Debug.Log("Waiting to fade");
        yield return new WaitForSeconds(SecondsToWaitForLoading);
        Debug.Log("Fading");
        var color = ObjectToFade.GetComponent<Image>().color;
        while(ObjectToFade.GetComponent<Image>().color.a < 1.0f)
        {
            color.a += Time.deltaTime / 4;
            ObjectToFade.GetComponent<Image>().color = color;
            yield return null;
            Debug.Log("1");

        }
        yield return null;
        StartCoroutine(LoadScene());


    }
    IEnumerator LoadScene()
    {
        SceneManager.LoadScene(SceneNameToLoad);
        yield return null;
    }
}
