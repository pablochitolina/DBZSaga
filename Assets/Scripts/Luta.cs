using UnityEngine;
using System.Collections;

public class Luta : MonoBehaviour {

	public GameObject jogador;
	private Transform lutador;
	private Animator animator;
	

	// Use this for initialization
	void Start () {
		lutador = jogador.GetComponent<Transform> ();
		animator = lutador.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		animator.SetTrigger("parar");
	
	}
	void OnGUI()
	{
		if(GUI.Button(new Rect(0, 0, 100, 100), "Chute!")){
			int num = Random.Range(1, 3);
			if(num ==1){
				animator.Play("chute1");
			}else if(num ==2 ){
				animator.Play("chute2");
			}
		}
	}
}
