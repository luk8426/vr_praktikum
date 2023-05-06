using System.Collections;
using System.Collections.Generic;
using UnityEngine;

////////////////////////////////////////////////////////////////////////////////////////
//  Dieses Skript implementiert das Steuern des Helikopters mit den Tasten WASD
////////////////////////////////////////////////////////////////////////////////////////

public class Fly : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public GameObject speed_button;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (speed_button!=null)speed = speed_button.transform.position.y * 10;
        if (Input.GetKey(KeyCode.W)){
            this.transform.Translate (Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)){
            this.transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime);
            this.transform.Translate (Vector3.left * (speed/5) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)){
            this.transform.Translate (Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)){
            this.transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime);
            this.transform.Translate (Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q)){
            this.transform.Translate (Vector3.down * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E)){
            this.transform.Translate (Vector3.up * speed * Time.deltaTime);
        }
    }
}
