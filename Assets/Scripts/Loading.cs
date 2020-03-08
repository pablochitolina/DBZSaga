using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour {
	

	IEnumerator Start() {
		Screen.fullScreen = true;
		AsyncOperation async = Application.LoadLevelAsync("Lutas");
		yield return async;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
