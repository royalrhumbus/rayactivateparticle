using UnityEngine;
using System.Collections;
 
public class StartStopParticleSystem : MonoBehaviour {
 
        public ParticleSystem particle;
        public float Distance;
        public bool Done = true;
    RaycastHit hit;
 //Only functions with ParticleSystems>MainModule>Prewarm selected
 //ParticleSystem must have box collider with "Trigger" activated
    void Update()
        {
            RaycastHit hit;
                Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
                Debug.DrawRay(transform.position, forward, Color.red);
                if (Physics.Raycast(transform.position, transform.forward, out hit))
                {
                     if(hit.collider.tag == "Particle"){
                    Done = false;
                    StartParticle();
                    }
                }else if(Done == false){
                OnExit();
                }
        }
 
    void StartParticle ()
    {
    particle.Play(true);
    }
    void OnExit ()
    {
    Done = true ;
    particle.Stop(false );
    }
}
 
 