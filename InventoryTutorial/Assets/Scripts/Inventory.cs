using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour 
{
	private RectTransform inventoryRect;

	private float inventoryWidth;
	private float inventoryHeight;

	public int slots;
	public int rows;

	public float slotPaddingLeft;
	public float slotPladdingTop;

	public float slotSize;

	public GameObject slotPrefab;

	private List<GameObject> allSlots;
	// Use this for initialization
	void Start () 
	{
		CreateLayout ();
	}
	
	// Update is called once per frame
	void Update () {}

	private void CreateLayout()
	{
		allSlots = new List<GameObject>();

		inventoryWidth = (slots / rows) * (slotSize + slotPaddingLeft) + slotPaddingLeft;
		inventoryHeight = rows * (slotSize + slotPladdingTop) + slotPladdingTop;

		inventoryRect = GetComponent<RectTransform> ();

		inventoryRect.SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, inventoryWidth);
		inventoryRect.SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, inventoryHeight);
	}
}
