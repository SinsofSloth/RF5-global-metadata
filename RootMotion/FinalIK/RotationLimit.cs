public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 9534
{
	// Fields
	public Vector3 axis; // 0x18
	[HideInInspector] // RVA: 0x17C030 Offset: 0x17C131 VA: 0x17C030
	public Quaternion defaultLocalRotation; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x17C040 Offset: 0x17C141 VA: 0x17C040
	private bool <defaultLocalRotationOverride>k__BackingField; // 0x34
	private bool initiated; // 0x35
	private bool applicationQuit; // 0x36
	private bool defaultLocalRotationSet; // 0x37

	// Properties
	public Vector3 secondaryAxis { get; }
	public Vector3 crossAxis { get; }
	public bool defaultLocalRotationOverride { get; set; }

	// Methods

	// RVA: 0x2920380 Offset: 0x2920481 VA: 0x2920380
	public void SetDefaultLocalRotation() { }

	// RVA: 0x29203D0 Offset: 0x29204D1 VA: 0x29203D0
	public void SetDefaultLocalRotation(Quaternion localRotation) { }

	// RVA: 0x29203F0 Offset: 0x29204F1 VA: 0x29203F0
	public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed) { }

	// RVA: 0x29206C0 Offset: 0x29207C1 VA: 0x29206C0
	public bool Apply() { }

	// RVA: 0x2920730 Offset: 0x2920831 VA: 0x2920730
	public void Disable() { }

	// RVA: 0x2920770 Offset: 0x2920871 VA: 0x2920770
	public Vector3 get_secondaryAxis() { }

	// RVA: 0x29207B0 Offset: 0x29208B1 VA: 0x29207B0
	public Vector3 get_crossAxis() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ABD80 Offset: 0x1ABE81 VA: 0x1ABD80
	// RVA: 0x2920880 Offset: 0x2920981 VA: 0x2920880
	public bool get_defaultLocalRotationOverride() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ABD90 Offset: 0x1ABE91 VA: 0x1ABD90
	// RVA: 0x2920890 Offset: 0x2920991 VA: 0x2920890
	private void set_defaultLocalRotationOverride(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x29205A0 Offset: 0x29206A1 VA: 0x29205A0
	private void Awake() { }

	// RVA: 0x29208A0 Offset: 0x29209A1 VA: 0x29208A0
	private void LateUpdate() { }

	// RVA: 0x29208B0 Offset: 0x29209B1 VA: 0x29208B0
	public void LogWarning(string message) { }

	// RVA: 0x29208F0 Offset: 0x29209F1 VA: 0x29208F0
	protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) { }

	// RVA: 0x29209E0 Offset: 0x2920AE1 VA: 0x29209E0
	protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) { }

	// RVA: 0x2920C50 Offset: 0x2920D51 VA: 0x2920C50
	protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal) { }

	// RVA: 0x2920D10 Offset: 0x2920E11 VA: 0x2920D10
	protected void .ctor() { }
}

public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 9534
{
	// Fields
	public Vector3 axis; // 0x18
	[HideInInspector] // RVA: 0x17C030 Offset: 0x17C131 VA: 0x17C030
	public Quaternion defaultLocalRotation; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x17C040 Offset: 0x17C141 VA: 0x17C040
	private bool <defaultLocalRotationOverride>k__BackingField; // 0x34
	private bool initiated; // 0x35
	private bool applicationQuit; // 0x36
	private bool defaultLocalRotationSet; // 0x37

	// Properties
	public Vector3 secondaryAxis { get; }
	public Vector3 crossAxis { get; }
	public bool defaultLocalRotationOverride { get; set; }

	// Methods

	// RVA: 0x2920380 Offset: 0x2920481 VA: 0x2920380
	public void SetDefaultLocalRotation() { }

	// RVA: 0x29203D0 Offset: 0x29204D1 VA: 0x29203D0
	public void SetDefaultLocalRotation(Quaternion localRotation) { }

	// RVA: 0x29203F0 Offset: 0x29204F1 VA: 0x29203F0
	public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed) { }

	// RVA: 0x29206C0 Offset: 0x29207C1 VA: 0x29206C0
	public bool Apply() { }

	// RVA: 0x2920730 Offset: 0x2920831 VA: 0x2920730
	public void Disable() { }

	// RVA: 0x2920770 Offset: 0x2920871 VA: 0x2920770
	public Vector3 get_secondaryAxis() { }

	// RVA: 0x29207B0 Offset: 0x29208B1 VA: 0x29207B0
	public Vector3 get_crossAxis() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ABD80 Offset: 0x1ABE81 VA: 0x1ABD80
	// RVA: 0x2920880 Offset: 0x2920981 VA: 0x2920880
	public bool get_defaultLocalRotationOverride() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ABD90 Offset: 0x1ABE91 VA: 0x1ABD90
	// RVA: 0x2920890 Offset: 0x2920991 VA: 0x2920890
	private void set_defaultLocalRotationOverride(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x29205A0 Offset: 0x29206A1 VA: 0x29205A0
	private void Awake() { }

	// RVA: 0x29208A0 Offset: 0x29209A1 VA: 0x29208A0
	private void LateUpdate() { }

	// RVA: 0x29208B0 Offset: 0x29209B1 VA: 0x29208B0
	public void LogWarning(string message) { }

	// RVA: 0x29208F0 Offset: 0x29209F1 VA: 0x29208F0
	protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) { }

	// RVA: 0x29209E0 Offset: 0x2920AE1 VA: 0x29209E0
	protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) { }

	// RVA: 0x2920C50 Offset: 0x2920D51 VA: 0x2920C50
	protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal) { }

	// RVA: 0x2920D10 Offset: 0x2920E11 VA: 0x2920D10
	protected void .ctor() { }
}

