public class SetBehaviorCommand : MonsterProjectileActionCommandBase // TypeDefIndex: 6245
{
	// Fields
	private const string Path = "prefabs/";
	private EffectID _LaunchPointEffectID; // 0x88
	private EffectID _EffectID; // 0x8C
	private EffectID _HitEffectID; // 0x90

	// Properties
	public SetBehaviorCommand.BehaviorType Behavior { get; }
	private EffectID LaunchPointEffectID { get; }
	private EffectID EffectID { get; }
	private EffectID HitEffectID { get; }

	// Methods

	// RVA: 0x1C89330 Offset: 0x1C89431 VA: 0x1C89330
	public SetBehaviorCommand.BehaviorType get_Behavior() { }

	// RVA: 0x1C89390 Offset: 0x1C89491 VA: 0x1C89390
	private EffectID get_LaunchPointEffectID() { }

	// RVA: 0x1C89410 Offset: 0x1C89511 VA: 0x1C89410
	private EffectID get_EffectID() { }

	// RVA: 0x1C89490 Offset: 0x1C89591 VA: 0x1C89490
	private EffectID get_HitEffectID() { }

	// RVA: 0x1C89510 Offset: 0x1C89611 VA: 0x1C89510
	public void .ctor(ActionCommandDataTable actionCommandData, MonsterProjectileActionScriptsController controller) { }

	// RVA: 0x1C89570 Offset: 0x1C89671 VA: 0x1C89570 Slot: 8
	public override void DoAction() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A860 Offset: 0x19A961 VA: 0x19A860
	// RVA: 0x1C8A310 Offset: 0x1C8A411 VA: 0x1C8A310
	private void <DoAction>b__14_0(Collider collider) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A870 Offset: 0x19A971 VA: 0x19A870
	// RVA: 0x1C8A370 Offset: 0x1C8A471 VA: 0x1C8A370
	private void <DoAction>b__14_1(Collider collider) { }
}

