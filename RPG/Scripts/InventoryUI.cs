using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryUI : MonoBehaviour {

	private GameObject inventoryItemsPanel;
	InventoryItem[] inventoryItems;
	InventoryManager inventoryManager;

	// Use this for initialization
	void Start () {
		inventoryManager = InventoryManager.instance;
		inventoryManager.onItemPicked += UpdateUI;
		inventoryItemsPanel = GameObject.Find("InventoryPanel");
		inventoryItems = inventoryItemsPanel.GetComponentsInChildren<InventoryItem>();

		if (EventSystem.current.IsPointerOverGameObject())  return;
	}
	void UpdateUI(){
		for (int i = 0; i < inventoryItems.Length; i++)
		{
			if (i < inventoryManager.GetItemsList().Count)            
				inventoryItems[i].UpdateItem(inventoryManager.GetItemsList()[i]);            
			else            
				inventoryItems[i].ClearItem();
		}
		//Debug.Log("UpdateUI");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
