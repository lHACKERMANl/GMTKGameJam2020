using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 45f;
    public static bool isAlive = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(isAlive){
            rb.MovePosition(transform.position + transform.right * Time.fixedDeltaTime * speed);
        }
        else{
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Enemy"){
            isAlive = false;
        }
    }
}
