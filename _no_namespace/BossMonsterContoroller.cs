public class BossMonsterContoroller : MonsterControllerBase // TypeDefIndex: 7823
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x169B20 Offset: 0x169C21 VA: 0x169B20
	private bool <IsMadness>k__BackingField; // 0x500
	protected bool IsCreateMadnessEffect; // 0x501
	protected bool IsFirstDead; // 0x502
	protected List<ParticleSystem> MadnessEffectList; // 0x508

	// Properties
	protected bool IsMadness { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A30F0 Offset: 0x1A31F1 VA: 0x1A30F0
	// RVA: 0x205B7E0 Offset: 0x205B8E1 VA: 0x205B7E0
	private void set_IsMadness(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3100 Offset: 0x1A3201 VA: 0x1A3100
	// RVA: 0x205B7F0 Offset: 0x205B8F1 VA: 0x205B7F0
	protected bool get_IsMadness() { }

	// RVA: 0x205B800 Offset: 0x205B901 VA: 0x205B800
	public void SetFirstDeadFlag(bool isFristDead) { }

	// RVA: 0x205B810 Offset: 0x205B911 VA: 0x205B810 Slot: 156
	protected override bool CanFriend() { }

	// RVA: 0x205B830 Offset: 0x205B931 VA: 0x205B830 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x205B870 Offset: 0x205B971 VA: 0x205B870 Slot: 124
	protected override void DoDropItem() { }

	// RVA: 0x205B890 Offset: 0x205B991 VA: 0x205B890 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x205B8D0 Offset: 0x205B9D1 VA: 0x205B8D0 Slot: 138
	public override void OnRestraint() { }

	// RVA: 0x205B990 Offset: 0x205BA91 VA: 0x205B990 Slot: 139
	public override void OnRelease() { }

	// RVA: 0x205BA40 Offset: 0x205BB41 VA: 0x205BA40 Slot: 21
	public override void OnEvent(int index) { }

	// RVA: 0x205BAB0 Offset: 0x205BBB1 VA: 0x205BAB0 Slot: 115
	protected override void OnTakeDamage(bool isDamage, ref DamageInfo damageInfo, ref DamageResult damageResult) { }

	// RVA: 0x205BB60 Offset: 0x205BC61 VA: 0x205BB60 Slot: 158
	public virtual void CreateMadnessEffect(ParticleSystem prefab, List<string> boneNameList, float scaleValue) { }

	// RVA: 0x205BF30 Offset: 0x205C031 VA: 0x205BF30
	public void .ctor() { }
}

