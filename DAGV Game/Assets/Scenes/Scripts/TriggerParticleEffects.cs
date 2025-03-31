using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffects : MonoBehaviour
{
    private ParticleSystem particleSystem; //Ref to the particle system
    public int firstEmissionAmt = 10;
    public int secondEmissionAmt = 20;
    public int thirdEmissionAmt = 30;
    public float delayBetweenEmissions = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") //check if player triggered event
        {
            StartCoroutine(EmitParticlesCoroutine());
        }
    }

    private IEnumerator EmitParticlesCoroutine()
    {
        particleSystem.Emit(firstEmissionAmt);
        yield return new WaitForSeconds(delayBetweenEmissions);
        particleSystem.Emit(secondEmissionAmt);
        yield return new WaitForSeconds(delayBetweenEmissions);
        particleSystem.Emit(thirdEmissionAmt);
        yield return new WaitForSeconds(delayBetweenEmissions);
    }
}
