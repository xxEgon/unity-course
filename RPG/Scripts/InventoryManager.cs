using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour {

	public static InventoryManager instance;
	private List<Item> itemsList = new List<Item>();
	public delegate void OnItemPicked();
	public OnItemPicked onItemPicked;

	private void Awake()
    {
        /* singleton */
        if (instance != null)
        {
             Debug.LogError("Istnieje już instancja tej klasy: " + InventoryManager.instance);
            return;
        }
        instance = this;
    }

	public bool AddItem(Item item)
	{
		if (itemsList.Count >= 3)
		{
			Debug.Log("nie ma już miejsca w ekwipunku");
			return false;
		}

		itemsList.Add(item);

		if (onItemPicked != null) onItemPicked.Invoke();
		//Debug.Log("InventoryManager|AddItem|"+item.GetItemName());

		return true;	
	}
	public void RemoveItem(Item item)
	{
		itemsList.Remove(item);
		if (onItemPicked != null) onItemPicked.Invoke();
		//Debug.Log("InventoryManager|RemoveItem");
	}
	public List<Item> GetItemsList()
	{
		return itemsList;
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
