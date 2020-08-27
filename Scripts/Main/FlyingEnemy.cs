using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingEnemy : MonoBehaviour
{
    public ProgressBar score;
    public int health = 2;
    public int damage = 1;
    public ParticleSystem explosion;
    public GameObject fragment1;
    public GameObject fragment2;
    public GameObject fragment3;
    public float fragmentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("ARSessionOrigin").GetComponent<ProgressBar>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage()
    {
        health--;

        if (health == 0)
        {
            score.UpdateScore(2);
            Explode(transform.position);
            fragmentSpread(transform.position);

            Destroy(gameObject);

        }
    }

    public void Explode(Vector3 position)
    {
        Instantiate(explosion, position, Quaternion.identity);
    }

    public void fragmentSpread(Vector3 position)
    {
        Instantiate(fragment1, position, Quaternion.identity);
        Instantiate(fragment2, position, Quaternion.identity);
        Instantiate(fragment3, position, Quaternion.identity);


    }


}
