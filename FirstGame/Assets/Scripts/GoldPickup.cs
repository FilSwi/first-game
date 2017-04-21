using UnityEngine;
using System.Collections;

public class GoldPickup : MonoBehaviour
{
    public Transform goldParticle;

	void OnTriggerEnter(Collider info)
    {
        if(info.tag=="Player")
        {
            Transform particle=(Transform)Instantiate(goldParticle, transform.position, transform.rotation);
            Destroy(particle.gameObject,6);
            Destroy(gameObject);
        }
    }
}
