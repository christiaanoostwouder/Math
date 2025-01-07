using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFlameController : MonoBehaviour
{
    public ParticleSystem flameEffect;
    public RocketControl rocket;

    private ParticleSystem.EmissionModule emission;
    void Start()
    {
        emission = flameEffect.emission;
    }

   
    void Update()
    {
        emission.rateOverTime = rocket.currentThrust * 10;

        var main = flameEffect.main;
        main.startSize = rocket.currentThrust > 0 ? 0.1f + rocket.currentThrust / rocket.maxThrust : 0;
    }
}
