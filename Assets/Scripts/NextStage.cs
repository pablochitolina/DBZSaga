using UnityEngine;
using System.Collections;

public class NextStage : MonoBehaviour {
	public bool mostra = false;
	public GUIStyle fonte;

	public GameObject ready;
	public GameObject go;
	public float tempoTotal = 4f;
	public float delayTempoTotal = 4f;

	//private Rect position = new Rect (Screen.width /2 , Screen.height /2, 100, 100);
	// Use this for initialization
	void Start () {
		//Screen.fullScreen = true;
		ready.SetActive (false);
		go.SetActive (false);
		delayTempoTotal = tempoTotal;
	}
	
	// Update is called once per frame
	void Update () {
		if (mostra) {
			ready.SetActive(true);
			delayTempoTotal -= Time.deltaTime;
			if(delayTempoTotal/2 <= 0){
				ready.SetActive(false);
				go.SetActive(true);
			}
			if(delayTempoTotal <= 0){
				ready.SetActive(false);
				go.SetActive(false);
			}
			
		}
	}

	void OnGUI()
	{
		
		

	} 

}
