using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Casts a ray only and calls AutoTransparent to fade the objects
 * 
 * 
 */
public class ClearSight : MonoBehaviour {

    public GameObject rayCastObj;
    Vector3 playerOffset;
    Vector3 origin;
    Vector3 dir;
    public float DistanceToPlayer = 500.0f;

    private void Start()
    {
        //directionVector = transform.position - camera.transform.position;
    }
    void Update()
    {
        // you can also use CapsuleCastAll()
        // TODO: setup your layermask it improve performance and filter your hits.
        playerOffset = new Vector3(-0.1247f, 0.1f, -0.1247f); //The location to point to
        origin = this.transform.position;
        dir = rayCastObj.transform.position - origin;
        Debug.DrawRay(this.transform.position + playerOffset, dir, Color.blue, 0.01f, false);

        RaycastHit[] hits;
        hits = Physics.RaycastAll(this.transform.position + playerOffset, dir, DistanceToPlayer);
        foreach (RaycastHit hit in hits)
        {
            Renderer R = hit.collider.GetComponent<Renderer>();
            if (R == null)
                continue; // no renderer attached? go to next hit
                          // TODO: maybe implement here a check for GOs that should not be affected like the player

            AutoTransparent AT = R.GetComponent<AutoTransparent>();
            if (AT == null) // if no script is attached, attach one
            {
                AT = R.gameObject.AddComponent<AutoTransparent>();
            }
            AT.BeTransparent(); // get called every frame to reset the falloff
        }
    }
}
