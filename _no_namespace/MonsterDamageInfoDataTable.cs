[Serializable]
public class MonsterDamageInfoDataTable // TypeDefIndex: 7769
{
	// Fields
	[SerializeField] // RVA: 0x1692D0 Offset: 0x1693D1 VA: 0x1692D0
	public bool SealFlag; // 0x10
	[SerializeField] // RVA: 0x1692E0 Offset: 0x1693E1 VA: 0x1692E0
	public AttackType AttackType; // 0x14
	[SerializeField] // RVA: 0x1692F0 Offset: 0x1693F1 VA: 0x1692F0
	public float MotionPower; // 0x18
	[SerializeField] // RVA: 0x169300 Offset: 0x169401 VA: 0x169300
	public float FriendlyMotionPower; // 0x1C
	[SerializeField] // RVA: 0x169310 Offset: 0x169411 VA: 0x169310
	public float KnockbackPower; // 0x20
	[SerializeField] // RVA: 0x169320 Offset: 0x169421 VA: 0x169320
	public int BlowAttackPower; // 0x24
	[SerializeField] // RVA: 0x169330 Offset: 0x169431 VA: 0x169330
	public Vector3 Direction; // 0x28
	[SerializeField] // RVA: 0x169340 Offset: 0x169441 VA: 0x169340
	public int PercentDamage; // 0x34
	[SerializeField] // RVA: 0x169350 Offset: 0x169451 VA: 0x169350
	public int TrueDamage; // 0x38
	[SerializeField] // RVA: 0x169360 Offset: 0x169461 VA: 0x169360
	public bool Attribute_Fire; // 0x3C
	[SerializeField] // RVA: 0x169370 Offset: 0x169471 VA: 0x169370
	public bool Attribute_Water; // 0x3D
	[SerializeField] // RVA: 0x169380 Offset: 0x169481 VA: 0x169380
	public bool Attribute_Earth; // 0x3E
	[SerializeField] // RVA: 0x169390 Offset: 0x169491 VA: 0x169390
	public bool Attribute_Wind; // 0x3F
	[SerializeField] // RVA: 0x1693A0 Offset: 0x1694A1 VA: 0x1693A0
	public bool Attribute_Shine; // 0x40
	[SerializeField] // RVA: 0x1693B0 Offset: 0x1694B1 VA: 0x1693B0
	public bool Attribute_Dark; // 0x41
	[SerializeField] // RVA: 0x1693C0 Offset: 0x1694C1 VA: 0x1693C0
	public bool Attribute_Love; // 0x42
	[SerializeField] // RVA: 0x1693D0 Offset: 0x1694D1 VA: 0x1693D0
	public float AttackStun; // 0x44
	[SerializeField] // RVA: 0x1693E0 Offset: 0x1694E1 VA: 0x1693E0
	public float AttackPoison; // 0x48
	[SerializeField] // RVA: 0x1693F0 Offset: 0x1694F1 VA: 0x1693F0
	public float AttackParalysis; // 0x4C
	[SerializeField] // RVA: 0x169400 Offset: 0x169501 VA: 0x169400
	public float AttackSleep; // 0x50
	[SerializeField] // RVA: 0x169410 Offset: 0x169511 VA: 0x169410
	public float AttackTire; // 0x54
	[SerializeField] // RVA: 0x169420 Offset: 0x169521 VA: 0x169420
	public float AttackSick; // 0x58
	[SerializeField] // RVA: 0x169430 Offset: 0x169531 VA: 0x169430
	public float AttackDeath; // 0x5C
	[SerializeField] // RVA: 0x169440 Offset: 0x169541 VA: 0x169440
	public float AttackHpDrain; // 0x60
	[SerializeField] // RVA: 0x169450 Offset: 0x169551 VA: 0x169450
	public float AttackSeal; // 0x64
	[SerializeField] // RVA: 0x169460 Offset: 0x169561 VA: 0x169460
	public bool HealStun; // 0x68
	[SerializeField] // RVA: 0x169470 Offset: 0x169571 VA: 0x169470
	public bool HealPoison; // 0x69
	[SerializeField] // RVA: 0x169480 Offset: 0x169581 VA: 0x169480
	public bool HealParalysis; // 0x6A
	[SerializeField] // RVA: 0x169490 Offset: 0x169591 VA: 0x169490
	public bool HealSleep; // 0x6B
	[SerializeField] // RVA: 0x1694A0 Offset: 0x1695A1 VA: 0x1694A0
	public bool HealTire; // 0x6C
	[SerializeField] // RVA: 0x1694B0 Offset: 0x1695B1 VA: 0x1694B0
	public bool HealSick; // 0x6D
	[SerializeField] // RVA: 0x1694C0 Offset: 0x1695C1 VA: 0x1694C0
	public bool HealDeath; // 0x6E
	[SerializeField] // RVA: 0x1694D0 Offset: 0x1695D1 VA: 0x1694D0
	public bool HealSeal; // 0x6F
	[SerializeField] // RVA: 0x1694E0 Offset: 0x1695E1 VA: 0x1694E0
	public bool IsHideDamageText; // 0x70
	[SerializeField] // RVA: 0x1694F0 Offset: 0x1695F1 VA: 0x1694F0
	public bool IsHideDamageEffect; // 0x71
	[SerializeField] // RVA: 0x169500 Offset: 0x169601 VA: 0x169500
	public bool IsNotJustAvoid; // 0x72
	private static MonsterDamageInfoDataTableArray _MonsterDamageInfoTableArray; // 0x0

	// Methods

	// RVA: 0x2170BD0 Offset: 0x2170CD1 VA: 0x2170BD0
	public static MonsterDamageInfoDataTable GetDataTable(MonsterDamageInfoID monsterDamageInfoID) { }

	// RVA: 0x2170D20 Offset: 0x2170E21 VA: 0x2170D20
	public void .ctor() { }
}

