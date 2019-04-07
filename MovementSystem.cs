using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : MonoBehaviour {

    //public GameObject groundDetector;

    private CollisionFlags m_CollisionFlags;
    private bool walking = false;
    public float speed;
    public float lowestpointonmap;

    private Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
        spawnPoint = transform.position;
	}

    // Update is called once per frame
    void Update()
    {
        if (walking)
        {
            transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;
        }

        if (transform.position.y < -10f)
        {
            transform.position = spawnPoint;
            Debug.Log("respawning...");
        }

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(.5f, .5f, 0));
        RaycastHit hit;

        if (Input.GetMouseButton(0))
        {
            walking = true;
            Debug.Log("running");
        }
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.name.Contains("plane"))
            {
                walking = false;
                Debug.Log("looking at plane and not walking");
            }

            Debug.Log("hit something");

        }


    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        //dont move the rigidbody if the character is on top of it
        if (m_CollisionFlags == CollisionFlags.Below)
        {
            return;
        }

        if (body == null || body.isKinematic)
        {
            return;
        }
        //body.AddForceAtPosition(m_CharacterController.velocity * 0.1f, hit.point, ForceMode.Impulse);
    }
}
