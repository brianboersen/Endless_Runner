using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class textManeger : MonoBehaviour {

    public GameObject maneger;
    private Score theScore;
    public Text[] text;

	void Start () {
        theScore = maneger.GetComponent<Score>();
	}
	
	void Update () {
        text[0].text ="score: " + (int)theScore.gameScore;
	}
}
