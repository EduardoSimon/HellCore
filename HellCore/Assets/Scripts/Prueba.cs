using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Prueba : MonoBehaviour {

	[Inject]
	GameManager _gameManager;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		   _gameManager.pruebaInt += 1;
		Debug.Log(_gameManager.pruebaInt);
	}
}
