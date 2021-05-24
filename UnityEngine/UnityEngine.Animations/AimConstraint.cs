[RequireComponent] // RVA: 0xE9250 Offset: 0xE9351 VA: 0xE9250
[NativeHeaderAttribute] // RVA: 0xE9250 Offset: 0xE9351 VA: 0xE9250
[UsedByNativeCodeAttribute] // RVA: 0xE9250 Offset: 0xE9351 VA: 0xE9250
[NativeHeaderAttribute] // RVA: 0xE9250 Offset: 0xE9351 VA: 0xE9250
public sealed class AimConstraint : Behaviour, IConstraint, IConstraintInternal // TypeDefIndex: 3521
{
	// Properties
	public float weight { get; set; }
	public bool constraintActive { get; set; }
	public bool locked { get; set; }
	public Vector3 rotationAtRest { get; set; }
	public Vector3 rotationOffset { get; set; }
	public Axis rotationAxis { get; set; }
	public Vector3 aimVector { get; set; }
	public Vector3 upVector { get; set; }
	public Vector3 worldUpVector { get; set; }
	public Transform worldUpObject { get; set; }
	public AimConstraint.WorldUpType worldUpType { get; set; }
	public int sourceCount { get; }

	// Methods

	// RVA: 0x1AED750 Offset: 0x1AED851 VA: 0x1AED750
	private void .ctor() { }

	// RVA: 0x1AED7B0 Offset: 0x1AED8B1 VA: 0x1AED7B0
	private static void Internal_Create(AimConstraint self) { }

	// RVA: 0x1AED800 Offset: 0x1AED901 VA: 0x1AED800 Slot: 4
	public float get_weight() { }

	// RVA: 0x1AED850 Offset: 0x1AED951 VA: 0x1AED850 Slot: 5
	public void set_weight(float value) { }

	// RVA: 0x1AED8A0 Offset: 0x1AED9A1 VA: 0x1AED8A0 Slot: 6
	public bool get_constraintActive() { }

	// RVA: 0x1AED8F0 Offset: 0x1AED9F1 VA: 0x1AED8F0 Slot: 7
	public void set_constraintActive(bool value) { }

	// RVA: 0x1AED940 Offset: 0x1AEDA41 VA: 0x1AED940 Slot: 8
	public bool get_locked() { }

	// RVA: 0x1AED990 Offset: 0x1AEDA91 VA: 0x1AED990 Slot: 9
	public void set_locked(bool value) { }

	// RVA: 0x1AED9E0 Offset: 0x1AEDAE1 VA: 0x1AED9E0
	public Vector3 get_rotationAtRest() { }

	// RVA: 0x1AEDA90 Offset: 0x1AEDB91 VA: 0x1AEDA90
	public void set_rotationAtRest(Vector3 value) { }

	// RVA: 0x1AEDB40 Offset: 0x1AEDC41 VA: 0x1AEDB40
	public Vector3 get_rotationOffset() { }

	// RVA: 0x1AEDBF0 Offset: 0x1AEDCF1 VA: 0x1AEDBF0
	public void set_rotationOffset(Vector3 value) { }

	// RVA: 0x1AEDCA0 Offset: 0x1AEDDA1 VA: 0x1AEDCA0
	public Axis get_rotationAxis() { }

	// RVA: 0x1AEDCF0 Offset: 0x1AEDDF1 VA: 0x1AEDCF0
	public void set_rotationAxis(Axis value) { }

	// RVA: 0x1AEDD40 Offset: 0x1AEDE41 VA: 0x1AEDD40
	public Vector3 get_aimVector() { }

	// RVA: 0x1AEDDF0 Offset: 0x1AEDEF1 VA: 0x1AEDDF0
	public void set_aimVector(Vector3 value) { }

	// RVA: 0x1AEDEA0 Offset: 0x1AEDFA1 VA: 0x1AEDEA0
	public Vector3 get_upVector() { }

	// RVA: 0x1AEDF50 Offset: 0x1AEE051 VA: 0x1AEDF50
	public void set_upVector(Vector3 value) { }

	// RVA: 0x1AEE000 Offset: 0x1AEE101 VA: 0x1AEE000
	public Vector3 get_worldUpVector() { }

	// RVA: 0x1AEE0B0 Offset: 0x1AEE1B1 VA: 0x1AEE0B0
	public void set_worldUpVector(Vector3 value) { }

	// RVA: 0x1AEE160 Offset: 0x1AEE261 VA: 0x1AEE160
	public Transform get_worldUpObject() { }

	// RVA: 0x1AEE1B0 Offset: 0x1AEE2B1 VA: 0x1AEE1B0
	public void set_worldUpObject(Transform value) { }

	// RVA: 0x1AEE200 Offset: 0x1AEE301 VA: 0x1AEE200
	public AimConstraint.WorldUpType get_worldUpType() { }

	// RVA: 0x1AEE250 Offset: 0x1AEE351 VA: 0x1AEE250
	public void set_worldUpType(AimConstraint.WorldUpType value) { }

	// RVA: 0x1AEE2A0 Offset: 0x1AEE3A1 VA: 0x1AEE2A0 Slot: 10
	public int get_sourceCount() { }

