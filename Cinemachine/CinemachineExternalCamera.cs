[DocumentationSortingAttribute] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[RequireComponent] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[DisallowMultipleComponent] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[AddComponentMenu] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[ExecuteAlways] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[HelpURLAttribute] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4751
{
	// Fields
	[TooltipAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	[NoSaveDuringPlayAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	[VcamTargetPropertyAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	public Transform m_LookAt; // 0x68
	private Camera m_Camera; // 0x70
	private CameraState m_State; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x130950 Offset: 0x130A51 VA: 0x130950
	private Transform <Follow>k__BackingField; // 0x158
	[TooltipAttribute] // RVA: 0x130960 Offset: 0x130A61 VA: 0x130960
	[FormerlySerializedAsAttribute] // RVA: 0x130960 Offset: 0x130A61 VA: 0x130960
	public CinemachineVirtualCameraBase.BlendHint m_BlendHint; // 0x160

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }

	// Methods

	// RVA: 0x17210A0 Offset: 0x17211A1 VA: 0x17210A0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x17210B0 Offset: 0x17211B1 VA: 0x17210B0 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x17210C0 Offset: 0x17211C1 VA: 0x17210C0 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B50 Offset: 0x136C51 VA: 0x136B50
	// RVA: 0x17210D0 Offset: 0x17211D1 VA: 0x17210D0 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x136B60 Offset: 0x136C61 VA: 0x136B60
	// RVA: 0x17210E0 Offset: 0x17211E1 VA: 0x17210E0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x17210F0 Offset: 0x17211F1 VA: 0x17210F0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1721560 Offset: 0x1721661 VA: 0x1721560
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[RequireComponent] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[DisallowMultipleComponent] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[AddComponentMenu] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[ExecuteAlways] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[HelpURLAttribute] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4751
{
	// Fields
	[TooltipAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	[NoSaveDuringPlayAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	[VcamTargetPropertyAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	public Transform m_LookAt; // 0x68
	private Camera m_Camera; // 0x70
	private CameraState m_State; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x130950 Offset: 0x130A51 VA: 0x130950
	private Transform <Follow>k__BackingField; // 0x158
	[TooltipAttribute] // RVA: 0x130960 Offset: 0x130A61 VA: 0x130960
	[FormerlySerializedAsAttribute] // RVA: 0x130960 Offset: 0x130A61 VA: 0x130960
	public CinemachineVirtualCameraBase.BlendHint m_BlendHint; // 0x160

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }

	// Methods

	// RVA: 0x17210A0 Offset: 0x17211A1 VA: 0x17210A0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x17210B0 Offset: 0x17211B1 VA: 0x17210B0 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x17210C0 Offset: 0x17211C1 VA: 0x17210C0 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B50 Offset: 0x136C51 VA: 0x136B50
	// RVA: 0x17210D0 Offset: 0x17211D1 VA: 0x17210D0 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x136B60 Offset: 0x136C61 VA: 0x136B60
	// RVA: 0x17210E0 Offset: 0x17211E1 VA: 0x17210E0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x17210F0 Offset: 0x17211F1 VA: 0x17210F0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1721560 Offset: 0x1721661 VA: 0x1721560
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[RequireComponent] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[DisallowMultipleComponent] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[AddComponentMenu] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[ExecuteAlways] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[HelpURLAttribute] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4751
{
	// Fields
	[TooltipAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	[NoSaveDuringPlayAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	[VcamTargetPropertyAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	public Transform m_LookAt; // 0x68
	private Camera m_Camera; // 0x70
	private CameraState m_State; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x130950 Offset: 0x130A51 VA: 0x130950
	private Transform <Follow>k__BackingField; // 0x158
	[TooltipAttribute] // RVA: 0x130960 Offset: 0x130A61 VA: 0x130960
	[FormerlySerializedAsAttribute] // RVA: 0x130960 Offset: 0x130A61 VA: 0x130960
	public CinemachineVirtualCameraBase.BlendHint m_BlendHint; // 0x160

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }

	// Methods

	// RVA: 0x17210A0 Offset: 0x17211A1 VA: 0x17210A0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x17210B0 Offset: 0x17211B1 VA: 0x17210B0 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x17210C0 Offset: 0x17211C1 VA: 0x17210C0 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B50 Offset: 0x136C51 VA: 0x136B50
	// RVA: 0x17210D0 Offset: 0x17211D1 VA: 0x17210D0 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x136B60 Offset: 0x136C61 VA: 0x136B60
	// RVA: 0x17210E0 Offset: 0x17211E1 VA: 0x17210E0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x17210F0 Offset: 0x17211F1 VA: 0x17210F0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1721560 Offset: 0x1721661 VA: 0x1721560
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[RequireComponent] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[DisallowMultipleComponent] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[AddComponentMenu] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[ExecuteAlways] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[HelpURLAttribute] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4751
{
	// Fields
	[TooltipAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	[NoSaveDuringPlayAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	[VcamTargetPropertyAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	public Transform m_LookAt; // 0x68
	private Camera m_Camera; // 0x70
	private CameraState m_State; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x130950 Offset: 0x130A51 VA: 0x130950
	private Transform <Follow>k__BackingField; // 0x158
	[TooltipAttribute] // RVA: 0x130960 Offset: 0x130A61 VA: 0x130960
	[FormerlySerializedAsAttribute] // RVA: 0x130960 Offset: 0x130A61 VA: 0x130960
	public CinemachineVirtualCameraBase.BlendHint m_BlendHint; // 0x160

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }

	// Methods

	// RVA: 0x17210A0 Offset: 0x17211A1 VA: 0x17210A0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x17210B0 Offset: 0x17211B1 VA: 0x17210B0 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x17210C0 Offset: 0x17211C1 VA: 0x17210C0 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B50 Offset: 0x136C51 VA: 0x136B50
	// RVA: 0x17210D0 Offset: 0x17211D1 VA: 0x17210D0 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x136B60 Offset: 0x136C61 VA: 0x136B60
	// RVA: 0x17210E0 Offset: 0x17211E1 VA: 0x17210E0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x17210F0 Offset: 0x17211F1 VA: 0x17210F0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1721560 Offset: 0x1721661 VA: 0x1721560
	public void .ctor() { }
}

[DocumentationSortingAttribute] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[RequireComponent] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[DisallowMultipleComponent] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[AddComponentMenu] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[ExecuteAlways] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
[HelpURLAttribute] // RVA: 0x12E150 Offset: 0x12E251 VA: 0x12E150
public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 4751
{
	// Fields
	[TooltipAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	[NoSaveDuringPlayAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	[VcamTargetPropertyAttribute] // RVA: 0x1308F0 Offset: 0x1309F1 VA: 0x1308F0
	public Transform m_LookAt; // 0x68
	private Camera m_Camera; // 0x70
	private CameraState m_State; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x130950 Offset: 0x130A51 VA: 0x130950
	private Transform <Follow>k__BackingField; // 0x158
	[TooltipAttribute] // RVA: 0x130960 Offset: 0x130A61 VA: 0x130960
	[FormerlySerializedAsAttribute] // RVA: 0x130960 Offset: 0x130A61 VA: 0x130960
	public CinemachineVirtualCameraBase.BlendHint m_BlendHint; // 0x160

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }

	// Methods

	// RVA: 0x17210A0 Offset: 0x17211A1 VA: 0x17210A0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x17210B0 Offset: 0x17211B1 VA: 0x17210B0 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x17210C0 Offset: 0x17211C1 VA: 0x17210C0 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x136B50 Offset: 0x136C51 VA: 0x136B50
	// RVA: 0x17210D0 Offset: 0x17211D1 VA: 0x17210D0 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x136B60 Offset: 0x136C61 VA: 0x136B60
	// RVA: 0x17210E0 Offset: 0x17211E1 VA: 0x17210E0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x17210F0 Offset: 0x17211F1 VA: 0x17210F0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1721560 Offset: 0x1721661 VA: 0x1721560
	public void .ctor() { }
}

