using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneMenu : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(LoadSecondSceneAfterDelay(3f));
    }

    IEnumerator LoadSecondSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Menu");
    }

}