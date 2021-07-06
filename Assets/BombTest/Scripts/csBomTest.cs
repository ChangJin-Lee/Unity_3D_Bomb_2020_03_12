using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csBomTest : MonoBehaviour
{

    public GameObject explosionParticlesPrefab;

    // Start is called before the first frame update
    void Start()
    {
        float randomX = UnityEngine.Random.Range(10f, 100f);
        float randomY = UnityEngine.Random.Range(10f, 100f);
        float randomZ = UnityEngine.Random.Range(10f, 100f);

        Rigidbody bomb = GetComponent<Rigidbody>();

        bomb.AddTorque(randomX, randomY, randomZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (explosionParticlesPrefab)
        {
            GameObject explosion = (GameObject)Instantiate(explosionParticlesPrefab, transform.position, transform.rotation);
            Destroy(explosion, explosion.GetComponent<ParticleSystem>().main.startLifetime.constant);

            Destroy(gameObject);
        }
    }
}
