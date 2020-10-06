using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour
{
    //public GameObject pickupEffect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider player)
    {
        //For effects
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        //Make player bigger
        player.transform.localScale *= 1.5f;

        //Wait for some time
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(4);

        //Revert powerup effect
        player.transform.localScale /= 1.5f;
        Destroy(gameObject);
    }
}
