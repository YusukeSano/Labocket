using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BTB : MonoBehaviour
{
	public GameObject target;

	void Start()
	{
		this.transform.localScale = new Vector3(-1, 1, 1);
	}

	void Update()
	{
		this.transform.LookAt(Camera.main.transform);
		Vector3 tmp = target.transform.position;
		this.transform.position = new Vector3(tmp.x, tmp.y+0.3f, tmp.z);
	}
}