using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleState : MonoBehaviour
{
    public float delay = 3f;
    private GameObject self;

    void Start()
    {
        self = GetComponent<GameObject>();
    }
    public void ToggleObject()
    {
        StartCoroutine(ToggleStateCoroutine());
    }

    IEnumerator ToggleStateCoroutine()
    {
        yield return new WaitForSeconds(delay);
        self.SetActive(self.activeSelf);
    }
}
