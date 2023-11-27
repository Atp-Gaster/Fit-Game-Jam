using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public Animator Transit;

    public bool changeScene = false;

    public float TranTime = 1f;

    // Update is called once per frame
    void Update()
    {
        if (changeScene)
        {
            LoadNextScreen();
            changeScene = false;
        }
    }

    public void LoadNextScreen()
    {
        StartCoroutine(LoadScene(SceneManager.GetActiveScene().buildIndex + 1));
        
    }

    IEnumerator LoadScene(int SceneIndex)
    {
        Transit.SetTrigger("Start");

        yield return new WaitForSeconds(TranTime);

        SceneManager.LoadScene(SceneIndex);
    }

    public void ChangeScene()
    {
        changeScene = true;
    }
}
