using UnityEngine;
using System.Collections;

public class change : MonoBehaviour, timeinputhandler
{
    public GameObject x;
    public GameObject y;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void timeinputhandler.HandleTimeInput()
    {

        y.SetActive(false);
        x.SetActive(true);
        

    }
}
