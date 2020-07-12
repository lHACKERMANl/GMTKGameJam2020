using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorScript : MonoBehaviour
{
    public Transform prefab;    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            Instantiate(prefab, new Vector3(1425.18f,415f,52.1f), Quaternion.identity);

        }
    }
}
