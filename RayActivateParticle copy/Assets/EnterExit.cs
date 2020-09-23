using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnterExit : MonoBehaviour
{
    public bool loop;
    private ParticleSystem ps;     
    private void Update()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.red);
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.tag == "Particle")
            {
               ps.loop = true;
            } else if(hit.collider.tag != "Particle")
                {
               
               ps.loop = false;
                }
            }
        }
    }
    