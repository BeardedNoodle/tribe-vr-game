using UnityEngine;
using System.Collections;

public class data : MonoBehaviour {

    public int odun = 100;
    public int yemek = 100;
    public int mutluluk = 100;
	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
