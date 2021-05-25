[NativeHeaderAttribute] // RVA: 0xEA210 Offset: 0xEA311 VA: 0xEA210
[UsedByNativeCodeAttribute] // RVA: 0xEA210 Offset: 0xEA311 VA: 0xEA210
[NativeHeaderAttribute] // RVA: 0xEA210 Offset: 0xEA311 VA: 0xEA210
[RequireComponent] // RVA: 0xEA210 Offset: 0xEA311 VA: 0xEA210
public sealed class RotationConstraint : Behaviour, IConstraint, IConstraintInternal // TypeDefIndex: 3546
{
	// Properties
	public float weight { get; set; }
	public Vector3 rotationAtRest { get; set; }
	public Vector3 rotationOffset { get; set; }
	public Axis rotationAxis { get; set; }
	public bool constraintActive { get; set; }
	public bool locked { get; set; }
	public int sourceCount { get; }

	// Methods

	// RVA: 0x1AF4F70 Offset: 0x1AF5071 VA: 0x1AF4F70
	private void .ctor() { }

	// RVA: 0x1AF4FD0 Offset: 0x1AF50D1 VA: 0x1AF4FD0
	private static void Internal_Create(RotationConstraint self) { }

	// RVA: 0x1AF5020 Offset: 0x1AF5121 VA: 0x1AF5020 Slot: 4
	public float get_weight() { }

	// RVA: 0x1AF5070 Offset: 0x1AF5171 VA: 0x1AF5070 Slot: 5
	public void set_weight(float value) { }

	// RVA: 0x1AF50C0 Offset: 0x1AF51C1 VA: 0x1AF50C0
	public Vector3 get_rotationAtRest() { }

	// RVA: 0x1AF5170 Offset: 0x1AF5271 VA: 0x1AF5170
	public void set_rotationAtRest(Vector3 value) { }

	// RVA: 0x1AF5220 Offset: 0x1AF5321 VA: 0x1AF5220
	public Vector3 get_rotationOffset() { }

	// RVA: 0x1AF52D0 Offset: 0x1AF53D1 VA: 0x1AF52D0
	public void set_rotationOffset(Vector3 value) { }

	// RVA: 0x1AF5380 Offset: 0x1AF5481 VA: 0x1AF5380
	public Axis get_rotationAxis() { }

	// RVA: 0x1AF53D0 Offset: 0x1AF54D1 VA: 0x1AF53D0
	public void set_rotationAxis(Axis value) { }

	// RVA: 0x1AF5420 Offset: 0x1AF5521 VA: 0x1AF5420 Slot: 6
	public bool get_constraintActive() { }

	// RVA: 0x1AF5470 Offset: 0x1AF5571 VA: 0x1AF5470 Slot: 7
	public void set_constraintActive(bool value) { }

	// RVA: 0x1AF54C0 Offset: 0x1AF55C1 VA: 0x1AF54C0 Slot: 8
	public bool get_locked() { }

	// RVA: 0x1AF5510 Offset: 0x1AF5611 VA: 0x1AF5510 Slot: 9
	public void set_locked(bool value) { }

	// RVA: 0x1AF5560 Offset: 0x1AF5661 VA: 0x1AF5560 Slot: 10
	public int get_sourceCount() { }

	[FreeFunctionAttribute] // RVA: 0xED270 Offset: 0xED371 VA: 0xED270
	// RVA: 0x1AF55B0 Offset: 0x1AF56B1 VA: 0x1AF55B0
	private static int GetSourceCountInternal(RotationConstraint self) { }

	[FreeFunctionAttribute] // RVA: 0xED2B0 Offset: 0xED3B1 VA: 0xED2B0
	// RVA: 0x1AF5600 Offset: 0x1AF5701 VA: 0x1AF5600 Slot: 11
	public void GetSources(List<ConstraintSource> sources) { }

	// RVA: 0x1AF5650 Offset: 0x1AF5751 VA: 0x1AF5650 Slot: 12
	public void SetSources(List<ConstraintSource> sources) { }

	[FreeFunctionAttribute] // RVA: 0xED300 Offset: 0xED401 VA: 0xED300
	// RVA: 0x1AF5710 Offset: 0x1AF5811 VA: 0x1AF5710
	private static void SetSourcesInternal(RotationConstraint self, List<ConstraintSource> sources) { }

	// RVA: 0x1AF5760 Offset: 0x1AF5861 VA: 0x1AF5760 Slot: 13
	public int AddSource(ConstraintSource source) { }

	// RVA: 0x1AF5810 Offset: 0x1AF5911 VA: 0x1AF5810 Slot: 14
	public void RemoveSource(int index) { }

	[NativeNameAttribute] // RVA: 0xED340 Offset: 0xED441 VA: 0xED340
	// RVA: 0x1AF5A00 Offset: 0x1AF5B01 VA: 0x1AF5A00
	private void RemoveSourceInternal(int index) { }

	// RVA: 0x1AF5A50 Offset: 0x1AF5B51 VA: 0x1AF5A50 Slot: 15
	public ConstraintSource GetSource(int index) { }

	[NativeNameAttribute] // RVA: 0xED380 Offset: 0xED481 VA: 0xED380
	// RVA: 0x1AF5AC0 Offset: 0x1AF5BC1 VA: 0x1AF5AC0
	private ConstraintSource GetSourceInternal(int index) { }

	// RVA: 0x1AF5B90 Offset: 0x1AF5C91 VA: 0x1AF5B90 Slot: 16
	public void SetSource(int index, ConstraintSource source) { }

	[NativeNameAttribute] // RVA: 0xED3C0 Offset: 0xED4C1 VA: 0xED3C0
	// RVA: 0x1AF5C00 Offset: 0x1AF5D01 VA: 0x1AF5C00
	private void SetSourceInternal(int index, ConstraintSource source) { }

	// RVA: 0x1AF5870 Offset: 0x1AF5971 VA: 0x1AF5870
	private void ValidateSourceIndex(int index) { }

	// RVA: 0x1AF5120 Offset: 0x1AF5221 VA: 0x1AF5120
	private void get_rotationAtRest_Injected(out Vector3 ret) { }

	// RVA: 0x1AF51D0 Offset: 0x1AF52D1 VA: 0x1AF51D0
	private void set_rotationAtRest_Injected(ref Vector3 value) { }

	// RVA: 0x1AF5280 Offset: 0x1AF5381 VA: 0x1AF5280
	private void get_rotationOffset_Injected(out Vector3 ret) { }

	// RVA: 0x1AF5330 Offset: 0x1AF5431 VA: 0x1AF5330
	private void set_rotationOffset_Injected(ref Vector3 value) { }

	// RVA: 0x1AF57C0 Offset: 0x1AF58C1 VA: 0x1AF57C0 Slot: 17
	private int AddSource_Injected(ref ConstraintSource source) { }

	// RVA: 0x1AF5B30 Offset: 0x1AF5C31 VA: 0x1AF5B30
	private void GetSourceInternal_Injected(int index, out ConstraintSource ret) { }

	// RVA: 0x1AF5C70 Offset: 0x1AF5D71 VA: 0x1AF5C70
	private void SetSourceInternal_Injected(int index, ref ConstraintSource source) { }
}

