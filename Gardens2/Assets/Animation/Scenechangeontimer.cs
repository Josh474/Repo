using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechangeontimer : MonoBehaviour {

    public float scenechangetimer = 3.0f; 

	// Update is called once per frame
	void Update () {
        scenechangetimer -= Time.deltaTime;

        if(scenechangetimer <= 0)
        {
            SceneManager.LoadScene("Start");
        }
	}
}
