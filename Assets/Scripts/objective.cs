using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class objective : MonoBehaviour
{
    public GameObject objective_deliver;
    public GameObject box;
    public AudioSource radio_source; 
    public AudioClip step_done;
    public LightColorSwitch daylight;
    public ParticleSystem particles;
    // Start is called before the first frame update
    void Start()
    {
        if (objective_deliver!=null) objective_deliver.SetActive(false);
        if (box!=null) box.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            if (objective_deliver!=null) objective_deliver.SetActive(true);
            if (box!=null) box.SetActive(true);
            if (daylight!=null) daylight.darken=true;
            radio_source.PlayOneShot(step_done);
            this.transform.position = new Vector3(-300, -300, -300);
            var main = particles.main;
            main.startColor = new Color(0, 255, 0);
        }
    }
}
