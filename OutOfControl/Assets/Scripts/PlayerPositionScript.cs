using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPositionScript : MonoBehaviour
{
      private GameMasterScript gm;

      void Start(){
          gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMasterScript>();
          transform.position = gm.lastCheckPointPos;
      }

      void Update()
      {
          if(!HeroMoveScript.isAlive/*Input.GetKey("up")*/){
              SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
          }
      }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Enemy"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
