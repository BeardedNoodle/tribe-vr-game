using UnityEngine;
using System.Collections;

public class changecam : MonoBehaviour, timeinputhandler
{
    public Vector3 c1;
    public GameObject y;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void timeinputhandler.HandleTimeInput()
    {

        y.transform.position = c1;


    }
}
