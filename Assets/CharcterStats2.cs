using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcterStats2 : MonoBehaviour {

	public int health = 300;
	public bool isStunned;
	public int stamina = 10;
	public int curHealth;
	public int x;


	// Use this for initialization
	void Start () 
	{
		health= 300;

		x= 1;

	}
	
	// Update is called once per frame
	void Update () 
	{
		health + (stamina * x) == curHealth;


	}
}
