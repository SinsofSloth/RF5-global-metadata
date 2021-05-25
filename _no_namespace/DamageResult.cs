public struct DamageResult // TypeDefIndex: 8950
{
	// Fields
	public CharacterBase CharacterBase; // 0x0
	public int TotalDamage; // 0x8
	public bool IsCritical; // 0xC
	public float KnockbackPower; // 0x10
	public float CauserKnockbackPower; // 0x14
	public float KnockbackTime; // 0x18
	public Vector3 Direction; // 0x1C
	public float BlowPowerRate; // 0x28
	public bool IsFly; // 0x2C
	public bool IsBlow; // 0x2D
	public bool IsDead; // 0x2E
	public bool IsWeakAttribute; // 0x2F
	public bool IsResistAttribute; // 0x30
	public bool OnPoison; // 0x31
	public bool OnSeal; // 0x32
	public bool OnParalysis; // 0x33
	public bool OnSleep; // 0x34
	public bool OnTire; // 0x35
	public bool OnSick; // 0x36
	public bool OnDeath; // 0x37
	public bool OnStun; // 0x38

	// Methods

	// RVA: 0x2DE820 Offset: 0x2DE921 VA: 0x2DE820
	public void .ctor(CharacterBase characterBase) { }

	// RVA: 0x2DE870 Offset: 0x2DE971 VA: 0x2DE870 Slot: 3
	public override string ToString() { }
}

