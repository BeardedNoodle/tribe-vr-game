using UnityEngine;
using System.Collections;

public class scenechange : MonoBehaviour,timeinputhandler {

    public string name;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void timeinputhandler.HandleTimeInput()
    {

        Application.LoadLevel(name);


    }
}
