using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///////////////////////////////////////////////////////////////////////
//  Dieses Skript implementiert die rollenden Säulen im Level Extreme 
///////////////////////////////////////////////////////////////////////

public class Rolling : MonoBehaviour
{
    private Vector3 start_pos;
    private int direction = -1;
    // Start is called before the first frame update
    void Start()
    {
        start_pos = transform.position;
        transform.Translate(new Vector3((float) 0.4*direction, 0, 0) * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (start_pos.x - transform.position.x < 1 && start_pos.x - transform.position.x > 0) {
            transform.Translate(new Vector3((float) 0.3*direction, 0, 0) * Time.deltaTime);
        }
        else{
            // Sobald die Säulen das Brett verlassen dreht sich die deren Bewegungsrichtung um, und die Größe wird innerhalb der Grenzen zufällig neu bestimmt 
            direction = direction * -1;
            transform.localScale = new Vector3(1, (float)(new System.Random().NextDouble()*1.2)+1 ,1);
            transform.Translate(new Vector3((float) 0.6*direction, 0, 0) * Time.deltaTime);        }
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            // Funktionalität im Player implementiert
        }
    }
}
