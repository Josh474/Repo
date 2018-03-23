using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firsttime : MonoBehaviour {
    public GameObject instructions;
    public GameObject backbutton;
    private float HasClosed;

	// Use this for initialization
	void Start () {
        HasClosed = PlayerPrefs.GetFloat("HasClosed", 0);

        if(HasClosed == 1)
        {
            instructions.SetActive(false);
            backbutton.SetActive(true);
        }
	}
}
