﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour {
   
    void Update () 
    {
        transform.Rotate (new Vector3 (0, 0, 45) * Time.deltaTime);
    }
}
