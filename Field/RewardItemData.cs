[Serializable]
public class RewardItemData // TypeDefIndex: 10512
{
	// Fields
	[SerializeField] // RVA: 0x181CD0 Offset: 0x181DD1 VA: 0x181CD0
	public int ItemID; // 0x10
	[SerializeField] // RVA: 0x181CE0 Offset: 0x181DE1 VA: 0x181CE0
	public int Amount; // 0x14
	[SerializeField] // RVA: 0x181CF0 Offset: 0x181DF1 VA: 0x181CF0
	public int Level; // 0x18

	// Methods

	// RVA: 0x1EEE8C0 Offset: 0x1EEE9C1 VA: 0x1EEE8C0
	public void .ctor() { }

	// RVA: 0x1EEF570 Offset: 0x1EEF671 VA: 0x1EEF570
	public void .ctor(int itemId, int amount, int level) { }

	// RVA: 0x1EEEB70 Offset: 0x1EEEC71 VA: 0x1EEEB70
	public void SetData(int itemId, int amount, int level) { }

	// RVA: 0x1EEED50 Offset: 0x1EEEE51 VA: 0x1EEED50
	public void ClearData() { }
}

