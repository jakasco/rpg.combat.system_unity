using UnityEngine;
using System.Collections;

public class MaaGrid : MonoBehaviour {

	public Transform CellPhefab;
	public Vector3 size;
	public Transform[,] Grid1;
	private Transform newCell;

	void Start () {
		
		CreateLand ();
		
	}
	
	
	void CreateLand() {
		
		float kokoX = CellPhefab.localScale.x;
		float kokoY = CellPhefab.localScale.y;
		
		Grid1 = new Transform[(int)size.x, (int)size.z];
		for (float x=0; x <size.x; x++) {
			for (float z=0; z < size.z; z++) {
				
				newCell = (Transform)Instantiate (CellPhefab, new Vector3 (x, 0, z), Quaternion.identity);
				newCell.name = string.Format ("({0}),0,({1})", x, z);
				newCell.parent = transform;
				newCell.GetComponent<Solu>().position = new Vector3(x,0,z);
				Grid1 [(int)x, (int)z] = newCell;
				
				
			}
			
			
		}
	}

	}