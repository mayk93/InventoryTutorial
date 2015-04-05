using UnityEngine;
using System.Collections;

/*
 * Move it in it;s own file
 */
public enum ItemType
{
	HEALTH,
	STAMINA
};

public class Item : MonoBehaviour 
{
	public ItemType type;
	public Sprite spriteNeutral;
	public Sprite spriteHighlighted;
	public int maxSize;

	public void Use()
	{
		switch(type)
		{
			case ItemType.HEALTH:
				Debug.Log("Used health item.");
				break;
			case ItemType.STAMINA:
				Debug.Log("Used stamina item.");
				break;
			default:
				break;
		}
	}
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}
}
