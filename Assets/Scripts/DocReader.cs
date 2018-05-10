using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DocReader : MonoBehaviour {

    public string[] questA;
    public int lengthA;

    private MateriasKepper matKeeper;

    // Use this for initialization
    void Start () {
        matKeeper = GameObject.Find("Materias").GetComponent<MateriasKepper>();
    }

    private int getLength(int RN)
    {
        int counter = 0;
        System.IO.StreamReader file = new System.IO.StreamReader(getMat(RN));
        while (file.ReadLine() != null)
        {
            counter++;
        }
        file.Close();
        return counter;
    }

    public void ReadDoc(int roundNum)
    {
        lengthA = getLength(roundNum);
        questA = new string[lengthA];
        int counter = 0;
        System.IO.StreamReader file = new System.IO.StreamReader(getMat(roundNum));
        while (counter < lengthA - 1)
        {
            questA[counter] = file.ReadLine();
            counter++;
        }
        file.Close();
    }

    private string getMat(int roundNum)
    {
        if ((roundNum % 2) == 0)
        {
            return matKeeper.getMat1();
        }
        else
        {
            return matKeeper.getMat2();
        }
    }

    public string getQ (int RN)
    {
        ReadDoc(RN);
        System.Random rng = new System.Random();
        int num = rng.Next(0,questA.Length - 1);
        return questA[num];
    }
}
