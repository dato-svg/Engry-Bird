using UnityEngine;
using System.Collections;

public class ParallaxScrolling : MonoBehaviour 
{
	public float ParallaxFactor;

	private Vector3 previousCameraTransform;
	
	private Camera camera;
	
	private void Start () {
        camera = Camera.main;
        previousCameraTransform = camera.transform.position;
	}

	
	
	private void Update () {
        Vector3 delta = camera.transform.position - previousCameraTransform;
        delta.y = 0; delta.z = 0;
        transform.position += delta / ParallaxFactor;


        previousCameraTransform = camera.transform.position;
	}

	
}
