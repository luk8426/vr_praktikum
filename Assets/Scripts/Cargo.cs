using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cargo : MonoBehaviour
{
    //public MeshRenderer render;
    public Rigidbody c_rigidbody;
    private Vector3 position;
    public bool button_pressed = false;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        //render.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K)||Input.GetButtonDown("Fire2")||button_pressed){
            c_rigidbody.isKinematic = false;
            button_pressed = false;
        }


    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("target")){
            //c_rigidbody.useGravity = false;
            c_rigidbody.isKinematic = true;
            //this.transform.position = position;
            //UnityEngine.SceneManagement.SceneManager.LoadScene( UnityEngine.SceneManagement.SceneManager.GetActiveScene().name );
        }
        else{
            if (other!=null){
                c_rigidbody.isKinematic = true;
                this.transform.position = position;
            }
        }
        
    }
}
