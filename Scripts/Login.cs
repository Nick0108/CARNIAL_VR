using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour {
    void EntertheCarnival()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("Carnival");
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        EntertheCarnival();

    }
}
