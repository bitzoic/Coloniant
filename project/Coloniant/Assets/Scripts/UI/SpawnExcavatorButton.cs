﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnExcavatorButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnButton()
    {
        QueenAnt.main.AddAntToSpawn(QueenAnt.Ants.EXCAVATOR, 1);
    }
}