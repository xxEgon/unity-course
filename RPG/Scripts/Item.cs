using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

	private string itemname;
    private Sprite itemicon;

	//konstruktor
	public Item(string itemname, Sprite itemicon)
    {
        this.itemname = itemname;
        this.itemicon = itemicon;
    }

	public string GetItemName()
    {
        return itemname;
    }
    public Sprite GetItemIcon()
    {
        return itemicon;
    }
	public void Use()
	{
		EquipmentManager.instance.EquipPlayer(this);
		// wywołaj funkcję EquipPlayer(this) z klasy EquipmentManager
		// argument this oznacza item, który chcemy nałożyć na playera


		InventoryManager.instance.RemoveItem(this);
		// usuń element ekwipunku z inventory
		// czyli wywołaj funkcję RemoveItem(this) z klasy InventoryManager
		// argument this oznacza item, który chcemy usunąć z listy w inventory
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
