using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTriggerExit : MonoBehaviour
{

ParticleSystem system;

private ParticleSystem ParticleSystem; 

public bool includeChildren = true;

// Update is called once per frame
void Update()
{

}

private void OnTriggerEnter(Collider other)
{
    RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.red);
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if(hit.collider.tag == "Particle")
    {
        
        if(system != null)
        {
            system.Play();
        }
    }
        }
}
private void OnTriggerExit(Collider other)
{
    RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.red);
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if(hit.collider.tag == "Particle")
    {
        
        if(system != null)
        {
            system.Stop();
        }
    }
        }
}

}