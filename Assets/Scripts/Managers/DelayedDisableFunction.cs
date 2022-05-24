using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDisableFunction : MonoBehaviour
{
    public float delay = 3f;

    public GameObject gameObjectToToggle;

    public GameObject selfGameObject;

    public void DelayedDisable()
    {
        StartCoroutine(ToggleStateCoroutine());
    }

    IEnumerator ToggleStateCoroutine()
    {
        yield return new WaitForSecondsRealtime(delay);
        selfGameObject.SetActive(!selfGameObject.activeSelf);
        gameObjectToToggle.SetActive(!gameObjectToToggle.activeSelf);
    }

}
