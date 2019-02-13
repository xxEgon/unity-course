using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour {

	private Button removeButton; // referencja do butona remove
	private Button useButton; // referencja do butona ItemButton, będzie potem służył do nakładania zebranego ekwipunku
	private Item item; // obiekt klasy Item, z Listy
	private Image icon; // ikona w butonie ItemButton


	// Use this for initialization
	void Start () {
		useButton = GetComponentsInChildren<Button>()[0]; // szukamy 0-go butona w prefabie
		useButton.onClick.AddListener(OnUseItem); // dodajemy mu klika
		icon = useButton.GetComponentsInChildren<Image>()[1]; // szukamy ikony w butonie                                    
		removeButton = GetComponentsInChildren<Button>()[1]; // szukamy remove button-a
		removeButton.onClick.AddListener(OnRemoveItem); // dodajemy mu klika
	}

	private void OnRemoveItem()
	{

		//Debug.Log("InventoryItem|OnRemoveItem|"+item.GetItemName());
		GameObject.Find("ObjectsToPick").transform.Find(item.GetItemName()).GetComponent<ItemPickup>().PutDown();
		InventoryManager.instance.RemoveItem(item);
	}
	public void UpdateItem(Item newitem)
	{
		item = newitem;
		icon.sprite = item.GetItemIcon(); // ustawienie ikony 
		icon.enabled = true; // włączenie jej
		removeButton.interactable = true; // klikalność
	}
	public void ClearItem()
	{
		item = null;
		icon.sprite = null; // brak obrazka
		icon.enabled = false; // buton nie aktywny
		removeButton.interactable = false; // nie klikalny
	}
	private void OnUseItem()
	{
		if (item != null)
		{
			item.Use();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
