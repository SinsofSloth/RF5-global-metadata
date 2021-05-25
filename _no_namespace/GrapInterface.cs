public interface GrapInterface // TypeDefIndex: 8957
{
	// Properties
	public abstract Collider Collider { get; }
	public abstract Vector3 CurrentPosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Collider get_Collider() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanGrap(HumanController humanController) { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool DoGrap(HumanController humanController) { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool OnThrow(Vector3 direction, float power) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool OnThrow(Vector3 direction, float power, DamageInfo damageInfo) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool OnThrow(Vector3 direction, float power, DamageInfo damageInfo1, DamageInfo damageInfo2) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void UpdatePosition(Vector3 grappler, Vector3 foward, float rate) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Vector3 get_CurrentPosition() { }
}

