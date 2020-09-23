using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LoopPlay : MonoBehaviour
{
    public ParticleSystem particlestartstop; 
    
    private ParticleSystem ps;
    private bool LoopItBaby; 
    //private bool main; 

    void Start()
    {
        ps = GetComponent<ParticleSystem>();

        var main = ps.main;
        main.loop = true;
    }
    
    private void Update()
    {
        RaycastHit hit;
        float TheDistace;

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {

            if (hit.collider.tag == "Particle")
                {
                 hit.transform.GetComponent<ParticleSystem>().Play();
                    //LoopItBaby = GetComponent<ParticleSystem.MainModule.loop>(); 
                    //LoopItBaby = true; 
                } /*else {
                var main = ps.main;
                main.loop = false; */
                else{
                    particlestartstop.Clear(); 
                }
        }
    }
}