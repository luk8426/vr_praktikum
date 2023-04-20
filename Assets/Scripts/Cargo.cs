using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cargo : MonoBehaviour
{
    //public MeshRenderer render;
    public Rigidbody c_rigidbody;
    private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        //render.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.K)){
        //if (Input.GetButtonDown("Fire2")){
            //render.enabled = true;
            c_rigidbody.useGravity = true;
        }


    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("target")){
            UnityEngine.SceneManagement.SceneManager.LoadScene( UnityEngine.SceneManagement.SceneManager.GetActiveScene().name );
        }
        
    }
}