public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 9534
{
	// Fields
	public Vector3 axis; // 0x18
	[HideInInspector] // RVA: 0x17C030 Offset: 0x17C131 VA: 0x17C030
	public Quaternion defaultLocalRotation; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x17C040 Offset: 0x17C141 VA: 0x17C040
	private bool <defaultLocalRotationOverride>k__BackingField; // 0x34
	private bool initiated; // 0x35
	private bool applicationQuit; // 0x36
	private bool defaultLocalRotationSet; // 0x37

	// Properties
	public Vector3 secondaryAxis { get; }
	public Vector3 crossAxis { get; }
	public bool defaultLocalRotationOverride { get; set; }

	// Methods

	// RVA: 0x2920380 Offset: 0x2920481 VA: 0x2920380
	public void SetDefaultLocalRotation() { }

	// RVA: 0x29203D0 Offset: 0x29204D1 VA: 0x29203D0
	public void SetDefaultLocalRotation(Quaternion localRotation) { }

	// RVA: 0x29203F0 Offset: 0x29204F1 VA: 0x29203F0
	public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed) { }

	// RVA: 0x29206C0 Offset: 0x29207C1 VA: 0x29206C0
	public bool Apply() { }

	// RVA: 0x2920730 Offset: 0x2920831 VA: 0x2920730
	public void Disable() { }

	// RVA: 0x2920770 Offset: 0x2920871 VA: 0x2920770
	public Vector3 get_secondaryAxis() { }

	// RVA: 0x29207B0 Offset: 0x29208B1 VA: 0x29207B0
	public Vector3 get_crossAxis() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ABD80 Offset: 0x1ABE81 VA: 0x1ABD80
	// RVA: 0x2920880 Offset: 0x2920981 VA: 0x2920880
	public bool get_defaultLocalRotationOverride() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ABD90 Offset: 0x1ABE91 VA: 0x1ABD90
	// RVA: 0x2920890 Offset: 0x2920991 VA: 0x2920890
	private void set_defaultLocalRotationOverride(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x29205A0 Offset: 0x29206A1 VA: 0x29205A0
	private void Awake() { }

	// RVA: 0x29208A0 Offset: 0x29209A1 VA: 0x29208A0
	private void LateUpdate() { }

	// RVA: 0x29208B0 Offset: 0x29209B1 VA: 0x29208B0
	public void LogWarning(string message) { }

	// RVA: 0x29208F0 Offset: 0x29209F1 VA: 0x29208F0
	protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) { }

	// RVA: 0x29209E0 Offset: 0x2920AE1 VA: 0x29209E0
	protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) { }

	// RVA: 0x2920C50 Offset: 0x2920D51 VA: 0x2920C50
	protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal) { }

	// RVA: 0x2920D10 Offset: 0x2920E11 VA: 0x2920D10
	protected void .ctor() { }
}

