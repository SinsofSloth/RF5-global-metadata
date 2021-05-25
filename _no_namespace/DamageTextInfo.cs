public struct DamageTextInfo // TypeDefIndex: 8282
{
	// Fields
	public UIDamageType UIDamageType; // 0x0
	public int Value; // 0x4
	public Vector3 position; // 0x8
	public bool IsCritical; // 0x14
	public bool IsWeek; // 0x15
	public bool IsRegist; // 0x16

	// Methods

	// RVA: 0x2DE930 Offset: 0x2DEA31 VA: 0x2DE930
	public void .ctor(UIDamageType uIDamageType, int value, Vector3 position, bool isCritical = False, bool isWeek = False, bool isRegist = False) { }
}

