using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	//การหมุนกล้อง
	void Update () 
	{
		this.transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}	