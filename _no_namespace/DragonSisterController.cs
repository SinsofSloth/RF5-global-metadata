public class DragonSisterController : BossMonsterContoroller // TypeDefIndex: 7846
{
	// Fields
	private static readonly Vector3 MEGAFIRE_OMEN_SCALE; // 0x0
	private GameObject Chest; // 0x510
	private GameObject Jaw; // 0x518
	private DragonSisterEffect FlameBreath; // 0x520
	private ParticleSystem OmenParticleSystem; // 0x528
	private int MeteorCounter; // 0x530
	private int MaxMeteor; // 0x534

	// Methods

	// RVA: 0x1CF0630 Offset: 0x1CF0731 VA: 0x1CF0630 Slot: 12
	protected override void Start() { }

	// RVA: 0x1CF0800 Offset: 0x1CF0901 VA: 0x1CF0800 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x1CF0920 Offset: 0x1CF0A21 VA: 0x1CF0920 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x1CF0A40 Offset: 0x1CF0B41 VA: 0x1CF0A40 Slot: 129
	protected override void OnSetModelObject(GameObject model) { }

	// RVA: 0x1CF0AF0 Offset: 0x1CF0BF1 VA: 0x1CF0AF0 Slot: 40
	protected override void Update() { }

	// RVA: 0x1CF0BF0 Offset: 0x1CF0CF1 VA: 0x1CF0BF0
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x1CF0FB0 Offset: 0x1CF10B1 VA: 0x1CF0FB0 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x1CF1280 Offset: 0x1CF1381 VA: 0x1CF1280
	private void CheckMeteors(string repeatAction, string endAction) { }

	// RVA: 0x1CF1480 Offset: 0x1CF1581 VA: 0x1CF1480 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x1CF1580 Offset: 0x1CF1681 VA: 0x1CF1580 Slot: 138
	public override void OnRestraint() { }

	// RVA: 0x1CEFE80 Offset: 0x1CEFF81 VA: 0x1CEFE80
	public void PlaySE(SoundID se_id) { }

	// RVA: 0x1CF15C0 Offset: 0x1CF16C1 VA: 0x1CF15C0
	public void .ctor() { }

	// RVA: 0x1CF15D0 Offset: 0x1CF16D1 VA: 0x1CF15D0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A33C0 Offset: 0x1A34C1 VA: 0x1A33C0
	// RVA: 0x1CF1660 Offset: 0x1CF1761 VA: 0x1CF1660
	private void <OnSetup>b__9_0(ParticleSystem particle) { }
}

