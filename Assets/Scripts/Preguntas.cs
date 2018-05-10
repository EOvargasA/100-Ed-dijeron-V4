using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Preguntas : MonoBehaviour {

    public string[] pregunta;
    public string AnsJ1 = null;
    public string AnsJ2 = null;
    public bool hasChosen = false;

    private Text scoreText;
    private Token J1;
    private Token2 J2;
    private float secondsCounter = 0;
    private float secondsToCount = 1;
    private bool cambio = false;

    // Use this for initialization
    void Start () {
        J1 = GameObject.Find("ExampleA").GetComponent<Token>();
        J2 = GameObject.Find("ExampleB").GetComponent<Token2>();
        getQuestion();
    }

    private void getQuestion()
    {

        string cad = GameObject.Find("DocReader").GetComponent<DocReader>().getQ(GameObject.Find("Materias").GetComponent<MateriasKepper>().roundNum);
        pregunta = cad.Split(',');
        scoreText = GameObject.Find("Text").GetComponent<Text>();
        scoreText.text = pregunta[0];
        scoreText = GameObject.Find("TextA").GetComponent<Text>();
        scoreText.text = pregunta[1];
        scoreText = GameObject.Find("TextB").GetComponent<Text>();
        scoreText.text = pregunta[2];
        scoreText = GameObject.Find("TextC").GetComponent<Text>();
        scoreText.text = pregunta[3];
        scoreText = GameObject.Find("TextD").GetComponent<Text>();
        scoreText.text = pregunta[4];
    }
    
    public void seleccionJ1(string opt1)
    {
        AnsJ1 = opt1;
        if (hasChosen)
        {
            EvaluateA();
        }
        else
        {
            hasChosen = true;
        }
    }

    public void seleccionJ2(string opt)
    {
        AnsJ2 = opt;
        if (hasChosen)
        {
            EvaluateA();
        }
        else
        {
            hasChosen = true;
        }
    }

    private void EvaluateA()
    {
        GameObject.Find("Materias").GetComponent<MateriasKepper>().Answered(AnsJ1, AnsJ2, pregunta[5]);    
        GameObject.Find("Cuadros").GetComponent<Correct>().IC(pregunta[5]);
        GameObject.Find("SoundEff").GetComponent<SoundEff>().Audio(AnsJ1, AnsJ2, pregunta[5]);
        hasChosen = false;
        secondsCounter = 0;
        cambio = true;
    }

    private void Resete()
    {
        J1.resete();
        J2.resete();
    }

    // Update is called once per frame
    void Update () {
        secondsCounter += Time.deltaTime;
        if (secondsCounter >= secondsToCount && cambio)
        {
            GameObject.Find("Materias").GetComponent<MateriasKepper>().Continuing();
        }
    }
}
