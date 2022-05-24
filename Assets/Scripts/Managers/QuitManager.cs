using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitManager : MonoBehaviour
{
    public LevelLoader levelLoader;

    public void QuitGame()
    {
        StartCoroutine(QuitGameCoroutine());
    }
    IEnumerator QuitGameCoroutine()
    {
        levelLoader.transition.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(levelLoader.transitionTime);

        #if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

        #endif

        Application.Quit();
    }

}
