public class NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter // TypeDefIndex: 6147
{
	// Fields
	public readonly int Index; // 0x10
	public readonly NPCActionData ActionBehaviorData; // 0x14
	public Func<Character, bool> CanActionFindTargetFunc; // 0x50
	public Func<Character, bool> FindTargetFunc; // 0x58
	public int CurrentCoolCount; // 0x60

	// Methods

	// RVA: 0x1FB2B20 Offset: 0x1FB2C21 VA: 0x1FB2B20
	public void .ctor(int index, NPCActionData actionBehaviorData) { }

	// RVA: 0x1FB4950 Offset: 0x1FB4A51 VA: 0x1FB4950
	private bool CanActionCheckEquip(ItemData equipItemData) { }

	// RVA: 0x1FB49F0 Offset: 0x1FB4AF1 VA: 0x1FB49F0
	private bool CanActionCheckRelationship(PartnerNPCController owner) { }

	// RVA: 0x1FB4AE0 Offset: 0x1FB4BE1 VA: 0x1FB4AE0
	private bool CanActionCheckLevel(PartnerNPCController owner) { }

	// RVA: 0x1FB4B30 Offset: 0x1FB4C31 VA: 0x1FB4B30
	private bool CanActionCheckNotSeal(PartnerNPCController owner) { }

	// RVA: 0x1FB3DC0 Offset: 0x1FB3EC1 VA: 0x1FB3DC0
	public bool CanActionCheck(PartnerNPCController owner) { }

	// RVA: 0x1FB3FB0 Offset: 0x1FB40B1 VA: 0x1FB3FB0
	public bool IsForceActionCheckComboActionData(NPCActionBehaviorDataID previousActionBehaviorDataID) { }

	// RVA: 0x1FB4940 Offset: 0x1FB4A41 VA: 0x1FB4940
	public bool IsMeetsOrder(int order) { }

	// RVA: 0x1FB3550 Offset: 0x1FB3651 VA: 0x1FB3550
	public int GetRaito(bool ignoreCoolCount) { }

	// RVA: 0x1FB3F10 Offset: 0x1FB4011 VA: 0x1FB3F10
	public void UpdateCoolCount() { }

	// RVA: 0x1FB3570 Offset: 0x1FB3671 VA: 0x1FB3570
	public void ResetCoolCount() { }
}

