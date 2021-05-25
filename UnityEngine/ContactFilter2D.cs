[NativeClassAttribute] // RVA: 0xFAE20 Offset: 0xFAF21 VA: 0xFAE20
[NativeHeaderAttribute] // RVA: 0xFAE20 Offset: 0xFAF21 VA: 0xFAE20
[RequiredByNativeCodeAttribute] // RVA: 0xFAE20 Offset: 0xFAF21 VA: 0xFAE20
[Serializable]
public struct ContactFilter2D // TypeDefIndex: 3641
{
	// Fields
	[NativeNameAttribute] // RVA: 0xFB280 Offset: 0xFB381 VA: 0xFB280
	public bool useTriggers; // 0x0
	[NativeNameAttribute] // RVA: 0xFB2C0 Offset: 0xFB3C1 VA: 0xFB2C0
	public bool useLayerMask; // 0x1
	[NativeNameAttribute] // RVA: 0xFB300 Offset: 0xFB401 VA: 0xFB300
	public bool useDepth; // 0x2
	[NativeNameAttribute] // RVA: 0xFB340 Offset: 0xFB441 VA: 0xFB340
	public bool useOutsideDepth; // 0x3
	[NativeNameAttribute] // RVA: 0xFB380 Offset: 0xFB481 VA: 0xFB380
	public bool useNormalAngle; // 0x4
	[NativeNameAttribute] // RVA: 0xFB3C0 Offset: 0xFB4C1 VA: 0xFB3C0
	public bool useOutsideNormalAngle; // 0x5
	[NativeNameAttribute] // RVA: 0xFB400 Offset: 0xFB501 VA: 0xFB400
	public LayerMask layerMask; // 0x8
	[NativeNameAttribute] // RVA: 0xFB440 Offset: 0xFB541 VA: 0xFB440
	public float minDepth; // 0xC
	[NativeNameAttribute] // RVA: 0xFB480 Offset: 0xFB581 VA: 0xFB480
	public float maxDepth; // 0x10
	[NativeNameAttribute] // RVA: 0xFB4C0 Offset: 0xFB5C1 VA: 0xFB4C0
	public float minNormalAngle; // 0x14
	[NativeNameAttribute] // RVA: 0xFB500 Offset: 0xFB601 VA: 0xFB500
	public float maxNormalAngle; // 0x18

	// Methods

	// RVA: 0x23F00 Offset: 0x24001 VA: 0x23F00
	private void CheckConsistency() { }

	// RVA: 0x23F50 Offset: 0x24051 VA: 0x23F50
	public void SetLayerMask(LayerMask layerMask) { }

	// RVA: 0x23F60 Offset: 0x24061 VA: 0x23F60
	public void SetDepth(float minDepth, float maxDepth) { }

	// RVA: 0x1BC3C30 Offset: 0x1BC3D31 VA: 0x1BC3C30
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	// RVA: 0x1BC3B70 Offset: 0x1BC3C71 VA: 0x1BC3B70
	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }
}

