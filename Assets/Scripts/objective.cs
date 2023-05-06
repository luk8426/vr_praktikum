using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

////////////////////////////////////////////////////////////////////////////////////////////////////
//  Dieses Skript implementiert alles was mit den Missionen zusammenhängt
////////////////////////////////////////////////////////////////////////////////////////////////////

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
        // Sobald der Spieler die Säule betritt ...
        if (other.gameObject.CompareTag("Player")){
            // aktiviere die nächste Säule
            if (objective_deliver!=null) objective_deliver.SetActive(true);
            // aktiviere die Kiste
            if (box!=null) box.SetActive(true);
            // Beginne einen Tag/Nacht Wechsel
            if (daylight!=null) daylight.darken=true;
            // Spiele das AudioFile mit dem nächsten Auftrag
            radio_source.PlayOneShot(step_done);
            this.transform.position = new Vector3(-300, -300, -300);
            // Ändere die Farben der Partikel
            var main = particles.main;
            main.startColor = new Color(0, 255, 0);
        }
    }
}
