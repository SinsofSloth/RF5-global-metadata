public class HekatonkeilController : BossMonsterContoroller // TypeDefIndex: 7887
{
	// Fields
	private const float THROW_THRESHOLD = 0.2;
	private ParticleSystem OmenParticleSystem; // 0x510
	private int FootStepCount; // 0x518
	private int FootStepCountMax; // 0x51C
	private int RoundCount; // 0x520
	private int RoundCountMax; // 0x524

	// Methods

	// RVA: 0x2300DF0 Offset: 0x2300EF1 VA: 0x2300DF0 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x2300EA0 Offset: 0x2300FA1 VA: 0x2300EA0 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x2301070 Offset: 0x2301171 VA: 0x2301070
	public void ReSetProjectile() { }

	// RVA: 0x2301080 Offset: 0x2301181 VA: 0x2301080 Slot: 137
	public override void OnUniqueProjectileActionCommandInternal(MonsterProjectileActionScriptsController monsterProjectileActionScriptsController, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x2301540 Offset: 0x2301641 VA: 0x2301540
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3E20 Offset: 0x1A3F21 VA: 0x1A3E20
	// RVA: 0x2301550 Offset: 0x2301651 VA: 0x2301550
	private void <OnSetup>b__6_0(ParticleSystem particle) { }
}

