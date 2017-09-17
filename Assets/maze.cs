using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maze : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[,] maze = new int[21, 33];
		int x;
		int y;
		for (x = 0; x < 21; x++) {
			for (y = 0; y < 33; y++) {
				maze [x, y] = 0;
			}
		}
		Debug.Log (maze [5, 6]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
