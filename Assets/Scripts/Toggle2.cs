﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        float value = Input.GetAxis("Fire11");
        if (value > 0)
        {
            gameObject.GetComponent<Toggle>().isOn = true;
            GameObject.Find("Ready").GetComponent<Ready>().RP2();
        }
    }
}