	[FreeFunctionAttribute] // RVA: 0xECA10 Offset: 0xECB11 VA: 0xECA10
	// RVA: 0x1AEE2F0 Offset: 0x1AEE3F1 VA: 0x1AEE2F0
	private static int GetSourceCountInternal(AimConstraint self) { }

	[FreeFunctionAttribute] // RVA: 0xECA50 Offset: 0xECB51 VA: 0xECA50
	// RVA: 0x1AEE340 Offset: 0x1AEE441 VA: 0x1AEE340 Slot: 11
	public void GetSources(List<ConstraintSource> sources) { }

	// RVA: 0x1AEE390 Offset: 0x1AEE491 VA: 0x1AEE390 Slot: 12
	public void SetSources(List<ConstraintSource> sources) { }

	[FreeFunctionAttribute] // RVA: 0xECAA0 Offset: 0xECBA1 VA: 0xECAA0
	// RVA: 0x1AEE450 Offset: 0x1AEE551 VA: 0x1AEE450
	private static void SetSourcesInternal(AimConstraint self, List<ConstraintSource> sources) { }

	// RVA: 0x1AEE4A0 Offset: 0x1AEE5A1 VA: 0x1AEE4A0 Slot: 13
	public int AddSource(ConstraintSource source) { }

	// RVA: 0x1AEE550 Offset: 0x1AEE651 VA: 0x1AEE550 Slot: 14
	public void RemoveSource(int index) { }

	[NativeNameAttribute] // RVA: 0xECAE0 Offset: 0xECBE1 VA: 0xECAE0
	// RVA: 0x1AEE740 Offset: 0x1AEE841 VA: 0x1AEE740
	private void RemoveSourceInternal(int index) { }

	// RVA: 0x1AEE790 Offset: 0x1AEE891 VA: 0x1AEE790 Slot: 15
	public ConstraintSource GetSource(int index) { }

	[NativeNameAttribute] // RVA: 0xECB20 Offset: 0xECC21 VA: 0xECB20
	// RVA: 0x1AEE800 Offset: 0x1AEE901 VA: 0x1AEE800
	private ConstraintSource GetSourceInternal(int index) { }

	// RVA: 0x1AEE8D0 Offset: 0x1AEE9D1 VA: 0x1AEE8D0 Slot: 16
	public void SetSource(int index, ConstraintSource source) { }

	[NativeNameAttribute] // RVA: 0xECB60 Offset: 0xECC61 VA: 0xECB60
	// RVA: 0x1AEE940 Offset: 0x1AEEA41 VA: 0x1AEE940
	private void SetSourceInternal(int index, ConstraintSource source) { }

	// RVA: 0x1AEE5B0 Offset: 0x1AEE6B1 VA: 0x1AEE5B0
	private void ValidateSourceIndex(int index) { }

	// RVA: 0x1AEDA40 Offset: 0x1AEDB41 VA: 0x1AEDA40
	private void get_rotationAtRest_Injected(out Vector3 ret) { }

	// RVA: 0x1AEDAF0 Offset: 0x1AEDBF1 VA: 0x1AEDAF0
	private void set_rotationAtRest_Injected(ref Vector3 value) { }

	// RVA: 0x1AEDBA0 Offset: 0x1AEDCA1 VA: 0x1AEDBA0
	private void get_rotationOffset_Injected(out Vector3 ret) { }

	// RVA: 0x1AEDC50 Offset: 0x1AEDD51 VA: 0x1AEDC50
	private void set_rotationOffset_Injected(ref Vector3 value) { }

	// RVA: 0x1AEDDA0 Offset: 0x1AEDEA1 VA: 0x1AEDDA0
	private void get_aimVector_Injected(out Vector3 ret) { }

	// RVA: 0x1AEDE50 Offset: 0x1AEDF51 VA: 0x1AEDE50
	private void set_aimVector_Injected(ref Vector3 value) { }

	// RVA: 0x1AEDF00 Offset: 0x1AEE001 VA: 0x1AEDF00
	private void get_upVector_Injected(out Vector3 ret) { }

	// RVA: 0x1AEDFB0 Offset: 0x1AEE0B1 VA: 0x1AEDFB0
	private void set_upVector_Injected(ref Vector3 value) { }

	// RVA: 0x1AEE060 Offset: 0x1AEE161 VA: 0x1AEE060
	private void get_worldUpVector_Injected(out Vector3 ret) { }

	// RVA: 0x1AEE110 Offset: 0x1AEE211 VA: 0x1AEE110
	private void set_worldUpVector_Injected(ref Vector3 value) { }

	// RVA: 0x1AEE500 Offset: 0x1AEE601 VA: 0x1AEE500 Slot: 17
	private int AddSource_Injected(ref ConstraintSource source) { }

	// RVA: 0x1AEE870 Offset: 0x1AEE971 VA: 0x1AEE870
	private void GetSourceInternal_Injected(int index, out ConstraintSource ret) { }

	// RVA: 0x1AEE9B0 Offset: 0x1AEEAB1 VA: 0x1AEE9B0
	private void SetSourceInternal_Injected(int index, ref ConstraintSource source) { }
}

