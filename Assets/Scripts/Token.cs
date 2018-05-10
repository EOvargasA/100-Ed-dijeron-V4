using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour {

    public float speed = 5.0f;
    public string option;
    public bool hasSelected = false;

    private Rigidbody2D rgb;
    private MateriasKepper matKeeper;
    private Preguntas que;

    // Use this for initialization
    void Start () {
        option = " ";
        rgb = GetComponent<Rigidbody2D>();
        matKeeper = GameObject.Find("Materias").GetComponent<MateriasKepper>();
        que = GameObject.Find("Canvas").GetComponent<Preguntas>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (!hasSelected)
        {
            float value = Input.GetAxis("Fire1");
            float v = Input.GetAxis("Horizontal");
            float w = Input.GetAxis("Vertical");
            Vector2 vel = new Vector2(0, 0);
            v *= speed;
            w *= speed;
            vel.x = v;
            vel.y = w;
            rgb.velocity = vel;
            if (value > 0)
            {
                if (option != " ")
                {
                    if (option == "A" || option == "B" || option == "C" || option == "D")
                    {
                        SelectAnswer();
                    }
                    else
                    {
                        SelectMateria();
                    }
                    vel.x = 0;
                    vel.y = 0;
                    rgb.velocity = vel;
                }
            }
        }
    }

    private void SelectMateria()
    {
        hasSelected = true;
        matKeeper.seleccionJ1(option);
    }

    private void SelectAnswer()
    {
        hasSelected = true;
        que.seleccionJ1(option);
    }

    public void resete()
    {
        hasSelected = false;
        option = " ";
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        option = collider.gameObject.GetComponent<MateriaButton>().opcion;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        option = " ";
    }
}
