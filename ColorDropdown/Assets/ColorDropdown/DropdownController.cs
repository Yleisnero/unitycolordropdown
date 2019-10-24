using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownItem{
	public int itemID { get; set; }
	public string itemText { get; set; }
	public Color backgroundColor { get; set; }
	public Color textColor { get; set; }

	public DropdownItem (int itemID, string itemText, Color backgroundColor, Color textColor) {
		this.itemID = itemID;
		this.itemText = itemText;
		this.backgroundColor = backgroundColor;
		this.textColor = textColor;
	}
}

public class DropdownController : MonoBehaviour {

	public Button dropdownLabel;	//Button
	public GameObject dropDown;		//ScrollView

	public SimpleObjectPool itemObjectPool;	//to add new Items to the Dropdown
	public Transform content;

	private List<DropdownItem> dropdownItems = new List<DropdownItem> ();
	private DropdownItem currentLabel;

	// Use this for initialization
	void Start () {
		dropdownLabel.onClick.AddListener (dropdownClicked);
	}

	public void dropdownClicked(){
		if (dropDown.activeSelf) {
			dropDown.SetActive (false);
		} else {
			dropDown.SetActive (true);
		}
	}

	public void addDropdownItem(string itemText, Color backgroundColor, Color textColor){
		dropdownItems.Add (new DropdownItem (dropdownItems.Count, itemText, backgroundColor, textColor));
		GameObject newDropdownItem = itemObjectPool.GetObject ();
		newDropdownItem.transform.SetParent (content);
		newDropdownItem.GetComponent<setupDropdownItem> ().setup (dropdownItems.Count - 1, itemText, backgroundColor, textColor);
	}

	public void setLabel(int id){
		currentLabel = dropdownItems[id];
		dropdownLabel.GetComponent<Image> ().color = currentLabel.backgroundColor;
		dropdownLabel.GetComponentInChildren<Text> ().text = currentLabel.itemText;
		dropdownLabel.GetComponentInChildren<Text> ().color = currentLabel.textColor;
		dropDown.gameObject.SetActive (false);
	}

	public DropdownItem getCurrentLabelItem(){
		return currentLabel;
	}
}
