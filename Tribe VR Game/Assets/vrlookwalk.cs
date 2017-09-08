using UnityEngine;
using System.Collections;

public class vrlookwalk : MonoBehaviour {

    public Transform vrCamera;
    public float toogleangle = 40.0f;
    public float speed = 3.0f;
    public bool moveforward ;
    public CharacterController cc;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (vrCamera.eulerAngles.x >= toogleangle && vrCamera.eulerAngles.x < 90.0f) {
            Debug.Log("erroryurume1");
            moveforward = true;
        }
        else
        {
            Debug.Log(vrCamera.eulerAngles.x+ " 11  " + vrCamera.eulerAngles.y + "    " + vrCamera.name);
            moveforward = false;
        }
        if (moveforward)
        {
            Debug.Log("erroryurume");
            Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
           
        }
	}
}
