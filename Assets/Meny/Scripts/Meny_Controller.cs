using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Meny_Controller : MonoBehaviour 
{

	public GameObject marker;

	private int listNr = 0;

	private List <Vector2> mainMeny;
	private List <Vector2> actionMeny;
	private List <Vector2> combineMeny;
	private List <Vector2> currentMeny;


	// Use this for initialization
	void Start () 
	{
		mainMeny = new List <Vector2> ();
		mainMeny.Add (new Vector2 (-263.0f, -96.0f));
		mainMeny.Add (new Vector2 (-263.0f, -126.0f));

		actionMeny = new List<Vector2> ();
		actionMeny.Add (new Vector2 (, ));
		actionMeny.Add (new Vector2 (, ));
		actionMeny.Add (new Vector2 (, ));
		actionMeny.Add (new Vector2 (, ));
		actionMeny.Add (new Vector2 (, ));
		actionMeny.Add (new Vector2 (, ));

		combineMeny = new List<Vector2> ();
		combineMeny.Add (new Vector2 (, ));
		combineMeny.Add (new Vector2 (, ));
		combineMeny.Add (new Vector2 (, ));
		combineMeny.Add (new Vector2 (, ));
		combineMeny.Add (new Vector2 (, ));
		combineMeny.Add (new Vector2 (, ));
		combineMeny.Add (new Vector2 (, ));
		combineMeny.Add (new Vector2 (, ));
		combineMeny.Add (new Vector2 (, ));
		combineMeny.Add (new Vector2 (, ));
		combineMeny.Add (new Vector2 (, ));
		combineMeny.Add (new Vector2 (, ));

		currentMeny = new List <Vector2>();

		for (int i = 0; i < 

		marker.transform.localPosition = mainMeny [listNr];
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.W))
		{
			listNr--;

			if (listNr < 0)
			{
				listNr = currentMeny.Count - 1;
			}

			MarkerPos ();
		}

		if (Input.GetKeyDown (KeyCode.S))
		{
			listNr++;

			if (listNr >= currentMeny.Count)
			{
				listNr = 0;
			}

			MarkerPos ();
		}

	}


	void MarkerPos ()
	{
		marker.transform.localPosition = currentMeny [listNr];
	}
}
