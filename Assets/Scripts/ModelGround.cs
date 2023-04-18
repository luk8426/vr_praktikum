using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelGround : MonoBehaviour
{
    public GameObject ground;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = ground.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
