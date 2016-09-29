using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class textManeger : MonoBehaviour {

    public GameObject maneger;
    private Score theScore;
    public Text[] text;
	// Use this for initialization
	void Start () {
        theScore = maneger.GetComponent<Score>();
	}
	
	// Update is called once per frame
	void Update () {
        text[0].text ="score: " + (int)theScore.gameScore;
       //aids
	}
}
