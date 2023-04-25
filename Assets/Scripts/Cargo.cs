using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cargo : MonoBehaviour
{
    //public MeshRenderer render;
    public Rigidbody c_rigidbody;
    private Vector3 at_heli_position;
    public bool button_pressed = false;
    public Transform heli;
    // Start is called before the first frame update
    void Start()
    {
        heli = this.transform.parent;
        at_heli_position = this.transform.localPosition;
        //render.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.K)||Input.GetButtonDown("Fire2")||button_pressed){
            c_rigidbody.isKinematic = false;
            button_pressed = false;
            transform.SetParent(null);
        }


    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("target")){
            c_rigidbody.isKinematic = true;
        }
        else{
            if (other!=null){
                c_rigidbody.isKinematic = true;
                transform.SetParent(heli);
                this.transform.localPosition = at_heli_position;
            }
        }
        
    }
}
