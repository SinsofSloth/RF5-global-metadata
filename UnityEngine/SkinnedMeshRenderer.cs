[NativeHeaderAttribute] // RVA: 0xC56C0 Offset: 0xC57C1 VA: 0xC56C0
public class SkinnedMeshRenderer : Renderer // TypeDefIndex: 2933
{
	// Properties
	public SkinQuality quality { get; set; }
	public bool updateWhenOffscreen { get; set; }
	public bool forceMatrixRecalculationPerRender { get; set; }
	public Transform rootBone { get; set; }
	public Transform[] bones { get; set; }
	[NativePropertyAttribute] // RVA: 0xDEB10 Offset: 0xDEC11 VA: 0xDEB10
	public Mesh sharedMesh { get; set; }
	[NativePropertyAttribute] // RVA: 0xDEB50 Offset: 0xDEC51 VA: 0xDEB50
	public bool skinnedMotionVectors { get; set; }
	public Bounds localBounds { get; set; }

	// Methods

	// RVA: 0x2A2B430 Offset: 0x2A2B531 VA: 0x2A2B430
	public SkinQuality get_quality() { }

	// RVA: 0x2A2B480 Offset: 0x2A2B581 VA: 0x2A2B480
	public void set_quality(SkinQuality value) { }

	// RVA: 0x2A2B4D0 Offset: 0x2A2B5D1 VA: 0x2A2B4D0
	public bool get_updateWhenOffscreen() { }

	// RVA: 0x2A2B520 Offset: 0x2A2B621 VA: 0x2A2B520
	public void set_updateWhenOffscreen(bool value) { }

	// RVA: 0x2A2B570 Offset: 0x2A2B671 VA: 0x2A2B570
	public bool get_forceMatrixRecalculationPerRender() { }

	// RVA: 0x2A2B5C0 Offset: 0x2A2B6C1 VA: 0x2A2B5C0
	public void set_forceMatrixRecalculationPerRender(bool value) { }

	// RVA: 0x2A2B610 Offset: 0x2A2B711 VA: 0x2A2B610
	public Transform get_rootBone() { }

	// RVA: 0x2A2B660 Offset: 0x2A2B761 VA: 0x2A2B660
	public void set_rootBone(Transform value) { }

	// RVA: 0x2A2B6B0 Offset: 0x2A2B7B1 VA: 0x2A2B6B0
	public Transform[] get_bones() { }

	// RVA: 0x2A2B700 Offset: 0x2A2B801 VA: 0x2A2B700
	public void set_bones(Transform[] value) { }

	// RVA: 0x2A2B750 Offset: 0x2A2B851 VA: 0x2A2B750
	public Mesh get_sharedMesh() { }

	// RVA: 0x2A2B7A0 Offset: 0x2A2B8A1 VA: 0x2A2B7A0
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x2A2B7F0 Offset: 0x2A2B8F1 VA: 0x2A2B7F0
	public bool get_skinnedMotionVectors() { }

	// RVA: 0x2A2B840 Offset: 0x2A2B941 VA: 0x2A2B840
	public void set_skinnedMotionVectors(bool value) { }

	// RVA: 0x2A2B890 Offset: 0x2A2B991 VA: 0x2A2B890
	public float GetBlendShapeWeight(int index) { }

	// RVA: 0x2A2B8E0 Offset: 0x2A2B9E1 VA: 0x2A2B8E0
	public void SetBlendShapeWeight(int index, float value) { }

	// RVA: 0x2A2B940 Offset: 0x2A2BA41 VA: 0x2A2B940
	public void BakeMesh(Mesh mesh) { }

	[FreeFunctionAttribute] // RVA: 0xD1880 Offset: 0xD1981 VA: 0xD1880
	// RVA: 0x2A2B990 Offset: 0x2A2BA91 VA: 0x2A2B990
	private Bounds GetLocalAABB() { }

	// RVA: 0x2A2BA50 Offset: 0x2A2BB51 VA: 0x2A2BA50
	private void SetLocalAABB(Bounds b) { }

	// RVA: 0x2A2BAF0 Offset: 0x2A2BBF1 VA: 0x2A2BAF0
	public Bounds get_localBounds() { }

	// RVA: 0x2A2BB80 Offset: 0x2A2BC81 VA: 0x2A2BB80
	public void set_localBounds(Bounds value) { }

	// RVA: 0x2A2BBE0 Offset: 0x2A2BCE1 VA: 0x2A2BBE0
	public void .ctor() { }

	// RVA: 0x2A2BA00 Offset: 0x2A2BB01 VA: 0x2A2BA00
	private void GetLocalAABB_Injected(out Bounds ret) { }

	// RVA: 0x2A2BAA0 Offset: 0x2A2BBA1 VA: 0x2A2BAA0
	private void SetLocalAABB_Injected(ref Bounds b) { }
}

