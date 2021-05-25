public class ActorEquipManager : SingletonMonoBehaviour<ActorEquipManager> // TypeDefIndex: 6691
{
	// Fields
	public Dictionary<ActorID, Dictionary<EquipSlotType, HumanEquipItem>> EquipItems; // 0x18

	// Methods

	// RVA: 0x1BE97E0 Offset: 0x1BE98E1 VA: 0x1BE97E0
	public bool Get(ActorID actorID, out Dictionary<EquipSlotType, HumanEquipItem> dic) { }

	// RVA: 0x1BE9890 Offset: 0x1BE9991 VA: 0x1BE9890
	public bool Add(ActorID actorID, Dictionary<EquipSlotType, HumanEquipItem> dic) { }

	// RVA: 0x1BE9960 Offset: 0x1BE9A61 VA: 0x1BE9960
	public void ResetEquip() { }

	// RVA: 0x1BE9B70 Offset: 0x1BE9C71 VA: 0x1BE9B70
	public void .ctor() { }
}

