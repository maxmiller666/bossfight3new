using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnConveyer : MonoBehaviour
{
    // A flag to track whether the object is on a conveyor
    private int num;
    private bool turn = false;
    public ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("conveyer"))
        {
            if (collision.transform.eulerAngles.z == 0)   {
                transform.Translate(Vector2.right * Time.deltaTime);
            }
            if (collision.transform.eulerAngles.z == 90)
            {
                transform.Translate(Vector2.up * Time.deltaTime);
            }
            if (collision.transform.eulerAngles.z == 180)
            {
                transform.Translate(Vector2.left * Time.deltaTime);
            }
            if (collision.transform.eulerAngles.z == 270)
            {
                transform.Translate(Vector2.down * Time.deltaTime);
            }

        }
        if (collision.gameObject.CompareTag("c1"))
        {
            if (num == 1)
            {
                if (collision.transform.eulerAngles.z == 0)
                {
                    transform.Translate(Vector2.up * Time.deltaTime);
                }
                if (collision.transform.eulerAngles.z == 90)
                {
                    transform.Translate(Vector2.left * Time.deltaTime);
                }
                if (collision.transform.eulerAngles.z == 180)
                {
                    transform.Translate(Vector2.down * Time.deltaTime);
                }
                if (collision.transform.eulerAngles.z == 270)
                {
                    transform.Translate(Vector2.left * Time.deltaTime);
                }
            }
        }



    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("conveyer"))
        {
            num += 1;
            Debug.Log(num + " Enter " + other);
        }
        if (other.gameObject.CompareTag("c1"))
        {
            turn = true;
            num += 1;
            Debug.Log(num + " Enter " + other);
        }
        if (other.gameObject.CompareTag("seller"))
        {
            TriggerBurst();
            Destroy(gameObject, 0.3f);
        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("conveyer"))
        {

            num -= 1;
            Debug.Log(num+"Exit "+ collision);
        }
        if (collision.gameObject.CompareTag("c1"))
        {
            turn = false;
            num -= 1;
            Debug.Log(num + " Exit " + collision);
        }
        if (num == 0 && !turn)
        {
            Debug.Log("death");
            Destroy(gameObject, 0.3f);
        }
    }

    public void TriggerBurst()
    {
        var emission = particleSystem.emission;
        var emissionModule = emission;

        // Enable the Emission module to start generating particles.
        emissionModule.enabled = true;

        // Set the burst count and time.
        // You can customize these values to control the burst.
        int burstCount = 10; // Number of particles in the burst.
        float burstTime = 1.0f; // Time in seconds to trigger the burst.

        // Create a burst by adding new elements to the bursts list.
        var bursts = new List<ParticleSystem.Burst>();
        bursts.Add(new ParticleSystem.Burst(0, burstCount));
        emissionModule.SetBursts(bursts.ToArray());

        // Start a coroutine to disable the Emission module after the burst time.
        StartCoroutine(DisableEmissionAfter(burstTime));
    }

    IEnumerator DisableEmissionAfter(float time)
    {
        yield return new WaitForSeconds(time);

        // Disable the Emission module to stop generating particles.
        particleSystem.emission.enabled = false;
    }
}