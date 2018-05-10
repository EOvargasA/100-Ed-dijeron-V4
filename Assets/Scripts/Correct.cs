using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correct : MonoBehaviour {

    public void IC(string CA)
    {
        if (CA == "A")
        {
            GameObject.Find("CuadroA").GetComponent<Cuadro>().IsCorrect();
        }
        if (CA == "B")
        {
            GameObject.Find("CuadroB").GetComponent<Cuadro>().IsCorrect();
        }
        if (CA == "C")
        {
            GameObject.Find("CuadroC").GetComponent<Cuadro>().IsCorrect();
        }
        if (CA == "D")
        {
            GameObject.Find("CuadroD").GetComponent<Cuadro>().IsCorrect();
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
