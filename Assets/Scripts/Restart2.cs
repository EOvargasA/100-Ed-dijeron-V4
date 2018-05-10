using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        float value = Input.GetAxis("Fire11");
        if (value > 0)
        {
            SceneManager.LoadScene("Start");
        }
    }
}
