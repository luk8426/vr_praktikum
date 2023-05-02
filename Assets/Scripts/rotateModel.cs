using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateModel : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localRotation = player.transform.rotation;
        Vector3 newAngles = this.transform.localEulerAngles;
        this.transform.localRotation = Quaternion.Euler(newAngles.x, 0, newAngles.z);
    }
}
