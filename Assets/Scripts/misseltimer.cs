using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misseltimer : MonoBehaviour {

    public static float intervalo;

	// Use this for initialization
	void Start () {
        intervalo = 1.0f;
        StartCoroutine(jogarmisseis(intervalo));
    }

    IEnumerator jogarmisseis(float t)
    {
        yield return new WaitForSeconds(t);
        if (Controller.jogando)
        {
            Enemy.jogarmissel = true;
        }
        StartCoroutine(jogarmisseis(intervalo));
    }
}
