using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Cuadro : MonoBehaviour {

    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        anim.SetBool("IsSelected", true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        anim.SetBool("IsSelected", false);
    }

    public void IsCorrect()
    {
        anim.SetTrigger("IsCorrect");
    }
}
