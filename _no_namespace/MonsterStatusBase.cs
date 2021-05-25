public abstract class MonsterStatusBase : CharacterStatusBase // TypeDefIndex: 8302
{
	// Fields
	public Character _Owner; // 0x220
	[CompilerGeneratedAttribute] // RVA: 0x16EB00 Offset: 0x16EC01 VA: 0x16EB00
	private float <RestraintCounter>k__BackingField; // 0x228
	[CompilerGeneratedAttribute] // RVA: 0x16EB10 Offset: 0x16EC11 VA: 0x16EB10
	private float <RestraintReleseTimer>k__BackingField; // 0x22C

	// Properties
	public abstract int BrushCount { get; set; }
	public abstract int PresentCount { get; set; }
	public abstract string Name { get; }
	public abstract MonsterDataID MonsterDataID { get; }
	public override Character Owner { get; }
	public float RestraintCounter { get; set; }
	public float RestraintReleseTimer { get; set; }
	public bool IsRestraint { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 22
	public abstract int get_BrushCount() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void set_BrushCount(int value) { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract int get_PresentCount() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void set_PresentCount(int value) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract MonsterDataID get_MonsterDataID() { }

	// RVA: 0x1CD7960 Offset: 0x1CD7A61 VA: 0x1CD7960 Slot: 13
	protected override CharaParamDataTable GetCharaParam() { }

	// RVA: 0x1CD79A0 Offset: 0x1CD7AA1 VA: 0x1CD79A0 Slot: 4
	public override Character get_Owner() { }

	// RVA: 0x1CD79B0 Offset: 0x1CD7AB1 VA: 0x1CD79B0
	public void SetOwner(Character owner) { }

	// RVA: 0x1CD79C0 Offset: 0x1CD7AC1 VA: 0x1CD79C0 Slot: 19
	public override DamageInfo CreateMagicDamageInfo(MagicParamDataTable dataTable, int level) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6BE0 Offset: 0x1A6CE1 VA: 0x1A6BE0
	// RVA: 0x1CD7E20 Offset: 0x1CD7F21 VA: 0x1CD7E20
	public float get_RestraintCounter() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6BF0 Offset: 0x1A6CF1 VA: 0x1A6BF0
	// RVA: 0x1CD7E30 Offset: 0x1CD7F31 VA: 0x1CD7E30
	private void set_RestraintCounter(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6C00 Offset: 0x1A6D01 VA: 0x1A6C00
	// RVA: 0x1CD7E40 Offset: 0x1CD7F41 VA: 0x1CD7E40
	public float get_RestraintReleseTimer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6C10 Offset: 0x1A6D11 VA: 0x1A6C10
	// RVA: 0x1CD7E50 Offset: 0x1CD7F51 VA: 0x1CD7E50
	private void set_RestraintReleseTimer(float value) { }

	// RVA: 0x1CD4D00 Offset: 0x1CD4E01 VA: 0x1CD4D00
	public bool get_IsRestraint() { }

	// RVA: 0x1CD7E60 Offset: 0x1CD7F61 VA: 0x1CD7E60
	public bool TakeRestraintDamage(float damage) { }

	// RVA: 0x1CD7F90 Offset: 0x1CD8091 VA: 0x1CD7F90 Slot: 15
	public override void UpdateStatus() { }

	// RVA: 0x1CD80D0 Offset: 0x1CD81D1 VA: 0x1CD80D0
	protected void .ctor() { }
}

