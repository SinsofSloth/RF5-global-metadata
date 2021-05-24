[NativeHeaderAttribute] // RVA: 0xEA2D0 Offset: 0xEA3D1 VA: 0xEA2D0
[NativeHeaderAttribute] // RVA: 0xEA2D0 Offset: 0xEA3D1 VA: 0xEA2D0
[UsedByNativeCodeAttribute] // RVA: 0xEA2D0 Offset: 0xEA3D1 VA: 0xEA2D0
[RequireComponent] // RVA: 0xEA2D0 Offset: 0xEA3D1 VA: 0xEA2D0
public sealed class ParentConstraint : Behaviour, IConstraint, IConstraintInternal // TypeDefIndex: 3547
{
	// Properties
	public float weight { get; set; }
	public bool constraintActive { get; set; }
	public bool locked { get; set; }
	public int sourceCount { get; }
	public Vector3 translationAtRest { get; set; }
	public Vector3 rotationAtRest { get; set; }
	public Vector3[] translationOffsets { get; set; }
	public Vector3[] rotationOffsets { get; set; }
	public Axis translationAxis { get; set; }
	public Axis rotationAxis { get; set; }

	// Methods

	// RVA: 0x1AF2830 Offset: 0x1AF2931 VA: 0x1AF2830
	private void .ctor() { }

	// RVA: 0x1AF2890 Offset: 0x1AF2991 VA: 0x1AF2890
	private static void Internal_Create(ParentConstraint self) { }

	// RVA: 0x1AF28E0 Offset: 0x1AF29E1 VA: 0x1AF28E0 Slot: 4
	public float get_weight() { }

	// RVA: 0x1AF2930 Offset: 0x1AF2A31 VA: 0x1AF2930 Slot: 5
	public void set_weight(float value) { }

	// RVA: 0x1AF2980 Offset: 0x1AF2A81 VA: 0x1AF2980 Slot: 6
	public bool get_constraintActive() { }

	// RVA: 0x1AF29D0 Offset: 0x1AF2AD1 VA: 0x1AF29D0 Slot: 7
	public void set_constraintActive(bool value) { }

	// RVA: 0x1AF2A20 Offset: 0x1AF2B21 VA: 0x1AF2A20 Slot: 8
	public bool get_locked() { }

	// RVA: 0x1AF2A70 Offset: 0x1AF2B71 VA: 0x1AF2A70 Slot: 9
	public void set_locked(bool value) { }

	// RVA: 0x1AF2AC0 Offset: 0x1AF2BC1 VA: 0x1AF2AC0 Slot: 10
	public int get_sourceCount() { }

	[FreeFunctionAttribute] // RVA: 0xED400 Offset: 0xED501 VA: 0xED400
	// RVA: 0x1AF2B10 Offset: 0x1AF2C11 VA: 0x1AF2B10
	private static int GetSourceCountInternal(ParentConstraint self) { }

	// RVA: 0x1AF2B60 Offset: 0x1AF2C61 VA: 0x1AF2B60
	public Vector3 get_translationAtRest() { }

	// RVA: 0x1AF2C10 Offset: 0x1AF2D11 VA: 0x1AF2C10
	public void set_translationAtRest(Vector3 value) { }

	// RVA: 0x1AF2CC0 Offset: 0x1AF2DC1 VA: 0x1AF2CC0
	public Vector3 get_rotationAtRest() { }

	// RVA: 0x1AF2D70 Offset: 0x1AF2E71 VA: 0x1AF2D70
	public void set_rotationAtRest(Vector3 value) { }

	// RVA: 0x1AF2E20 Offset: 0x1AF2F21 VA: 0x1AF2E20
	public Vector3[] get_translationOffsets() { }

	// RVA: 0x1AF2E70 Offset: 0x1AF2F71 VA: 0x1AF2E70
	public void set_translationOffsets(Vector3[] value) { }

	// RVA: 0x1AF2EC0 Offset: 0x1AF2FC1 VA: 0x1AF2EC0
	public Vector3[] get_rotationOffsets() { }

	// RVA: 0x1AF2F10 Offset: 0x1AF3011 VA: 0x1AF2F10
	public void set_rotationOffsets(Vector3[] value) { }

	// RVA: 0x1AF2F60 Offset: 0x1AF3061 VA: 0x1AF2F60
	public Axis get_translationAxis() { }

	// RVA: 0x1AF2FB0 Offset: 0x1AF30B1 VA: 0x1AF2FB0
	public void set_translationAxis(Axis value) { }

	// RVA: 0x1AF3000 Offset: 0x1AF3101 VA: 0x1AF3000
	public Axis get_rotationAxis() { }

	// RVA: 0x1AF3050 Offset: 0x1AF3151 VA: 0x1AF3050
	public void set_rotationAxis(Axis value) { }

	// RVA: 0x1AF30A0 Offset: 0x1AF31A1 VA: 0x1AF30A0
	public Vector3 GetTranslationOffset(int index) { }

	// RVA: 0x1AF3320 Offset: 0x1AF3421 VA: 0x1AF3320
	public void SetTranslationOffset(int index, Vector3 value) { }

	[NativeNameAttribute] // RVA: 0xED440 Offset: 0xED541 VA: 0xED440
	// RVA: 0x1AF32B0 Offset: 0x1AF33B1 VA: 0x1AF32B0
	private Vector3 GetTranslationOffsetInternal(int index) { }

	[NativeNameAttribute] // RVA: 0xED480 Offset: 0xED581 VA: 0xED480
	// RVA: 0x1AF33B0 Offset: 0x1AF34B1 VA: 0x1AF33B0
	private void SetTranslationOffsetInternal(int index, Vector3 value) { }

