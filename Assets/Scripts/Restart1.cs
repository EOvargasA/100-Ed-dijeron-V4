using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        float value = Input.GetAxis("Fire1");
        if (value > 0)
        {
            SceneManager.LoadScene("Start");
        }
    }
}
