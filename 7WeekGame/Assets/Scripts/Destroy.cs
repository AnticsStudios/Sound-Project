﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    // Use this for initialization

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Delete")
        {
            Destroy(this.gameObject);
        }
    }


}