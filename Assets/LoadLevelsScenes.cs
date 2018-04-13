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
        Debug.Log("clicked !");
        SceneManager.LoadScene("");
    }


    public void loadLevel2()
    {

    }


    public void loadLevel3()
    {

    }

    public void quitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
