    using UnityEngine;
    using System.Collections;
                public class NitrousTrailScript : MonoBehaviour 
                {
                    public ParticleSystem Party;
                    //CarController cc;
                    void Update()
                    {
                        ParticleSystem ps = GetComponent<ParticleSystem>();
                        //CarController.nitrousActive == true
                        RaycastHit hit;
                        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
                        Debug.DrawRay(transform.position, forward, Color.red);
                        if (Physics.Raycast(transform.position, transform.forward, out hit))
                        {
                            if (hit.collider.tag == "Particle")
                                {
                                    if (!ps.isPlaying)
                                    {
                                        ps.Play();
                                        ps.loop = true;
                                    }
                                else {
                                    if(ps.isPlaying)
                                    {
                                        ps.Stop();
                                        ps.loop = false;
                                    }
                                }
                        }
                    }
                }
                }