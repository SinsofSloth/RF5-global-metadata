[Serializable]
public struct NPCActionData // TypeDefIndex: 6137
{
	// Fields
	public ActorID ParentActorID; // 0x0
	public bool InequalityEquipWeaponOrWand; // 0x4
	public ItemCategory CanActionEquipWeapon; // 0x8
	public NPCRelationshipWithPlayerType CanActionNPCRelationshipType; // 0xC
	public int CanActionLevel; // 0x10
	public bool CanNotActionSeal; // 0x14
	public NPCFindTargetDataID CanActionFindTargetDataID; // 0x18
	public NPCActionBehaviorDataID ComboBehaviorDataID; // 0x1C
	public int Order; // 0x20
	public int CoolCount; // 0x24
	public int Rate; // 0x28
	public float WaitTime; // 0x2C
	public NPCFindTargetDataID FindTargetDataID; // 0x30
	public NPCActionBehaviorDataID ActionBehaviorDataID; // 0x34
}

