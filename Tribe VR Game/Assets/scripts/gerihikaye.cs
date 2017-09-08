using UnityEngine;
using System.Collections;

public class gerihikaye : MonoBehaviour,timeinputhandler {

    public GameObject camera1;
    private Vector3 c1;
    private Vector3 c2;
    // Use this for initialization
    void Start()
    {
        c1.x = 300.015f;
        c1.y = 59.61972f;
        c1.z = 504f;
        c2.x = 302.489f;
        c2.y = 59.71194f;
        c2.z = -12.65225f;

    }

    // Update is called once per frame
    void Update()
    {

    }
    void timeinputhandler.HandleTimeInput()
    {

        camera1.transform.position = c1;

    }
}
