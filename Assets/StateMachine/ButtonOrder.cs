﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOrder : MonoBehaviour {

    public GameObject enemy;

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

    public void Order()
    {
            enemy.GetComponent<StatePatternEnemy>().patrolState.Order();
    }
}
