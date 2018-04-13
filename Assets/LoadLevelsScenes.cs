using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelsScenes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void loadLevel1()
    {
        SceneManager.LoadScene("level1");
    }


    public void loadLevel2()
    {
        SceneManager.LoadScene("level2");
    }


    public void loadLevel3()
    {
        SceneManager.LoadScene("level3");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
