public class HitReaction : OffsetModifier // TypeDefIndex: 9550
{
	// Fields
	[TooltipAttribute] // RVA: 0x17C840 Offset: 0x17C941 VA: 0x17C840
	public HitReaction.HitPointEffector[] effectorHitPoints; // 0x30
	[TooltipAttribute] // RVA: 0x17C880 Offset: 0x17C981 VA: 0x17C880
	public HitReaction.HitPointBone[] boneHitPoints; // 0x38

	// Properties
	public bool inProgress { get; }

	// Methods

	// RVA: 0x2B3B5A0 Offset: 0x2B3B6A1 VA: 0x2B3B5A0
	public bool get_inProgress() { }

	// RVA: 0x2B3B680 Offset: 0x2B3B781 VA: 0x2B3B680 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x2B3B8B0 Offset: 0x2B3B9B1 VA: 0x2B3B8B0
	public void Hit(Collider collider, Vector3 force, Vector3 point) { }

	// RVA: 0x2B3BC20 Offset: 0x2B3BD21 VA: 0x2B3BC20
	public void .ctor() { }
}

