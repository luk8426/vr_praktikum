using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horizontanzeige : MonoBehaviour
{
    public GameObject ground;
    public bool isVertical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = ground.transform.rotation.eulerAngles;
        if (isVertical) rot.y = transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Euler(rot.x, rot.y, rot.z);
    }
}
