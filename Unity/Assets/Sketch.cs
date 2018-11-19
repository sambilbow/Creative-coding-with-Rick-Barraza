using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

	public GameObject selectedPrefab;

	void Start () {
		
		float totalCubes = 28f;
		
		float totalDistance = 2.9f;
		
		//SIN DISTRO
		for(int i = 0; i < totalCubes; i++)
		{
			float perc = i/totalCubes;
			
			float sin = Mathf.Sin(perc * Mathf.PI/2f);

			float x = 1f + sin * totalDistance;
			float y = 5.0f;
			float z = 0.0f;
			
			var newCube = (GameObject)Instantiate(selectedPrefab, new Vector3(x, y, z), Quaternion.identity);

			newCube.GetComponent<CubeScript>().setSize(.4f * (1f-perc));
			newCube.GetComponent<CubeScript>().rotateSpeed = .2f + perc*4.0f;
		
		}
	

	}
	
	void Update () {
		
	}
}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

	// Public field for future specified gameobject called "selectedPrefab"
	public GameObject selectedPrefab;

	// Use this for initialization
	void Start () {
		
		float totalCubes = 8f;
		int totalDistance = 5;


		for(int i = 1; i < totalCubes; i++)
		{
		
		
			// Defining variables for later use in the position of our instantiated prefab.	
			
			// Inside the loop, we are making sure that no cubes go past the boundaries by distributing them with this formula. (Fraction Number of Cubes/Total Distance)
			float perc = i/totalCubes;
			float x = perc * totalDistance;
			float y = 5.0f;
			float z = 0.0f;
				
			// Once specified gameobject is added to field, creates prefab with position and rotation values.
			// Treat like GameObject (casting), which allows later code to work like newcube.GetComponent (which only works on GameObjects)	
			
			var newCube = (GameObject)Instantiate(selectedPrefab, new Vector3(x, y, z), Quaternion.identity);

			// Working with the prefabs public variables
			// The farther away they are  the smaller they get, the farther away they are the faster they get.
			newCube.GetComponent<CubeScript>().setSize(1f-perc);
			newCube.GetComponent<CubeScript>().rotateSpeed = (perc);
		
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
 */
