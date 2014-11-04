﻿using UnityEngine;
using System.Collections;

public class Banana : Monster 
{
    public BananaPeel bananaPeel;
    private int peelCount = 1;
    // Use this for initialization
    protected override void Start()
    {
        base.Start();
    }
    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
    public void DropPeel()
    {
        //ToDo
        if (peelCount > 0)
        {
            //Vector3 position = new Vector3(transform.position.x, transform.position.y - (EUtils.GetObjectCollUnitSize(gameObject).y / 2), transform.position.z);//transform.position;
            Vector3 position = transform.position;
            position.y = position.y - (EUtils.GetObjectCollUnitSize(gameObject).y / 2) - EUtils.GetObjectCollUnitSize(bananaPeel.gameObject).y -1;
            GameObject clone = GameObject.Instantiate(bananaPeel, position, transform.rotation) as GameObject;//Drop peel
            //Physics.IgnoreCollision(gameObject.collider, clone.collider);
            peelCount--;
        }
    }
    protected override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
    }
}
