using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Ready : MonoBehaviour {

    private bool player1 = false;
    private bool player2 = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RP1()
    {
        player1 = true;
        if (player2)
        {
            SceneManager.LoadScene("Seleccion");
        }
    }

    public void RP2()
    {
        player2 = true;
        if (player1)
        {
            SceneManager.LoadScene("Seleccion");
        }
    }
}
