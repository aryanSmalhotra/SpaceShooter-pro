using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour {
    [SerializeField]
    private float _speed = 3.5f; 
    [SerializeField]
    public GameObject _laserPrefab;
    private float _cooldown = 0.75f;
    private float _canfire = -1f;
    
      
     // Start is called before the first frame update
    void Start()
    {
        transform.position  = new Vector3(0,0,0);
        
    }

    // Update is called once per frame

    void Update() {
        CalculateMovement();
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > _canfire) {
            _canfire = Time.time+_cooldown;
            Instantiate(_laserPrefab, transform.position + new Vector3(0, 0.57f,0), Quaternion.identity );
            
        } 

    }
  
    void CalculateMovement()
    {
         float  horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right*horizontalInput*_speed*Time.deltaTime);
        transform.Translate(Vector3.up*verticalInput*_speed*Time.deltaTime);
        if(transform.position.y >= 6.3f){
            transform.position = new Vector3(transform.position.x,6.3f,0);
        }
        else if (transform.position.y <= -6.3f){
            transform.position = new Vector3(transform.position.x,-6.3f,0);

        }
        
        
        
        if(transform.position.x > 14.32f)
        {
            transform.position = new Vector3(-14.32f,transform.position.y,0);

        }
        else if (transform.position.x < -14.32f){
            transform.position = new Vector3(14.32f,transform.position.y,0);

        }
    }
    
}

   

