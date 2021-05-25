public abstract class RideController : MonoBehaviour // TypeDefIndex: 6602
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15DA10 Offset: 0x15DB11 VA: 0x15DA10
	private bool <IsRiding>k__BackingField; // 0x18

	// Properties
	public bool IsRiding { get; set; }
	public virtual Actor GetActor { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19B9A0 Offset: 0x19BAA1 VA: 0x19B9A0
	// RVA: 0x2331860 Offset: 0x2331961 VA: 0x2331860
	public bool get_IsRiding() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B9B0 Offset: 0x19BAB1 VA: 0x19B9B0
	// RVA: 0x2331870 Offset: 0x2331971 VA: 0x2331870
	protected void set_IsRiding(bool value) { }

	// RVA: 0x2331880 Offset: 0x2331981 VA: 0x2331880 Slot: 4
	public virtual Actor get_GetActor() { }

	// RVA: 0x2331890 Offset: 0x2331991 VA: 0x2331890 Slot: 5
	protected virtual void Awake() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Setup() { }

	// RVA: 0x23318A0 Offset: 0x23319A1 VA: 0x23318A0 Slot: 7
	public virtual bool DoStartRide() { }

	// RVA: 0x23318C0 Offset: 0x23319C1 VA: 0x23318C0 Slot: 8
	public virtual void DoEndRide() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void UpdateFadeAlpha(float alpha) { }

	// RVA: 0x23318D0 Offset: 0x23319D1 VA: 0x23318D0 Slot: 10
	public virtual void UpdateTransform(Vector3 position, Quaternion rotation) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void PlayDamageAction(DamageResult damageResult) { }

	// RVA: 0x2331970 Offset: 0x2331A71 VA: 0x2331970
	protected void .ctor() { }
}

