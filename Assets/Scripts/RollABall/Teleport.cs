using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject jump_2_board;
    public GameObject player;
    public GameObject vr;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
    if (other.gameObject.CompareTag("Player")){
        Vector3 newpos = jump_2_board.transform.position;
        Vector3 new_vr_pos = newpos;
        new_vr_pos.y -= 1;
        new_vr_pos.z -= 1;
        newpos.y+=1;
        vr.transform.position = new_vr_pos;
        
        other.gameObject.SetActive(false);
        player.transform.position = newpos;
        other.gameObject.SetActive(true);
    }
    }
}
