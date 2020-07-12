using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectBetweenWallScript : MonoBehaviour{
    private float startPosY,startPosX, startPosYForConnected;
    public GameObject connectTo;

    private bool isBeginHeld = false;
    void Update() {
        if(isBeginHeld){
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(this.transform.localPosition.x, mousePos.y-startPosY, 0);
            connectTo.gameObject.transform.localPosition = new Vector3(connectTo.transform.localPosition.x, mousePos.y-startPosYForConnected, 0);
        }
    }

    private void OnMouseDown(){
        if(Input.GetMouseButtonDown(0)){     
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosY = mousePos.y - this.transform.localPosition.y;
            startPosYForConnected = mousePos.y - connectTo.transform.localPosition.y;

            isBeginHeld = true;
        }
    }

    private void OnMouseUp(){
        isBeginHeld = false;
    }

     private void OnCollisionEnter2D(Collision2D other) {
        isBeginHeld = false;
        Debug.Log(isBeginHeld);
    }
}
