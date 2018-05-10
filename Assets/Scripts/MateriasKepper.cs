using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MateriasKepper : MonoBehaviour {

    public static MateriasKepper matKepper;
    public string materia1;
    public string materia2;
    public bool hasChosen = false;
    public int scoreJ1 = 0;
    public int scoreJ2 = 0;
    public int roundNum = 1;

    private void Awake()
    {
        if (matKepper == null)
        {
            matKepper = this;
            DontDestroyOnLoad(gameObject);
        }else if (matKepper!=this){
            Destroy(gameObject);
        }
    }

    public void seleccionJ1(string opt)
    {
        materia1 = opt;
        if (hasChosen)
        {
            SceneManager.LoadScene("Pruebas");
            hasChosen = false;
        }
        else
        {
            hasChosen = true;
        }
    }

    public void seleccionJ2(string opt)
    {
        materia2 = opt;
        if (hasChosen)
        {
            SceneManager.LoadScene("Pruebas");
            hasChosen = false;
        }
        else
        {
            hasChosen = true;
        }
    }

    public void Answered(string J1, string J2, string A)
    {
        if (J1 == A)
        {
            scoreJ1++;
        }
        if (J2 == A)
        {
            scoreJ2++;
        }
    }

    public void Continuing()
    {
        roundNum++;
        if (roundNum > 5)
        {
            if (scoreJ1 == scoreJ2)
            {
                SceneManager.LoadScene("Pruebas");
            }
            else
            {
                if (scoreJ1 > scoreJ2)
                {
                    roundNum = 1;
                    SceneManager.LoadScene("1Win");
                }
                else
                {
                    roundNum = 1;
                    SceneManager.LoadScene("2Win");
                }
            }
        }
        else
        {
            SceneManager.LoadScene("Pruebas");
        }
    }

    public string getMat1()
    {
        return materia1;
    }

    public string getMat2()
    {
        return materia2;
    }
}
