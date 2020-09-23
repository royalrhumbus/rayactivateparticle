 
    
    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleaseNoMore : MonoBehaviour
{
private ParticleSystem ps;                  // Variable to refer to your particle system
 
    void Start()
    {
        ps = GetComponent<ParticleSystem>();    // Get the particle system on your GameObject once
        var emission = GetComponent<ParticleSystem.EmissionModule>();                 // Get the current emission module
        Debug.Log(emission.GetType().FullName);
        emission.enabled = false;                   // Set the emission module to disabled at start
    }
 
    void Update()
    {
        if (Input.GetButtonDown("Up")){       // The one frame when you press the jump key, turn it on
            var emission = GetComponent<ParticleSystem.EmissionModule>();             // Get the current emission module
            emission.enabled = true;                // Set the emission module to enabled
        }                                      
        if (Input.GetButtonUp("Down")){         // The one frame when you let go of the jump key, turn it off
            var emission = GetComponent<ParticleSystem.EmissionModule>();             // Get the current emission module
            emission.enabled = false;               // Set the emission module to disabled
        }
    }
}