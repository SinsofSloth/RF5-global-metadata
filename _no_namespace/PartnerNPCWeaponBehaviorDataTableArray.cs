[CreateAssetMenuAttribute] // RVA: 0x146860 Offset: 0x146961 VA: 0x146860
[Serializable]
public class PartnerNPCWeaponBehaviorDataTableArray : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 8170
{
	// Fields
	public PartnerNPCWeaponBehaviorDataTable[] DataTables; // 0x18
	public Dictionary<ItemCategory, PartnerNPCWeaponBehaviorDataTable> DataDic; // 0x20

	// Methods

	// RVA: 0x1FDEEE0 Offset: 0x1FDEFE1 VA: 0x1FDEEE0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x1FDEFD0 Offset: 0x1FDF0D1 VA: 0x1FDEFD0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x1FDEFE0 Offset: 0x1FDF0E1 VA: 0x1FDEFE0
	public void .ctor() { }
}

