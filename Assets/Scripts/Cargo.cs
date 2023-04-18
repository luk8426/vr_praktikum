using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cargo : MonoBehaviour
{
    private MeshRenderer render;
    private Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = this.transform.position;
        render = gameObject.GetComponentInChildren<MeshRenderer>();
 
        render.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2")){
            this.GetComponent<Rigidbody>().useGravity = true;
        }


    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("target")){
            UnityEngine.SceneManagement.SceneManager.LoadScene( UnityEngine.SceneManagement.SceneManager.GetActiveScene().name );
        }
        
    }
}
