using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedDisableFunction : MonoBehaviour
{
    public float delay = 3f;

    public GameObject gameObjectToToggle;

    public GameObject selfGameObject;

    public Animator animator;

    void OnEnable()
    {
        animator.ResetTrigger("Pressed");
    }

    public void DelayedDisable()
    {
        StartCoroutine(ToggleStateCoroutine());
    }

    IEnumerator ToggleStateCoroutine()
    {
        yield return new WaitForSeconds(delay);
        selfGameObject.SetActive(!selfGameObject.activeSelf);
        gameObjectToToggle.SetActive(!gameObjectToToggle.activeSelf);
    }

}