public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 9534
{
	// Fields
	public Vector3 axis; // 0x18
	[HideInInspector] // RVA: 0x17C030 Offset: 0x17C131 VA: 0x17C030
	public Quaternion defaultLocalRotation; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x17C040 Offset: 0x17C141 VA: 0x17C040
	private bool <defaultLocalRotationOverride>k__BackingField; // 0x34
	private bool initiated; // 0x35
	private bool applicationQuit; // 0x36
	private bool defaultLocalRotationSet; // 0x37

	// Properties
	public Vector3 secondaryAxis { get; }
	public Vector3 crossAxis { get; }
	public bool defaultLocalRotationOverride { get; set; }

	// Methods

	// RVA: 0x2920380 Offset: 0x2920481 VA: 0x2920380
	public void SetDefaultLocalRotation() { }

	// RVA: 0x29203D0 Offset: 0x29204D1 VA: 0x29203D0
	public void SetDefaultLocalRotation(Quaternion localRotation) { }

	// RVA: 0x29203F0 Offset: 0x29204F1 VA: 0x29203F0
	public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed) { }

	// RVA: 0x29206C0 Offset: 0x29207C1 VA: 0x29206C0
	public bool Apply() { }

	// RVA: 0x2920730 Offset: 0x2920831 VA: 0x2920730
	public void Disable() { }

	// RVA: 0x2920770 Offset: 0x2920871 VA: 0x2920770
	public Vector3 get_secondaryAxis() { }

	// RVA: 0x29207B0 Offset: 0x29208B1 VA: 0x29207B0
	public Vector3 get_crossAxis() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ABD80 Offset: 0x1ABE81 VA: 0x1ABD80
	// RVA: 0x2920880 Offset: 0x2920981 VA: 0x2920880
	public bool get_defaultLocalRotationOverride() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ABD90 Offset: 0x1ABE91 VA: 0x1ABD90
	// RVA: 0x2920890 Offset: 0x2920991 VA: 0x2920890
	private void set_defaultLocalRotationOverride(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x29205A0 Offset: 0x29206A1 VA: 0x29205A0
	private void Awake() { }

	// RVA: 0x29208A0 Offset: 0x29209A1 VA: 0x29208A0
	private void LateUpdate() { }

	// RVA: 0x29208B0 Offset: 0x29209B1 VA: 0x29208B0
	public void LogWarning(string message) { }

	// RVA: 0x29208F0 Offset: 0x29209F1 VA: 0x29208F0
	protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) { }

	// RVA: 0x29209E0 Offset: 0x2920AE1 VA: 0x29209E0
	protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) { }

	// RVA: 0x2920C50 Offset: 0x2920D51 VA: 0x2920C50
	protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal) { }

	// RVA: 0x2920D10 Offset: 0x2920E11 VA: 0x2920D10
	protected void .ctor() { }
}

public abstract class RotationLimit : MonoBehaviour // TypeDefIndex: 9534
{
	// Fields
	public Vector3 axis; // 0x18
	[HideInInspector] // RVA: 0x17C030 Offset: 0x17C131 VA: 0x17C030
	public Quaternion defaultLocalRotation; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x17C040 Offset: 0x17C141 VA: 0x17C040
	private bool <defaultLocalRotationOverride>k__BackingField; // 0x34
	private bool initiated; // 0x35
	private bool applicationQuit; // 0x36
	private bool defaultLocalRotationSet; // 0x37

	// Properties
	public Vector3 secondaryAxis { get; }
	public Vector3 crossAxis { get; }
	public bool defaultLocalRotationOverride { get; set; }

	// Methods

	// RVA: 0x2920380 Offset: 0x2920481 VA: 0x2920380
	public void SetDefaultLocalRotation() { }

	// RVA: 0x29203D0 Offset: 0x29204D1 VA: 0x29203D0
	public void SetDefaultLocalRotation(Quaternion localRotation) { }

	// RVA: 0x29203F0 Offset: 0x29204F1 VA: 0x29203F0
	public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed) { }

	// RVA: 0x29206C0 Offset: 0x29207C1 VA: 0x29206C0
	public bool Apply() { }

	// RVA: 0x2920730 Offset: 0x2920831 VA: 0x2920730
	public void Disable() { }

	// RVA: 0x2920770 Offset: 0x2920871 VA: 0x2920770
	public Vector3 get_secondaryAxis() { }

	// RVA: 0x29207B0 Offset: 0x29208B1 VA: 0x29207B0
	public Vector3 get_crossAxis() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ABD80 Offset: 0x1ABE81 VA: 0x1ABD80
	// RVA: 0x2920880 Offset: 0x2920981 VA: 0x2920880
	public bool get_defaultLocalRotationOverride() { }

	[CompilerGeneratedAttribute] // RVA: 0x1ABD90 Offset: 0x1ABE91 VA: 0x1ABD90
	// RVA: 0x2920890 Offset: 0x2920991 VA: 0x2920890
	private void set_defaultLocalRotationOverride(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Quaternion LimitRotation(Quaternion rotation) { }

	// RVA: 0x29205A0 Offset: 0x29206A1 VA: 0x29205A0
	private void Awake() { }

	// RVA: 0x29208A0 Offset: 0x29209A1 VA: 0x29208A0
	private void LateUpdate() { }

	// RVA: 0x29208B0 Offset: 0x29209B1 VA: 0x29208B0
	public void LogWarning(string message) { }

	// RVA: 0x29208F0 Offset: 0x29209F1 VA: 0x29208F0
	protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis) { }

	// RVA: 0x29209E0 Offset: 0x2920AE1 VA: 0x29209E0
	protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit) { }

	// RVA: 0x2920C50 Offset: 0x2920D51 VA: 0x2920C50
	protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal) { }

	// RVA: 0x2920D10 Offset: 0x2920E11 VA: 0x2920D10
	protected void .ctor() { }
}

