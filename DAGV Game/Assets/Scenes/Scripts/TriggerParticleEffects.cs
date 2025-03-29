using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffects : MonoBehaviour
{
    private ParticleSystem particleSystem; //Ref to the particle system
    public int particleAmount = 10; //Exposed variable for particle amt
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") //check if player triggered event
        {
            particleSystem.Emit(particleAmount); //emit specified amt of particles
        }
    }
}
