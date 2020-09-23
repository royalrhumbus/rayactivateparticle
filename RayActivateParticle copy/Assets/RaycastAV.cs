using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RaycastAV : MonoBehaviour
{
    public AudioClip Christina1;
    public AudioClip Christina2;
    public AudioClip Christina3;
    public AudioClip Christina4;
    public AudioClip Christina5;
    public AudioClip Christina6;
    public AudioClip Christina7;
    public AudioClip Christina8;
    AudioSource dlaySound;
    public ParticleSystem particletrial; 
    private ParticleSystem ps; 
    private bool main; 

    void Start()
    {
        dlaySound = GetComponent<AudioSource>();
    }
    

    private void Update()
    {
        RaycastHit hit;
        float TheDistace;

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {

            TheDistace = hit.distance;
            print(TheDistace + "  " + hit.collider.gameObject.name);

            if (hit.collider.tag == "ToggleV")
            {

                ToggleRenderer toggleRend = hit.collider.gameObject.GetComponent<ToggleRenderer>();

                if (toggleRend != null)
                    toggleRend.Toggle(true);

            }
            
            if (hit.collider.tag == "Particle")
            {
                hit.transform.GetComponent<ParticleSystem>().Play();
                //main = GetComponent<ParticleSystem.main.loop>(); 
                //main = true; 
            } /*else {
                var main = ps.main;
                main.loop = false; 
            } */
            

            if (hit.collider.tag == "TargetAVTrigger1")
            {
                if (!dlaySound.isPlaying)
                {

                    dlaySound.clip = Christina1;
                    dlaySound.Play();
                    
                }
                ToggleRenderer toggleRend = hit.collider.gameObject.GetComponent<ToggleRenderer>();

                if (toggleRend != null)
                    toggleRend.Toggle(true);

            }
            if (hit.collider.tag == "TargetAVTrigger2")
            {
                if (!dlaySound.isPlaying)
                {
                    dlaySound.clip = Christina2;
                    dlaySound.Play();
                   
                }
                ToggleRenderer toggleRend = hit.collider.gameObject.GetComponent<ToggleRenderer>();

                if (toggleRend != null)
                    toggleRend.Toggle(true);

            }
            if (hit.collider.tag == "TargetAVTrigger3")
            {
                if (!dlaySound.isPlaying)
                {
                    dlaySound.clip = Christina3;
                    dlaySound.Play();

                }
                ToggleRenderer toggleRend = hit.collider.gameObject.GetComponent<ToggleRenderer>();

                if (toggleRend != null)
                    toggleRend.Toggle(true);

            }
            if (hit.collider.tag == "TargetAVTrigger4")
            {
                if (!dlaySound.isPlaying)
                {
                    dlaySound.clip = Christina4;
                    dlaySound.Play();

                }
                ToggleRenderer toggleRend = hit.collider.gameObject.GetComponent<ToggleRenderer>();

                if (toggleRend != null)
                    toggleRend.Toggle(true);

            }
            if (hit.collider.tag == "ImageAVTrigger1")
            {
                if (!dlaySound.isPlaying)
                {
                    dlaySound.clip = Christina5;
                    dlaySound.Play();

                }
                ToggleRenderer toggleRend = hit.collider.gameObject.GetComponent<ToggleRenderer>();

                if (toggleRend != null)
                    toggleRend.Toggle(true);

            }
            if (hit.collider.tag == "ImageAVTrigger2")
            {
                if (!dlaySound.isPlaying)
                {
                    dlaySound.clip = Christina6;
                    dlaySound.Play();

                }
                ToggleRenderer toggleRend = hit.collider.gameObject.GetComponent<ToggleRenderer>();

                if (toggleRend != null)
                    toggleRend.Toggle(true);

            }
            if (hit.collider.tag == "ImageAVTrigger3")
            {
                if (!dlaySound.isPlaying)
                {
                    dlaySound.clip = Christina7;
                    dlaySound.Play();

                }
                ToggleRenderer toggleRend = hit.collider.gameObject.GetComponent<ToggleRenderer>();

                if (toggleRend != null)
                    toggleRend.Toggle(true);

            }
            if (hit.collider.tag == "ImageAVTrigger4")
            {
                if (!dlaySound.isPlaying)
                {
                    dlaySound.clip = Christina8;
                    dlaySound.Play();

                }
                ToggleRenderer toggleRend = hit.collider.gameObject.GetComponent<ToggleRenderer>();

                if (toggleRend != null)
                    toggleRend.Toggle(true);

            }
        }

    }
}
