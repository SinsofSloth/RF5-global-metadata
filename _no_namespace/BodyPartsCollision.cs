public class BodyPartsCollision : CharacterBase // TypeDefIndex: 6580
{
	// Fields
	[SerializeField] // RVA: 0x15D7F0 Offset: 0x15D8F1 VA: 0x15D7F0
	private string BodyPartsTypeName; // 0x68
	[SerializeField] // RVA: 0x15D800 Offset: 0x15D901 VA: 0x15D800
	private int BodyPartsType; // 0x70
	[SerializeField] // RVA: 0x15D810 Offset: 0x15D911 VA: 0x15D810
	private bool IsOverrideParentCollider; // 0x74
	public bool _IsCanNotLockon; // 0x75
	public bool _UseParentLockOn; // 0x76
	public Vector3 LockonPotitionOffset; // 0x78
	public bool IsCanNotPlayerOverlap; // 0x84
	public BodyPartsCollision.BodyPartsOverlapEvent OverlapEvent; // 0x88

	// Properties
	public bool OverrideParentCollider { get; }
	public override Alliance Alliance { get; }
	public override Vector3 GetTakeLockonPos { get; }

	// Methods

	// RVA: 0x22E6370 Offset: 0x22E6471 VA: 0x22E6370
	public bool get_OverrideParentCollider() { }

	// RVA: 0x22E6380 Offset: 0x22E6481 VA: 0x22E6380
	public void Setup(CharacterBase characterBase) { }

	// RVA: 0x22E6460 Offset: 0x22E6561 VA: 0x22E6460
	public void SetEnabled(bool enabled) { }

	// RVA: 0x22E6470 Offset: 0x22E6571 VA: 0x22E6470 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult totalDamage) { }

	// RVA: 0x22E6550 Offset: 0x22E6651 VA: 0x22E6550 Slot: 8
	public override Alliance get_Alliance() { }

	// RVA: 0x22E6640 Offset: 0x22E6741 VA: 0x22E6640 Slot: 9
	public override bool IsCanNotLockon(CharacterBase lockonCharacter) { }

	// RVA: 0x22E6740 Offset: 0x22E6841 VA: 0x22E6740 Slot: 10
	public override Vector3 get_GetTakeLockonPos() { }

	// RVA: 0x22E6990 Offset: 0x22E6A91 VA: 0x22E6990 Slot: 16
	public virtual string GetBodyPartsTypeName() { }

	// RVA: 0x22E69A0 Offset: 0x22E6AA1 VA: 0x22E69A0 Slot: 17
	public virtual void SetBodyPartsType(int type) { }

	// RVA: 0x22E69B0 Offset: 0x22E6AB1 VA: 0x22E69B0
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x22E6AD0 Offset: 0x22E6BD1 VA: 0x22E6AD0
	public void .ctor() { }
}

