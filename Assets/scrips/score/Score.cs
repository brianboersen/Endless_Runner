using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
    public float gameScore = 0;
    public int walkpoints;

	void Update () {
        gameScore = Time.time * walkpoints;
        
	}
}
