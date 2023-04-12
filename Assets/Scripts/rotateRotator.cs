using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateRotator : MonoBehaviour
{
    public float speed;
    public string rotate_axis;
    private Vector3 rotate_axis_vector;
    // Start is called before the first frame update
    void Start()
    {
        if (rotate_axis.Equals("x")){
            rotate_axis_vector = new Vector3(1, 0, 0);
        }
        else if (rotate_axis.Equals("y")){
            rotate_axis_vector = new Vector3(0, 1, 0);
        }
        else if (rotate_axis.Equals("z")){
            rotate_axis_vector = new Vector3(0, 0, 1);
        }
        else{
            rotate_axis_vector = new Vector3(0, 0, 0);
        }
    }
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotate_axis_vector * speed * Time.deltaTime);

    }
}
