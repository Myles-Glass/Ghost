using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastFollow : MonoBehaviour {
    public Transform player;
    private Vector3 offset;
    // Use this for initialization
    void Start () {
        offset = new Vector3(-12.2474f, 10f, -12.2474f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.SetPositionAndRotation(player.position + offset, transform.rotation);
    }
}
