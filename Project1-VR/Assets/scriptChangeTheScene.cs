using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scriptChangeTheScene : MonoBehaviour {

    public void NextScene()
    {
        Debug.Log("works");
        Invoke("ChangeLevel", 3.0f);
    }

    void ChangeLevel()
    {
        SceneManager.LoadScene("scene1");
    }
}


    