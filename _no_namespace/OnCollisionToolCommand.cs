public class OnCollisionToolCommand : ToolActionCommandBase // TypeDefIndex: 6285
{
	// Properties
	internal AttachHand AttachHand { get; }
	public float MotionPower { get; }
	public override float Duration { get; }
	public AttackType AttackType { get; }
	public EquipToolDamageAction DamageAction { get; }
	public EffectID EffectName { get; }
	public string HitStopName { get; }

	// Methods

	// RVA: 0x1D8FB50 Offset: 0x1D8FC51 VA: 0x1D8FB50
	internal AttachHand get_AttachHand() { }

	// RVA: 0x1D8FB60 Offset: 0x1D8FC61 VA: 0x1D8FB60
	public float get_MotionPower() { }

	// RVA: 0x1D8FB80 Offset: 0x1D8FC81 VA: 0x1D8FB80 Slot: 4
	public override float get_Duration() { }

	// RVA: 0x1D8FBA0 Offset: 0x1D8FCA1 VA: 0x1D8FBA0
	public AttackType get_AttackType() { }

	// RVA: 0x1D8FC90 Offset: 0x1D8FD91 VA: 0x1D8FC90
	public EquipToolDamageAction get_DamageAction() { }

	// RVA: 0x1D8FD80 Offset: 0x1D8FE81 VA: 0x1D8FD80
	public EffectID get_EffectName() { }

	// RVA: 0x1D8FE20 Offset: 0x1D8FF21 VA: 0x1D8FE20
	public string get_HitStopName() { }

	// RVA: 0x1D8FE40 Offset: 0x1D8FF41 VA: 0x1D8FE40
	public void .ctor(ActionCommandDataTable actionCommandData, AS_ToolController controller) { }

	// RVA: 0x1D8FEA0 Offset: 0x1D8FFA1 VA: 0x1D8FEA0 Slot: 8
	public override void DoAction() { }

	// RVA: 0x1D8FEC0 Offset: 0x1D8FFC1 VA: 0x1D8FEC0 Slot: 10
	public override void EndAction() { }
}

