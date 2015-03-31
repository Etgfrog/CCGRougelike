using UnityEngine;
using System.Collections;

public class GameControler : MonoBehaviour {
	public int[][] Grid = new int[30][];
	public int Counter = 0;
	public Transform Cube;
	// Use this for initialization
	void Start () {
		for (int x = 0; x < Grid.Length; x++) {
			Grid[x] = new int[30];
			for (int y = 0; y < Grid.Length; y++) {
				Grid[x][y] = 0;
			}
		}
		string name = "test";
		name += Counter;
		var test = Instantiate (Cube);
		int posx = (int)Random.Range (0, 29);
		int posy = (int)Random.Range (0, 29);
		Grid [posx] [posy] = 1;
		Vector3 placement = new Vector3 (posx,1,posy);
		test.transform.position = placement;
		test.name = name;
	}
	
	// Update is called once per frame
	void Update () {
		var player = GameObject.Find ("Player");
		if (Input.GetKeyDown ("w")) {
			Vector3 Pos = player.transform.position;
			if(Grid[(int)Pos.x][(int)Pos.z+1] < 1){
				Pos.z += 1;
			}
			player.transform.position = Pos;
		}
		if (Input.GetKeyDown ("a")) {
			Vector3 Pos = player.transform.position;
			if(Grid[(int)Pos.x-1][(int)Pos.z] < 1){
				Pos.x -= 1;
			}
			player.transform.position = Pos;
		}
		if (Input.GetKeyDown ("s")) {
			Vector3 Pos = player.transform.position;
			if(Grid[(int)Pos.x][(int)Pos.z-1] < 1){
				Pos.z -= 1;
			}
			player.transform.position = Pos;
		}
		if (Input.GetKeyDown ("d")) {
			Vector3 Pos = player.transform.position;
			if(Grid[(int)Pos.x+1][(int)Pos.z] < 1){
				Pos.x += 1;
			}
			player.transform.position = Pos;
		}
	}
}
