public class FieldHideItemSpawner : MonoBehaviour // TypeDefIndex: 10483
{
	// Fields
	private const float DetectRadius = 25;
	[SerializeField] // RVA: 0x181B70 Offset: 0x181C71 VA: 0x181B70
	private FieldHideItemSpawnID FieldHideItemSpawnID; // 0x18
	private FieldHideItemSpawnDataTable Data; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x181B80 Offset: 0x181C81 VA: 0x181B80
	private OnGroundItem <OnGroundItem>k__BackingField; // 0x30
	private bool isPlayerDetect; // 0x38
	private bool isInDetectRadius; // 0x39
	[CompilerGeneratedAttribute] // RVA: 0x181B90 Offset: 0x181C91 VA: 0x181B90
	private bool <IsInit>k__BackingField; // 0x3A

	// Properties
	public OnGroundItem OnGroundItem { get; set; }
	public bool IsInit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AF780 Offset: 0x1AF881 VA: 0x1AF780
	// RVA: 0x1E23E00 Offset: 0x1E23F01 VA: 0x1E23E00
	public OnGroundItem get_OnGroundItem() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF790 Offset: 0x1AF891 VA: 0x1AF790
	// RVA: 0x1E23E10 Offset: 0x1E23F11 VA: 0x1E23E10
	private void set_OnGroundItem(OnGroundItem value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF7A0 Offset: 0x1AF8A1 VA: 0x1AF7A0
	// RVA: 0x1E23E20 Offset: 0x1E23F21 VA: 0x1E23E20
	public bool get_IsInit() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF7B0 Offset: 0x1AF8B1 VA: 0x1AF7B0
	// RVA: 0x1E23E30 Offset: 0x1E23F31 VA: 0x1E23E30
	private void set_IsInit(bool value) { }

	// RVA: 0x1E23E40 Offset: 0x1E23F41 VA: 0x1E23E40
	public FieldHideItemSpawnID GetFieldHideItemSpawnID() { }

	// RVA: 0x1E23E50 Offset: 0x1E23F51 VA: 0x1E23E50
	private void OnDestroy() { }

	// RVA: 0x1E23FF0 Offset: 0x1E240F1 VA: 0x1E23FF0
	public void DestroySpawnObject() { }

	// RVA: 0x1E240C0 Offset: 0x1E241C1 VA: 0x1E240C0
	private void Start() { }

	// RVA: 0x1E24200 Offset: 0x1E24301 VA: 0x1E24200
	public void Spawn() { }

	// RVA: 0x1E248E0 Offset: 0x1E249E1 VA: 0x1E248E0
	public bool UpdateDetectState(ref bool[] canDetectParties, ref bool[] IsDetectParties) { }

	// RVA: 0x1E24C20 Offset: 0x1E24D21 VA: 0x1E24C20
	public void OnChangeHideDetectFlag(bool setValue) { }

	// RVA: 0x1E24C30 Offset: 0x1E24D31 VA: 0x1E24C30
	public void .ctor() { }
}

