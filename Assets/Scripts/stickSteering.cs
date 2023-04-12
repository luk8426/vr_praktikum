using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickSteering : MonoBehaviour
{
    public GameObject player;
    public float speed;
    private Vector3 neutral_rotation;

    // Start is called before the first frame update
    void Start()
    {
        neutral_rotation = transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.rotation.eulerAngles.x - neutral_rotation.x) > 0){
            player.transform.Translate (Vector3.forward * speed * Time.deltaTime);
        }
        if ((transform.rotation.eulerAngles.z - neutral_rotation.z) > (-4)){
            player.transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime);
            player.transform.Translate (Vector3.left * (speed/5) * Time.deltaTime);
        }
        if ((transform.rotation.eulerAngles.x - neutral_rotation.x) < (-4)){
            player.transform.Translate (Vector3.back * speed * Time.deltaTime);
        }
        if ((transform.rotation.eulerAngles.z - neutral_rotation.z) < (-8)){
            player.transform.Rotate(new Vector3(0, 0, -1) * Time.deltaTime);
            player.transform.Translate (Vector3.right * speed * Time.deltaTime);
        }
    }
}
