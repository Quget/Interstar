﻿using UnityEngine;
using System.Collections;

public class Defendable : MonoBehaviour 
{
    public float health = 100;
	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
    public void DoDamage(float pain)
    {
        health -= pain;
    }
}