public class OnCollisionSphereCommand : ToolActionCommandBase // TypeDefIndex: 6283
{
	// Properties
	public float MotionPower { get; }
	public override float Duration { get; }
	public AttackType AttackType { get; }
	public EquipToolDamageAction DamageAction { get; }
	public EffectID EffectName { get; }
	public string HitStopName { get; }
	public Vector3 Offset { get; }
	public float Radius { get; }

	// Methods

	// RVA: 0x1D8F7B0 Offset: 0x1D8F8B1 VA: 0x1D8F7B0
	public float get_MotionPower() { }

	// RVA: 0x1D8F7D0 Offset: 0x1D8F8D1 VA: 0x1D8F7D0 Slot: 4
	public override float get_Duration() { }

	// RVA: 0x1D8F7F0 Offset: 0x1D8F8F1 VA: 0x1D8F7F0
	public AttackType get_AttackType() { }

	// RVA: 0x1D8F8E0 Offset: 0x1D8F9E1 VA: 0x1D8F8E0
	public EquipToolDamageAction get_DamageAction() { }

	// RVA: 0x1D8F9B0 Offset: 0x1D8FAB1 VA: 0x1D8F9B0
	public EffectID get_EffectName() { }

	// RVA: 0x1D8FA50 Offset: 0x1D8FB51 VA: 0x1D8FA50
	public string get_HitStopName() { }

	// RVA: 0x1D8FA70 Offset: 0x1D8FB71 VA: 0x1D8FA70
	public Vector3 get_Offset() { }

	// RVA: 0x1D8FA90 Offset: 0x1D8FB91 VA: 0x1D8FA90
	public float get_Radius() { }

	// RVA: 0x1D8FAB0 Offset: 0x1D8FBB1 VA: 0x1D8FAB0
	public void .ctor(ActionCommandDataTable actionCommandData, AS_ToolController controller) { }

	// RVA: 0x1D8FB10 Offset: 0x1D8FC11 VA: 0x1D8FB10 Slot: 8
	public override void DoAction() { }

	// RVA: 0x1D8FB30 Offset: 0x1D8FC31 VA: 0x1D8FB30 Slot: 10
	public override void EndAction() { }
}

