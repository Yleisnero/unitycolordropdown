using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setupDropdownItem : MonoBehaviour {

	public Button button;
	public Text itemText;
	public Image background;

	private int itemID;

	void Start(){
		button.onClick.AddListener (dropdownItemClicked);
	}

	public void setup (int id, string itemText, Color backgroundColor, Color textColor) {
		this.itemID = id;
		this.itemText.text = itemText;
		this.itemText.color = textColor;
		background.color = backgroundColor;
		this.gameObject.transform.localScale = new Vector3 (1, 1, 1);
	}

	private void dropdownItemClicked(){
		print (this.itemID);
		this.GetComponentInParent<acessDropdownController> ().dropdownController.setLabel (this.itemID);
	}
}
