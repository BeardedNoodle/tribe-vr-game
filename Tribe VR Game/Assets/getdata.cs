using UnityEngine;
using System.Collections;

public class getdata : MonoBehaviour {

    // Use this for initialization
    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject go = GameObject.Find("data");
        data dt = go.GetComponent<data>(); 
    }
}
