﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour {

    public float deleteTime = 4.0f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, deleteTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
