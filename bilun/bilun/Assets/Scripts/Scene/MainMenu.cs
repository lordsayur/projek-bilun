﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {
    
    private Animator anim;

    private void Start() {
        anim = GetComponent<Animator>();

    }

    public void StartGame() {
        anim.SetBool("StartGame", true);

    }

    public void ExitGame() {
        Application.Quit();
    }

}
