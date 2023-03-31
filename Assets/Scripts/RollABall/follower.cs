using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follower : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (System.Math.Abs(Player.transform.position.x - transform.position.x) <= 1){
            Vector3 direction = new Vector3(Player.transform.position.x - transform.position.x, Player.transform.position.y - transform.position.y, Player.transform.position.z - transform.position.z);
            direction.Normalize();
            transform.position = transform.position + (direction / 300);
        }
    }
}
