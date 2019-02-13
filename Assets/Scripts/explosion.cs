using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {

    public float time;

	// Use this for initialization
	void Start () {
        StartCoroutine(sumir(time));
    }



    IEnumerator sumir(float t)
    {
        yield return new WaitForSeconds(t);
        Destroy(gameObject);

    }
}
