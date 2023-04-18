using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePlayer : MonoBehaviour
{
    public GameObject player;
    public float distance;

    private float offset = 0.5F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position + distance * player.transform.forward - offset * player.transform.up;//new Vector3(0, offset, 0);
        this.transform.rotation = player.transform.rotation;
        //this.transform.Rotate(0, 6, 0);
    }
}
