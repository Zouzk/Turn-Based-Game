using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Meny_Controller : MonoBehaviour 
{

	public GameObject marker;

	private int listNr = 0;

	enum Menu {MainMenu, ActionMenu, CombineMenu, Confirm};
	Menu menu = Menu.MainMenu;

	private List <Vector2> mainMeny;
	private List <Vector2> actionMeny;
	private List <Vector2> combineMeny;
	private List <Vector2> currentMeny;
	private List <Vector2> confirm;
	//public Vector2 markerOffset;
	private bool isOnAction;

	public GameObject action;
	public GameObject combine;

	// Use this for initialization
	void Start () 
	{
		mainMeny = new List <Vector2> ();
		mainMeny.Add (new Vector2 (-260, 80));
		mainMeny.Add (new Vector2 (-260, 35));

		actionMeny = new List<Vector2> ();
		//Water
		actionMeny.Add (new Vector2 (-167, 82));
		//Fire
		actionMeny.Add (new Vector2 (-175, 54));
		//Earth
		actionMeny.Add (new Vector2 (-167, 21));
		//Ice
		actionMeny.Add (new Vector2 (-55, 82));
		//Lightning
		actionMeny.Add (new Vector2 (-17, 54));
		//Block
		actionMeny.Add (new Vector2 (-43, 21));

		combineMeny = new List<Vector2> ();
		//Water
		combineMeny.Add (new Vector2 (362, 82));
		//Fire
		combineMeny.Add (new Vector2 (357, 54));
		//Earth
		combineMeny.Add (new Vector2 (364, 21));
		//Ice
		combineMeny.Add (new Vector2 (218, 82));
		//Lightning
		combineMeny.Add (new Vector2 (253, 52));

		confirm = new List<Vector2> ();
		//Confirm
		confirm.Add (new Vector2 (100, 52.5f));


		currentMeny = new List <Vector2>(mainMeny);

		isOnAction = true;

		transform.GetComponent<RectTransform>().anchoredPosition = currentMeny [listNr];

		// Action.SetActive (true); Sets Gameobject to whenever it should be active or not
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

			if (menu == Menu.MainMenu && listNr == 0)
			{
				isOnAction = true;
			} 

			else if (menu == Menu.MainMenu && listNr != 0)
			{
				isOnAction = false;
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

			if (menu == Menu.MainMenu && listNr == 0)
			{
				isOnAction = true;
			} 

			else if (menu == Menu.MainMenu && listNr != 0)
			{
				isOnAction = false;
			}

			MarkerPos ();
		}

		if (Input.GetKeyDown (KeyCode.A) && menu != Menu.MainMenu)
		{
			if (menu == Menu.ActionMenu && listNr >= 3)
			{
				listNr = listNr - 3;
			} 

			else if (menu == Menu.CombineMenu && listNr < 2)
			{
				listNr = listNr + 3;
			}

			if (listNr >= currentMeny.Count)
			{
				listNr = currentMeny.Count;
			}

			MarkerPos ();
		}

		if (Input.GetKeyDown (KeyCode.D) && menu != Menu.MainMenu)
		{
			if (menu == Menu.ActionMenu && listNr < 3)
			{
				listNr = listNr + 3;
			} 

			else if (menu == Menu.CombineMenu && listNr >= 3)
			{
				listNr = listNr - 3;
			}
			if (listNr >= currentMeny.Count)
			{
				listNr = currentMeny.Count;
			}

			MarkerPos ();
		}

		if (Input.GetKeyDown (KeyCode.Space))
		{
			
			MenySwitcher (true);
		
		}

		if (Input.GetKeyDown (KeyCode.B))
		{
			MenySwitcher (false);
		}

		if (isOnAction == true)
		{
			action.SetActive (true);
			combine.SetActive (false);
		}

		else
		{
			action.SetActive (false);
			combine.SetActive (true);
		}
	}


	void MarkerPos ()
	{
		transform.GetComponent<RectTransform>().anchoredPosition = currentMeny [listNr]; //+ markerOffset;
	}

	void MenySwitcher (bool nextMenu) 
	{
		if (isOnAction == true)
		{
			if (menu == Menu.MainMenu)
			{
				MenyChanger (actionMeny, Menu.ActionMenu);
			}

			else if (menu == Menu.ActionMenu)
			{
				if (nextMenu == true)
				{
					MenyChanger (confirm, Menu.Confirm);
				} 

				else
				{
					MenyChanger (mainMeny, Menu.MainMenu);
				}
			}

			else if (menu == Menu.Confirm)
			{
				if (nextMenu == true)
				{
					EndTurn ();
				} 

				else
				{
					MenyChanger (actionMeny, Menu.ActionMenu);
				}
			
			}
		
		} 

		else
		{
			if (menu == Menu.MainMenu)
			{
				MenyChanger (actionMeny, Menu.ActionMenu);
			}

			else if (menu == Menu.ActionMenu)
			{
				if (nextMenu == true)
				{
					MenyChanger (combineMeny, Menu.CombineMenu);
				} 

				else
				{
					MenyChanger (mainMeny, Menu.MainMenu);
				}
			}

			else if (menu == Menu.CombineMenu)
			{
				if (nextMenu == true)
				{
					MenyChanger (confirm, Menu.Confirm);
				} 

				else
				{
					MenyChanger (actionMeny, Menu.ActionMenu);
				}
			} 

			else if (menu == Menu.Confirm)
			{
				if (nextMenu == true)
				{
					EndTurn ();
				} 

				else
				{
					MenyChanger (combineMeny, Menu.CombineMenu);
				}
		
			}
		
		}
	
	}

	void MenyChanger (List<Vector2> menuList, Menu menuEnum)
	{
		currentMeny = new List <Vector2> (menuList);
		menu = menuEnum;

		if (menu == Menu.MainMenu && isOnAction == false)
		{
			listNr = 1;
		} 

		else
		{
			listNr = 0;
		}
		MarkerPos ();
	}

	public void EndTurn ()
	{
		
	}
}
