[RequireComponent] // RVA: 0xEA150 Offset: 0xEA251 VA: 0xEA150
[NativeHeaderAttribute] // RVA: 0xEA150 Offset: 0xEA251 VA: 0xEA150
[UsedByNativeCodeAttribute] // RVA: 0xEA150 Offset: 0xEA251 VA: 0xEA150
[NativeHeaderAttribute] // RVA: 0xEA150 Offset: 0xEA251 VA: 0xEA150
public sealed class PositionConstraint : Behaviour, IConstraint, IConstraintInternal // TypeDefIndex: 3545
{
	// Properties
	public float weight { get; set; }
	public Vector3 translationAtRest { get; set; }
	public Vector3 translationOffset { get; set; }
	public Axis translationAxis { get; set; }
	public bool constraintActive { get; set; }
	public bool locked { get; set; }
	public int sourceCount { get; }

	// Methods

	// RVA: 0x1AF3CD0 Offset: 0x1AF3DD1 VA: 0x1AF3CD0
	private void .ctor() { }

	// RVA: 0x1AF3D30 Offset: 0x1AF3E31 VA: 0x1AF3D30
	private static void Internal_Create(PositionConstraint self) { }

	// RVA: 0x1AF3D80 Offset: 0x1AF3E81 VA: 0x1AF3D80 Slot: 4
	public float get_weight() { }

	// RVA: 0x1AF3DD0 Offset: 0x1AF3ED1 VA: 0x1AF3DD0 Slot: 5
	public void set_weight(float value) { }

	// RVA: 0x1AF3E20 Offset: 0x1AF3F21 VA: 0x1AF3E20
	public Vector3 get_translationAtRest() { }

	// RVA: 0x1AF3ED0 Offset: 0x1AF3FD1 VA: 0x1AF3ED0
	public void set_translationAtRest(Vector3 value) { }

	// RVA: 0x1AF3F80 Offset: 0x1AF4081 VA: 0x1AF3F80
	public Vector3 get_translationOffset() { }

	// RVA: 0x1AF4030 Offset: 0x1AF4131 VA: 0x1AF4030
	public void set_translationOffset(Vector3 value) { }

	// RVA: 0x1AF40E0 Offset: 0x1AF41E1 VA: 0x1AF40E0
	public Axis get_translationAxis() { }

	// RVA: 0x1AF4130 Offset: 0x1AF4231 VA: 0x1AF4130
	public void set_translationAxis(Axis value) { }

	// RVA: 0x1AF4180 Offset: 0x1AF4281 VA: 0x1AF4180 Slot: 6
	public bool get_constraintActive() { }

	// RVA: 0x1AF41D0 Offset: 0x1AF42D1 VA: 0x1AF41D0 Slot: 7
	public void set_constraintActive(bool value) { }

	// RVA: 0x1AF4220 Offset: 0x1AF4321 VA: 0x1AF4220 Slot: 8
	public bool get_locked() { }

	// RVA: 0x1AF4270 Offset: 0x1AF4371 VA: 0x1AF4270 Slot: 9
	public void set_locked(bool value) { }

	// RVA: 0x1AF42C0 Offset: 0x1AF43C1 VA: 0x1AF42C0 Slot: 10
	public int get_sourceCount() { }

	[FreeFunctionAttribute] // RVA: 0xED0E0 Offset: 0xED1E1 VA: 0xED0E0
	// RVA: 0x1AF4310 Offset: 0x1AF4411 VA: 0x1AF4310
	private static int GetSourceCountInternal(PositionConstraint self) { }

	[FreeFunctionAttribute] // RVA: 0xED120 Offset: 0xED221 VA: 0xED120
	// RVA: 0x1AF4360 Offset: 0x1AF4461 VA: 0x1AF4360 Slot: 11
	public void GetSources(List<ConstraintSource> sources) { }

	// RVA: 0x1AF43B0 Offset: 0x1AF44B1 VA: 0x1AF43B0 Slot: 12
	public void SetSources(List<ConstraintSource> sources) { }

	[FreeFunctionAttribute] // RVA: 0xED170 Offset: 0xED271 VA: 0xED170
	// RVA: 0x1AF4470 Offset: 0x1AF4571 VA: 0x1AF4470
	private static void SetSourcesInternal(PositionConstraint self, List<ConstraintSource> sources) { }

	// RVA: 0x1AF44C0 Offset: 0x1AF45C1 VA: 0x1AF44C0 Slot: 13
	public int AddSource(ConstraintSource source) { }

	// RVA: 0x1AF4570 Offset: 0x1AF4671 VA: 0x1AF4570 Slot: 14
	public void RemoveSource(int index) { }

	[NativeNameAttribute] // RVA: 0xED1B0 Offset: 0xED2B1 VA: 0xED1B0
	// RVA: 0x1AF4760 Offset: 0x1AF4861 VA: 0x1AF4760
	private void RemoveSourceInternal(int index) { }

	// RVA: 0x1AF47B0 Offset: 0x1AF48B1 VA: 0x1AF47B0 Slot: 15
	public ConstraintSource GetSource(int index) { }

	[NativeNameAttribute] // RVA: 0xED1F0 Offset: 0xED2F1 VA: 0xED1F0
	// RVA: 0x1AF4820 Offset: 0x1AF4921 VA: 0x1AF4820
	private ConstraintSource GetSourceInternal(int index) { }

	// RVA: 0x1AF48F0 Offset: 0x1AF49F1 VA: 0x1AF48F0 Slot: 16
	public void SetSource(int index, ConstraintSource source) { }

	[NativeNameAttribute] // RVA: 0xED230 Offset: 0xED331 VA: 0xED230
	// RVA: 0x1AF4960 Offset: 0x1AF4A61 VA: 0x1AF4960
	private void SetSourceInternal(int index, ConstraintSource source) { }

	// RVA: 0x1AF45D0 Offset: 0x1AF46D1 VA: 0x1AF45D0
	private void ValidateSourceIndex(int index) { }

	// RVA: 0x1AF3E80 Offset: 0x1AF3F81 VA: 0x1AF3E80
	private void get_translationAtRest_Injected(out Vector3 ret) { }

	// RVA: 0x1AF3F30 Offset: 0x1AF4031 VA: 0x1AF3F30
	private void set_translationAtRest_Injected(ref Vector3 value) { }

	// RVA: 0x1AF3FE0 Offset: 0x1AF40E1 VA: 0x1AF3FE0
	private void get_translationOffset_Injected(out Vector3 ret) { }

	// RVA: 0x1AF4090 Offset: 0x1AF4191 VA: 0x1AF4090
	private void set_translationOffset_Injected(ref Vector3 value) { }

	// RVA: 0x1AF4520 Offset: 0x1AF4621 VA: 0x1AF4520 Slot: 17
	private int AddSource_Injected(ref ConstraintSource source) { }

	// RVA: 0x1AF4890 Offset: 0x1AF4991 VA: 0x1AF4890
	private void GetSourceInternal_Injected(int index, out ConstraintSource ret) { }

	// RVA: 0x1AF49D0 Offset: 0x1AF4AD1 VA: 0x1AF49D0
	private void SetSourceInternal_Injected(int index, ref ConstraintSource source) { }
}

