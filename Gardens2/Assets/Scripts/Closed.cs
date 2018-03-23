using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closed : MonoBehaviour {

    public void InstructionsDone ()
    {
        PlayerPrefs.SetFloat("HasClosed", 1.0f);
    }
}
