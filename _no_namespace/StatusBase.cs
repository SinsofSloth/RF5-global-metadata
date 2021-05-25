public abstract class StatusBase // TypeDefIndex: 8304
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16EB40 Offset: 0x16EC41 VA: 0x16EB40
	private Character <Owner>k__BackingField; // 0x10
	public Parameter CurrentParameter; // 0x18
	public EquipSubAttributeCollection SubAttributes; // 0xD8
	public UnityEvent OnDead; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x16EB50 Offset: 0x16EC51 VA: 0x16EB50
	private float <DamageRate>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x16EB60 Offset: 0x16EC61 VA: 0x16EB60
	private bool <IsNotDeath>k__BackingField; // 0xEC

	// Properties
	public virtual Character Owner { get; set; }
	public abstract Alliance Alliance { get; }
	public virtual HumanEquip EquipItem { get; }
	public abstract int Hp { get; set; }
	public bool IsDead { get; }
	public bool IsSuperArmor { get; }
	public float DamageRate { get; set; }
	public bool IsNotDeath { get; set; }
	public int CurrentAttack { get; }
	public int CurrentMagicAttack { get; }
	public int MaxHp { get; }
	public int MaxRp { get; }
	public int Attack { get; }
	public int Defense { get; }
	public int MagicAttack { get; }
	public int MagicDefense { get; }
	public int Strength { get; }
	public int Intelligence { get; }
	public int Vitality { get; }
	public float HPPercent { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6C60 Offset: 0x1A6D61 VA: 0x1A6C60
	// RVA: 0x224B760 Offset: 0x224B861 VA: 0x224B760 Slot: 4
	public virtual Character get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6C70 Offset: 0x1A6D71 VA: 0x1A6C70
	// RVA: 0x224B770 Offset: 0x224B871 VA: 0x224B770 Slot: 5
	protected virtual void set_Owner(Character value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Alliance get_Alliance() { }

	// RVA: 0x224B780 Offset: 0x224B881 VA: 0x224B780 Slot: 7
	public virtual HumanEquip get_EquipItem() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Hp() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_Hp(int value) { }

	// RVA: 0x224B790 Offset: 0x224B891 VA: 0x224B790
	public bool get_IsDead() { }

	// RVA: 0x224B7C0 Offset: 0x224B8C1 VA: 0x224B7C0
	public bool get_IsSuperArmor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6C80 Offset: 0x1A6D81 VA: 0x1A6C80
	// RVA: 0x224B880 Offset: 0x224B981 VA: 0x224B880
	public float get_DamageRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6C90 Offset: 0x1A6D91 VA: 0x1A6C90
	// RVA: 0x224B890 Offset: 0x224B991 VA: 0x224B890
	public void set_DamageRate(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6CA0 Offset: 0x1A6DA1 VA: 0x1A6CA0
	// RVA: 0x224B8A0 Offset: 0x224B9A1 VA: 0x224B8A0
	public bool get_IsNotDeath() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6CB0 Offset: 0x1A6DB1 VA: 0x1A6CB0
	// RVA: 0x224B8B0 Offset: 0x224B9B1 VA: 0x224B8B0
	public void set_IsNotDeath(bool value) { }

	// RVA: 0x224B8C0 Offset: 0x224B9C1 VA: 0x224B8C0
	public int get_CurrentAttack() { }

	// RVA: 0x224B960 Offset: 0x224BA61 VA: 0x224B960
	public int get_CurrentMagicAttack() { }

	// RVA: 0x224BA00 Offset: 0x224BB01 VA: 0x224BA00 Slot: 10
	public virtual void Renew() { }

	// RVA: 0x224BC00 Offset: 0x224BD01 VA: 0x224BC00 Slot: 11
	public virtual bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x224C850 Offset: 0x224C951 VA: 0x224C850
	private void DispDamageText(DamageInfo damageInfo, DamageResult damageResult) { }

	// RVA: 0x224C7B0 Offset: 0x224C8B1 VA: 0x224C7B0
	public bool IsPartyMonster() { }

	// RVA: 0x224C6C0 Offset: 0x224C7C1 VA: 0x224C6C0
	public static bool IsParty(ActorID actorID) { }

	// RVA: 0x224C6A0 Offset: 0x224C7A1 VA: 0x224C6A0
	public static bool IsFamily(ActorID actorID) { }

	// RVA: 0x224C9F0 Offset: 0x224CAF1 VA: 0x224C9F0
	private static bool IsMarried(ActorID actorID) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract ValueTuple<Parameter, EquipSubAttributeCollection> CalcCurrentParameter(HumanEquip humanEquip, bool isWeapon) { }

	// RVA: 0x224BB50 Offset: 0x224BC51 VA: 0x224BB50
	public int get_MaxHp() { }

	// RVA: 0x224CAA0 Offset: 0x224CBA1 VA: 0x224CAA0
	public int get_MaxRp() { }

	// RVA: 0x224CAB0 Offset: 0x224CBB1 VA: 0x224CAB0
	public int get_Attack() { }

	// RVA: 0x224CAC0 Offset: 0x224CBC1 VA: 0x224CAC0
	public int get_Defense() { }

	// RVA: 0x224CAD0 Offset: 0x224CBD1 VA: 0x224CAD0
	public int get_MagicAttack() { }

	// RVA: 0x224CAE0 Offset: 0x224CBE1 VA: 0x224CAE0
	public int get_MagicDefense() { }

	// RVA: 0x224CAF0 Offset: 0x224CBF1 VA: 0x224CAF0
	public int get_Strength() { }

	// RVA: 0x224CB00 Offset: 0x224CC01 VA: 0x224CB00
	public int get_Intelligence() { }

	// RVA: 0x224CB10 Offset: 0x224CC11 VA: 0x224CB10
	public int get_Vitality() { }

	// RVA: 0x224CB20 Offset: 0x224CC21 VA: 0x224CB20
	public float get_HPPercent() { }

	// RVA: 0x224CBC0 Offset: 0x224CCC1 VA: 0x224CBC0
	protected void .ctor() { }
}

