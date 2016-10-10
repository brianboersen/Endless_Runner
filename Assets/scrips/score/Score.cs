using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
    private float _score;
    private float timer;
    public float gameScore
    {   get {return _score;}
        set { }      
    }
    public int walkpoints;

    void Start() {
        _score = 0;
    }

	void Update () {
        timer += Time.deltaTime;
        _score = timer * walkpoints;
        
	}
}
