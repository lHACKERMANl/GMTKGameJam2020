﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitScript : MonoBehaviour
{
	private Button quitButton; 
    // Start is called before the first frame update
    void Start()
    {
        quitButton = GetComponent<Button>();
	quitButton.onClick.AddListener(QuitGame);
    }

    // Update is called once per frame
    private void QuitGame()
    {
        Application.Quit();
    }
}
