﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Reg_Script : MonoBehaviour {

    public Button button;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        button.GetComponentInChildren<Text>().text = "Новый текст";
    }
}
