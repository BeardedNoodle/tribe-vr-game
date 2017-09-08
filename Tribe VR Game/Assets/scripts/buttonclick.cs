using UnityEngine;
using System.Collections;
using System;

public class buttonclick : MonoBehaviour {
    string levelname;
    public void changelevel(string levelname) {

        Application.LoadLevel(levelname);

    }
}
