[Serializable]
public class MagicParamDataTable // TypeDefIndex: 6994
{
	// Fields
	public float Attribute_Fire; // 0x10
	public float Attribute_Water; // 0x14
	public float Attribute_Earth; // 0x18
	public float Attribute_Wind; // 0x1C
	public float Attribute_Shine; // 0x20
	public float Attribute_Dark; // 0x24
	public float Attribute_Love; // 0x28
	public AttackType AttackType; // 0x2C
	public int AddAttack; // 0x30
	public float[] AddAttackRate; // 0x38
	public float StrRate; // 0x40
	public float IntRate; // 0x44
	public float DamageRate; // 0x48
	public float LevelRate; // 0x4C
	public float AttackCritical; // 0x50
	public float AttackKnockBackRate; // 0x54
	public float AttackKnockBackTime; // 0x58
	public int AttackBlowPower; // 0x5C
	public Vector3 Direction; // 0x60
	public float AttackStun; // 0x6C
	public float AttackPoison; // 0x70
	public float AttackSeal; // 0x74
	public float AttackParalysis; // 0x78
	public float AttackSleep; // 0x7C
	public float AttackTire; // 0x80
	public float AttackSick; // 0x84
	public float AttackDeath; // 0x88
	public float AttackHpDrain; // 0x8C
	public Parameter Buff; // 0x90
	public FloatParameter BuffPercent; // 0x14C
	public int BuffTimeHour; // 0x208
	public BadStatus HealBadStatus; // 0x20C
	public BadStatus AddBadStatus; // 0x210
	public EffectID UseEffect; // 0x214
	public float EffectScale; // 0x218
	public bool EffectCenter; // 0x21C
	public bool EffectAttach; // 0x21D
	private static MagicParamDataTableArray _MagicParamDataTableArray; // 0x0

	// Methods

	// RVA: 0x1E0E560 Offset: 0x1E0E661 VA: 0x1E0E560
	public static MagicParamDataTable GetDataTable(MagicParamID magicParamID) { }

	// RVA: 0x1E0E700 Offset: 0x1E0E801 VA: 0x1E0E700
	public static bool HasDataTable(MagicParamID magicParamID) { }

	// RVA: 0x1E0E6F0 Offset: 0x1E0E7F1 VA: 0x1E0E6F0
	public void .ctor() { }
}

