﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 左上向きの速度の設定
        this.GetComponent<Rigidbody>().velocity = new Vector3(-8.0f, 8.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
