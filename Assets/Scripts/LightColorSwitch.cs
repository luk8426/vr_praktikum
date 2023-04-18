using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightColorSwitch : MonoBehaviour
{
     public float r;
     public float g;
     public float b;
     private bool darken = false;

     public Material night_mat;

     public GameObject spotlight;
 
     public float smooth = 40;
     void Start(){
         this.GetComponent<Light>().color = new Color(r, g, b);
         spotlight.SetActive(false);
     }
     void Update(){
        if (Input.GetKey(KeyCode.N)){
            darken = true;
        } 
        if (darken){
            r -= Time.deltaTime/smooth;
            g -= Time.deltaTime/smooth;
            this.GetComponent<Light>().color = new Color (r, g, b);
            if (r <= 0) {
                r = 0;  
                RenderSettings.skybox=night_mat;
            }    
            if (g <= 0) {
                g = 0;    
            }
            if (b <= 0) {
                b = 0;    
            }
        }
        if (Input.GetButtonDown("Fire1")){
            if (spotlight.activeInHierarchy){
                spotlight.SetActive(false);
            }
            else spotlight.SetActive(true);
        }
     }
 }