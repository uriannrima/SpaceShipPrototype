﻿using UnityEngine;
using System.Collections;

public class TargetController : MonoBehaviour
{
    public Transform Target;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Target)
        {
            this.transform.position = Target.position;
        }       
    }
}