	// RVA: 0x1AF34E0 Offset: 0x1AF35E1 VA: 0x1AF34E0
	public Vector3 GetRotationOffset(int index) { }

	// RVA: 0x1AF35D0 Offset: 0x1AF36D1 VA: 0x1AF35D0
	public void SetRotationOffset(int index, Vector3 value) { }

	[NativeNameAttribute] // RVA: 0xED4C0 Offset: 0xED5C1 VA: 0xED4C0
	// RVA: 0x1AF3560 Offset: 0x1AF3661 VA: 0x1AF3560
	private Vector3 GetRotationOffsetInternal(int index) { }

	[NativeNameAttribute] // RVA: 0xED500 Offset: 0xED601 VA: 0xED500
	// RVA: 0x1AF3660 Offset: 0x1AF3761 VA: 0x1AF3660
	private void SetRotationOffsetInternal(int index, Vector3 value) { }

	// RVA: 0x1AF3120 Offset: 0x1AF3221 VA: 0x1AF3120
	private void ValidateSourceIndex(int index) { }

	[FreeFunctionAttribute] // RVA: 0xED540 Offset: 0xED641 VA: 0xED540
	// RVA: 0x1AF3790 Offset: 0x1AF3891 VA: 0x1AF3790 Slot: 11
	public void GetSources(List<ConstraintSource> sources) { }

	// RVA: 0x1AF37E0 Offset: 0x1AF38E1 VA: 0x1AF37E0 Slot: 12
	public void SetSources(List<ConstraintSource> sources) { }

	[FreeFunctionAttribute] // RVA: 0xED590 Offset: 0xED691 VA: 0xED590
	// RVA: 0x1AF38A0 Offset: 0x1AF39A1 VA: 0x1AF38A0
	private static void SetSourcesInternal(ParentConstraint self, List<ConstraintSource> sources) { }

	// RVA: 0x1AF38F0 Offset: 0x1AF39F1 VA: 0x1AF38F0 Slot: 13
	public int AddSource(ConstraintSource source) { }

	// RVA: 0x1AF39A0 Offset: 0x1AF3AA1 VA: 0x1AF39A0 Slot: 14
	public void RemoveSource(int index) { }

	[NativeNameAttribute] // RVA: 0xED5D0 Offset: 0xED6D1 VA: 0xED5D0
	// RVA: 0x1AF3A00 Offset: 0x1AF3B01 VA: 0x1AF3A00
	private void RemoveSourceInternal(int index) { }

	// RVA: 0x1AF3A50 Offset: 0x1AF3B51 VA: 0x1AF3A50 Slot: 15
	public ConstraintSource GetSource(int index) { }

	[NativeNameAttribute] // RVA: 0xED610 Offset: 0xED711 VA: 0xED610
	// RVA: 0x1AF3AC0 Offset: 0x1AF3BC1 VA: 0x1AF3AC0
	private ConstraintSource GetSourceInternal(int index) { }

	// RVA: 0x1AF3B90 Offset: 0x1AF3C91 VA: 0x1AF3B90 Slot: 16
	public void SetSource(int index, ConstraintSource source) { }

	[NativeNameAttribute] // RVA: 0xED650 Offset: 0xED751 VA: 0xED650
	// RVA: 0x1AF3C00 Offset: 0x1AF3D01 VA: 0x1AF3C00
	private void SetSourceInternal(int index, ConstraintSource source) { }

	// RVA: 0x1AF2BC0 Offset: 0x1AF2CC1 VA: 0x1AF2BC0
	private void get_translationAtRest_Injected(out Vector3 ret) { }

	// RVA: 0x1AF2C70 Offset: 0x1AF2D71 VA: 0x1AF2C70
	private void set_translationAtRest_Injected(ref Vector3 value) { }

	// RVA: 0x1AF2D20 Offset: 0x1AF2E21 VA: 0x1AF2D20
	private void get_rotationAtRest_Injected(out Vector3 ret) { }

	// RVA: 0x1AF2DD0 Offset: 0x1AF2ED1 VA: 0x1AF2DD0
	private void set_rotationAtRest_Injected(ref Vector3 value) { }

	// RVA: 0x1AF3420 Offset: 0x1AF3521 VA: 0x1AF3420
	private void GetTranslationOffsetInternal_Injected(int index, out Vector3 ret) { }

	// RVA: 0x1AF3480 Offset: 0x1AF3581 VA: 0x1AF3480
	private void SetTranslationOffsetInternal_Injected(int index, ref Vector3 value) { }

	// RVA: 0x1AF36D0 Offset: 0x1AF37D1 VA: 0x1AF36D0
	private void GetRotationOffsetInternal_Injected(int index, out Vector3 ret) { }

	// RVA: 0x1AF3730 Offset: 0x1AF3831 VA: 0x1AF3730
	private void SetRotationOffsetInternal_Injected(int index, ref Vector3 value) { }

	// RVA: 0x1AF3950 Offset: 0x1AF3A51 VA: 0x1AF3950 Slot: 17
	private int AddSource_Injected(ref ConstraintSource source) { }

	// RVA: 0x1AF3B30 Offset: 0x1AF3C31 VA: 0x1AF3B30
	private void GetSourceInternal_Injected(int index, out ConstraintSource ret) { }

	// RVA: 0x1AF3C70 Offset: 0x1AF3D71 VA: 0x1AF3C70
	private void SetSourceInternal_Injected(int index, ref ConstraintSource source) { }
}

