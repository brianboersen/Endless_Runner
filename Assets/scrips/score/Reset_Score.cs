using UnityEngine;
using System.Collections;

public class Reset_Score : MonoBehaviour {

    private Score score;
    private GameObject meneger;
	void Start () {
        meneger = GameObject.FindGameObjectWithTag ("gameManeger");
        score = meneger.GetComponent<Score>();
	}
	
    public void Reset()
    {
        score.gameScore = 0;
    }
}
