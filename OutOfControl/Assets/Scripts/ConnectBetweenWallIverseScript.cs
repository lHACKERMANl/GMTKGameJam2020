using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectBetweenWallIverseScript : MonoBehaviour
{
    private float startPosX, startPosXForConnected;
    public GameObject connectTo;

    private bool isBeginHeld = false;
    void Update() {
        if(isBeginHeld){
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x-startPosX, this.transform.localPosition.y, 0);
            connectTo.gameObject.transform.localPosition = new Vector3(mousePos.x-startPosXForConnected, connectTo.transform.localPosition.y, 0);
        }
    }

    private void OnMouseDown(){
        if(Input.GetMouseButtonDown(0)){     
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosXForConnected = mousePos.x - connectTo.transform.localPosition.x;

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
