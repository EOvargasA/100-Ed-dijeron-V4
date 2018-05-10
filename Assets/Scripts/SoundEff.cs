using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundEff : MonoBehaviour {

    public AudioClip C;
    public AudioClip I;

    // Use this for initialization
    void Start () {
        
    }

    public void Audio (string A, string B, string d)
    {
        if (A == d || B == d)
        {
            AudioSource.PlayClipAtPoint(C, transform.position);
        }
        else
        {
            AudioSource.PlayClipAtPoint(I, transform.position);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
