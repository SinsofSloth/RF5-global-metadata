public class OnCollisionBoxCommand : ToolActionCommandBase // TypeDefIndex: 6282
{
	// Properties
	public float MotionPower { get; }
	public override float Duration { get; }
	public AttackType AttackType { get; }
	public EquipToolDamageAction DamageAction { get; }
	public EffectID EffectName { get; }
	public string HitStopName { get; }
	public Vector3 Offset { get; }
	public Vector3 Size { get; }

	// Methods

	// RVA: 0x1D8ED60 Offset: 0x1D8EE61 VA: 0x1D8ED60
	public float get_MotionPower() { }

	// RVA: 0x1D8ED80 Offset: 0x1D8EE81 VA: 0x1D8ED80 Slot: 4
	public override float get_Duration() { }

	// RVA: 0x1D8EDA0 Offset: 0x1D8EEA1 VA: 0x1D8EDA0
	public AttackType get_AttackType() { }

	// RVA: 0x1D8EE90 Offset: 0x1D8EF91 VA: 0x1D8EE90
	public EquipToolDamageAction get_DamageAction() { }

	// RVA: 0x1D8EF80 Offset: 0x1D8F081 VA: 0x1D8EF80
	public EffectID get_EffectName() { }

	// RVA: 0x1D8F020 Offset: 0x1D8F121 VA: 0x1D8F020
	public string get_HitStopName() { }

	// RVA: 0x1D8F040 Offset: 0x1D8F141 VA: 0x1D8F040
	public Vector3 get_Offset() { }

	// RVA: 0x1D8F060 Offset: 0x1D8F161 VA: 0x1D8F060
	public Vector3 get_Size() { }

	// RVA: 0x1D8F080 Offset: 0x1D8F181 VA: 0x1D8F080
	public void .ctor(ActionCommandDataTable actionCommandData, AS_ToolController controller) { }

	// RVA: 0x1D8F0E0 Offset: 0x1D8F1E1 VA: 0x1D8F0E0 Slot: 8
	public override void DoAction() { }

	// RVA: 0x1D8F100 Offset: 0x1D8F201 VA: 0x1D8F100 Slot: 10
	public override void EndAction() { }
}

