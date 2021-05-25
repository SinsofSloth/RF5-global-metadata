[DocumentationSortingAttribute] // RVA: 0x12EE40 Offset: 0x12EF41 VA: 0x12EE40
[Serializable]
public struct LensSettings // TypeDefIndex: 4853
{
	// Fields
	public static LensSettings Default; // 0x0
	[RangeAttribute] // RVA: 0x134AC0 Offset: 0x134BC1 VA: 0x134AC0
	[TooltipAttribute] // RVA: 0x134AC0 Offset: 0x134BC1 VA: 0x134AC0
	public float FieldOfView; // 0x0
	[TooltipAttribute] // RVA: 0x134B20 Offset: 0x134C21 VA: 0x134B20
	public float OrthographicSize; // 0x4
	[TooltipAttribute] // RVA: 0x134B60 Offset: 0x134C61 VA: 0x134B60
	public float NearClipPlane; // 0x8
	[TooltipAttribute] // RVA: 0x134BA0 Offset: 0x134CA1 VA: 0x134BA0
	public float FarClipPlane; // 0xC
	[RangeAttribute] // RVA: 0x134BE0 Offset: 0x134CE1 VA: 0x134BE0
	[TooltipAttribute] // RVA: 0x134BE0 Offset: 0x134CE1 VA: 0x134BE0
	public float Dutch; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x134C40 Offset: 0x134D41 VA: 0x134C40
	private bool <Orthographic>k__BackingField; // 0x14
	[CompilerGeneratedAttribute] // RVA: 0x134C50 Offset: 0x134D51 VA: 0x134C50
	private Vector2 <SensorSize>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x134C60 Offset: 0x134D61 VA: 0x134C60
	private bool <IsPhysicalCamera>k__BackingField; // 0x20
	public Vector2 LensShift; // 0x24

	// Properties
	public bool Orthographic { get; set; }
	public Vector2 SensorSize { get; set; }
	public float Aspect { get; }
	public bool IsPhysicalCamera { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x137210 Offset: 0x137311 VA: 0x137210
	// RVA: 0x17A50 Offset: 0x17B51 VA: 0x17A50
	public bool get_Orthographic() { }

	[CompilerGeneratedAttribute] // RVA: 0x137220 Offset: 0x137321 VA: 0x137220
	// RVA: 0x17A60 Offset: 0x17B61 VA: 0x17A60
	public void set_Orthographic(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x137230 Offset: 0x137331 VA: 0x137230
	// RVA: 0x17A70 Offset: 0x17B71 VA: 0x17A70
	public Vector2 get_SensorSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x137240 Offset: 0x137341 VA: 0x137240
	// RVA: 0x17A80 Offset: 0x17B81 VA: 0x17A80
	public void set_SensorSize(Vector2 value) { }

	// RVA: 0x17A90 Offset: 0x17B91 VA: 0x17A90
	public float get_Aspect() { }

	[CompilerGeneratedAttribute] // RVA: 0x137250 Offset: 0x137351 VA: 0x137250
	// RVA: 0x17AB0 Offset: 0x17BB1 VA: 0x17AB0
	public bool get_IsPhysicalCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x137260 Offset: 0x137361 VA: 0x137260
	// RVA: 0x17AC0 Offset: 0x17BC1 VA: 0x17AC0
	public void set_IsPhysicalCamera(bool value) { }

	// RVA: 0x1A1E6C0 Offset: 0x1A1E7C1 VA: 0x1A1E6C0
	public static LensSettings FromCamera(Camera fromCamera) { }

	// RVA: 0x17AD0 Offset: 0x17BD1 VA: 0x17AD0
	public void SnapshotCameraReadOnlyProperties(Camera camera) { }

	// RVA: 0x17AE0 Offset: 0x17BE1 VA: 0x17AE0
	public void SnapshotCameraReadOnlyProperties(ref LensSettings lens) { }

	// RVA: 0x17B90 Offset: 0x17C91 VA: 0x17B90
	public void .ctor(float fov, float orthographicSize, float nearClip, float farClip, float dutch) { }

	// RVA: 0x1A1E910 Offset: 0x1A1EA11 VA: 0x1A1E910
	public static LensSettings Lerp(LensSettings lensA, LensSettings lensB, float t) { }

	// RVA: 0x17BC0 Offset: 0x17CC1 VA: 0x17BC0
	public void Validate() { }

	// RVA: 0x1A1EAF0 Offset: 0x1A1EBF1 VA: 0x1A1EAF0
	private static void .cctor() { }
}

