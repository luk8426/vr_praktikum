using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Vector3 start_pos;
    public bool keyboard;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        start_pos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!keyboard) return;
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(x:moveHorizontal,y:0, z:moveVertical);
        movement = movement * speed;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement.x, movement.y, movement.z);
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Pick Up")){
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("DoNotHit"))     
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene( UnityEngine.SceneManagement.SceneManager.GetActiveScene().name );
            transform.position = start_pos;
        }
        
    }
}
