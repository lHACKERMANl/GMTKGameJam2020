using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointScript : MonoBehaviour
{
    private bool isChecked = false;
    private GameMasterScript gm;
    private Animator anim;

    void Start(){
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMasterScript>();
        anim = GetComponent<Animator>();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(isChecked){
            anim.Play("AwakeAnimation");
        }else{
            anim.Play("SleepAnimation");
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            isChecked = true;
            gm.lastCheckPointPos = transform.position;
        }
    }
}
