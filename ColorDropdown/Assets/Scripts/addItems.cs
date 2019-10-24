using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addItems : MonoBehaviour {

	public DropdownController dropdown;

	// Use this for initialization
	void Start () {
		dropdown.addDropdownItem ("test1", new Color (1, 0, 0), new Color (1, 1, 1));
		dropdown.addDropdownItem ("test2", new Color (0, 1, 0), new Color (0, 0, 0));
		dropdown.addDropdownItem ("test3", new Color (0, 0, 1), new Color (1, 1, 1));
		dropdown.setLabel (0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
