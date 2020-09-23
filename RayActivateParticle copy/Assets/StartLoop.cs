using UnityEngine;
using System.Collections;

public class StartLoop : MonoBehaviour
{
    private ParticleSystem ps;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();

        var main = ps.main;
        main.loop = true ;
    }
}