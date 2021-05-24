public class WkiController : MonoBehaviour // TypeDefIndex: 10310
{
	// Fields
	[SerializeField] // RVA: 0x1811A0 Offset: 0x1812A1 VA: 0x1811A0
	private WkiMove m_Move; // 0x18
	[SerializeField] // RVA: 0x1811B0 Offset: 0x1812B1 VA: 0x1811B0
	private WkiSphereCollider m_Collider; // 0x20
	[SerializeField] // RVA: 0x1811C0 Offset: 0x1812C1 VA: 0x1811C0
	[RangeAttribute] // RVA: 0x1811C0 Offset: 0x1812C1 VA: 0x1811C0
	private float heightLlimit; // 0x28
	private float startHeight; // 0x2C
	public DamageInfo m_DamageInfo; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x181200 Offset: 0x181301 VA: 0x181200
	private Character <Owner>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x181210 Offset: 0x181311 VA: 0x181210
	private bool <IsHitWater>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x181220 Offset: 0x181321 VA: 0x181220
	private bool <IsHitGround>k__BackingField; // 0xB9

	// Properties
	public Character Owner { get; set; }
	public bool IsHit { get; }
	public bool IsHitWater { get; set; }
	public bool IsHitGround { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AE110 Offset: 0x1AE211 VA: 0x1AE110
	// RVA: 0x1D4CDF0 Offset: 0x1D4CEF1 VA: 0x1D4CDF0
	public Character get_Owner() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE120 Offset: 0x1AE221 VA: 0x1AE120
	// RVA: 0x1D4CE00 Offset: 0x1D4CF01 VA: 0x1D4CE00
	public void set_Owner(Character value) { }

	// RVA: 0x1D4CE10 Offset: 0x1D4CF11 VA: 0x1D4CE10
	public bool get_IsHit() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE130 Offset: 0x1AE231 VA: 0x1AE130
	// RVA: 0x1D4CE20 Offset: 0x1D4CF21 VA: 0x1D4CE20
	public bool get_IsHitWater() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE140 Offset: 0x1AE241 VA: 0x1AE140
	// RVA: 0x1D4CE30 Offset: 0x1D4CF31 VA: 0x1D4CE30
	protected void set_IsHitWater(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE150 Offset: 0x1AE251 VA: 0x1AE150
	// RVA: 0x1D4CE40 Offset: 0x1D4CF41 VA: 0x1D4CE40
	public bool get_IsHitGround() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AE160 Offset: 0x1AE261 VA: 0x1AE160
	// RVA: 0x1D4CE50 Offset: 0x1D4CF51 VA: 0x1D4CE50
	protected void set_IsHitGround(bool value) { }

	// RVA: 0x1D4CE60 Offset: 0x1D4CF61 VA: 0x1D4CE60
	public void Reset(Character chara, Vector3 pos, Quaternion dir) { }

	// RVA: 0x1D4D240 Offset: 0x1D4D341 VA: 0x1D4D240
	private void FixedUpdate() { }

	// RVA: 0x1D4D580 Offset: 0x1D4D681 VA: 0x1D4D580
	public void OnHit(Collider hit, Vector3 point) { }

	// RVA: 0x1D4D730 Offset: 0x1D4D831 VA: 0x1D4D730
	public bool OnHitWater(Collider hit, Vector3 point) { }

	// RVA: 0x1D4DD40 Offset: 0x1D4DE41 VA: 0x1D4DD40
	public bool OnHitChara(Character chara, Vector3 point) { }

	// RVA: 0x1D4DFF0 Offset: 0x1D4E0F1 VA: 0x1D4DFF0
	public void .ctor() { }
}

