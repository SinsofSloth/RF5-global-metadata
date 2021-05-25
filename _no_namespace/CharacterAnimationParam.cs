[Serializable]
public class CharacterAnimationParam // TypeDefIndex: 6521
{
	// Fields
	public bool enableMove; // 0x10
	public bool enableRotate; // 0x11
	public bool enableAvoid; // 0x12
	public bool enableAttack; // 0x13
	public bool enableHandCuffs; // 0x14
	public bool enableHandCuffsThrow; // 0x15
	public bool enableRuneAbility; // 0x16
	public bool enableRunStart; // 0x17
	public bool enableBraking; // 0x18
	public bool enableDamage; // 0x19
	public bool enableItemUse; // 0x1A
	public bool enableItemHold; // 0x1B
	public bool enableWeaponChange; // 0x1C
	public bool enableSuperArmor; // 0x1D
	public bool enableSpeedLimit; // 0x1E
	public bool enableItemVisible; // 0x1F
	public bool enableWeaponVisible; // 0x20
	public bool enableShieldVisible; // 0x21
	public bool enableInteraction; // 0x22
	public bool enableGravity; // 0x23
	public bool enableNavMesh; // 0x24
	public bool enableYawn; // 0x25
	public bool enableDualSkill; // 0x26
	public float moveSpeedRate; // 0x28
	public float moveAccelRate; // 0x2C
	public float moveDecelRate; // 0x30
	public float rotateSpeedRate; // 0x34
	[RangeAttribute] // RVA: 0x15D210 Offset: 0x15D311 VA: 0x15D210
	public float weightLookIK; // 0x38
	[RangeAttribute] // RVA: 0x15D230 Offset: 0x15D331 VA: 0x15D230
	public float weightGrounderIK; // 0x3C
	[RangeAttribute] // RVA: 0x15D250 Offset: 0x15D351 VA: 0x15D250
	public float weightItemLayer; // 0x40
	public float cameraTargetLerpSpeedXZ; // 0x44
	public float cameraTargetLerpSpeedY; // 0x48
	public bool disableOpenMenu; // 0x4C

	// Methods

	// RVA: 0x1E4D010 Offset: 0x1E4D111 VA: 0x1E4D010
	public void Init() { }

	// RVA: 0x1E4CF70 Offset: 0x1E4D071 VA: 0x1E4CF70
	public void .ctor() { }
}

