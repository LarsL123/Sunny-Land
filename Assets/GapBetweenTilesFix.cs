using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GapBetweenTilesFix : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FailedUpdate () {
        Debug.Log(Screen.width); 
        Debug.Log(Screen.height);

        if (Screen.width % 2 == 1)
        {
            Debug.Log("Inloop");
            Screen.SetResolution(Screen.width - 1, Screen.height, false);
        }

    }
}
