using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down* _speed *Time.deltaTime);
        if(transform.position.y < -11.6f){
            transform.position = new Vector3(Random.Range(-10,10f),11,0);
        }

        
    }

}
