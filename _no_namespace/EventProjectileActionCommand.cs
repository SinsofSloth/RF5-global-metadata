public class EventProjectileActionCommand : MonsterProjectileActionCommand // TypeDefIndex: 6251
{
	// Fields
	private MonsterProjectileActionScriptsController projectileActionScriptsController; // 0x88

	// Properties
	private EventProjectileActionCommand.CreateTimingType Type { get; }
	public override string NextActionCode { get; }
	public override bool UseRotate { get; }
	public override Vector2 DirectionBlurAngle { get; }

	// Methods

	// RVA: 0x2072990 Offset: 0x2072A91 VA: 0x2072990
	private EventProjectileActionCommand.CreateTimingType get_Type() { }

	// RVA: 0x20729F0 Offset: 0x2072AF1 VA: 0x20729F0 Slot: 13
	public override string get_NextActionCode() { }

	// RVA: 0x2072A10 Offset: 0x2072B11 VA: 0x2072A10 Slot: 14
	public override bool get_UseRotate() { }

	// RVA: 0x2072A30 Offset: 0x2072B31 VA: 0x2072A30 Slot: 15
	public override Vector2 get_DirectionBlurAngle() { }

	// RVA: 0x2072A50 Offset: 0x2072B51 VA: 0x2072A50
	public void .ctor(ActionCommandDataTable actionCommandData, MonsterProjectileActionScriptsController controller) { }

	// RVA: 0x2072AD0 Offset: 0x2072BD1 VA: 0x2072AD0 Slot: 8
	public override void DoAction() { }

	// RVA: 0x2072CD0 Offset: 0x2072DD1 VA: 0x2072CD0
	private void Create() { }

	// RVA: 0x2072CE0 Offset: 0x2072DE1 VA: 0x2072CE0 Slot: 17
	protected override void ProjcticlePostprocess(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A880 Offset: 0x19A981 VA: 0x19A880
	// RVA: 0x2072D30 Offset: 0x2072E31 VA: 0x2072D30
	private void <DoAction>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A890 Offset: 0x19A991 VA: 0x19A890
	// RVA: 0x2072DF0 Offset: 0x2072EF1 VA: 0x2072DF0
	private void <DoAction>b__11_1(Collider collide) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A8A0 Offset: 0x19A9A1 VA: 0x19A8A0
	// RVA: 0x2072E90 Offset: 0x2072F91 VA: 0x2072E90
	private void <DoAction>b__11_2(Collider collider) { }
}

