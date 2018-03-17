using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockSite : MonoBehaviour {

    public GameObject SiteButton;
    public GameObject TempSiteHolder;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter(Collider other)
    {
        //if(other.gameObject.tag == "Player")
        //{
            TempSiteHolder.SetActive(false);
            SiteButton.SetActive(true);

    }
}
