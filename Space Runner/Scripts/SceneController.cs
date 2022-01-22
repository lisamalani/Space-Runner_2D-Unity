using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string nextLevel;

    public void GotToNextScene()
    {
        SceneManager.LoadScene(nextLevel);
    }

    public void ReloadScene()
    {
        string currentLevel = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentLevel);
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadScene();
        }
    }
}
