using UnityEngine;
using System.Collections;

public class Combinder : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		Element eW = new Water();
		eW.Effect();
		Element eE = new Earth();
		eE.Triel();
		Element eWE = new Water();
		Element eEW = new Earth();
		Element eL = new Lighting();
		Element eF = new Fire();
		Element eI = new Ice();
		Element eB = new Block();


	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
