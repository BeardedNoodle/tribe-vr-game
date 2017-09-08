using UnityEngine;
using System.Collections;
using System;

public class timeinputobject : MonoBehaviour, timeinputhandler {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

  void timeinputhandler.HandleTimeInput()
    {

        Application.LoadLevel("main-menu");


    }
}
