internal class StaticPointVirtualCamera : ICinemachineCamera // TypeDefIndex: 4818
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x134500 Offset: 0x134601 VA: 0x134500
	private string <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x134510 Offset: 0x134611 VA: 0x134510
	private int <Priority>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x134520 Offset: 0x134621 VA: 0x134520
	private Transform <LookAt>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x134530 Offset: 0x134631 VA: 0x134530
	private Transform <Follow>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x134540 Offset: 0x134641 VA: 0x134540
	private CameraState <State>k__BackingField; // 0x30

	// Properties
	public string Name { get; set; }
	public string Description { get; }
	public int Priority { get; set; }
	public Transform LookAt { get; set; }
	public Transform Follow { get; set; }
	public CameraState State { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public ICinemachineCamera ParentCamera { get; }

	// Methods

	// RVA: 0x1A1D980 Offset: 0x1A1DA81 VA: 0x1A1D980
	public void .ctor(CameraState state, string name) { }

	// RVA: 0x1A1F710 Offset: 0x1A1F811 VA: 0x1A1F710
	public void SetState(CameraState state) { }

	[CompilerGeneratedAttribute] // RVA: 0x137000 Offset: 0x137101 VA: 0x137000
	// RVA: 0x1A1F740 Offset: 0x1A1F841 VA: 0x1A1F740 Slot: 4
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x137010 Offset: 0x137111 VA: 0x137010
	// RVA: 0x1A1F750 Offset: 0x1A1F851 VA: 0x1A1F750
	private void set_Name(string value) { }

	// RVA: 0x1A1F760 Offset: 0x1A1F861 VA: 0x1A1F760 Slot: 5
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x137020 Offset: 0x137121 VA: 0x137020
	// RVA: 0x1A1F7B0 Offset: 0x1A1F8B1 VA: 0x1A1F7B0 Slot: 6
	public int get_Priority() { }

	[CompilerGeneratedAttribute] // RVA: 0x137030 Offset: 0x137131 VA: 0x137030
	// RVA: 0x1A1F7C0 Offset: 0x1A1F8C1 VA: 0x1A1F7C0 Slot: 7
	public void set_Priority(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x137040 Offset: 0x137141 VA: 0x137040
	// RVA: 0x1A1F7D0 Offset: 0x1A1F8D1 VA: 0x1A1F7D0 Slot: 8
	public Transform get_LookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x137050 Offset: 0x137151 VA: 0x137050
	// RVA: 0x1A1F7E0 Offset: 0x1A1F8E1 VA: 0x1A1F7E0 Slot: 9
	public void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x137060 Offset: 0x137161 VA: 0x137060
	// RVA: 0x1A1F7F0 Offset: 0x1A1F8F1 VA: 0x1A1F7F0 Slot: 10
	public Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x137070 Offset: 0x137171 VA: 0x137070
	// RVA: 0x1A1F800 Offset: 0x1A1F901 VA: 0x1A1F800 Slot: 11
	public void set_Follow(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x137080 Offset: 0x137181 VA: 0x137080
	// RVA: 0x1A1F810 Offset: 0x1A1F911 VA: 0x1A1F810 Slot: 12
	public CameraState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x137090 Offset: 0x137191 VA: 0x137090
	// RVA: 0x1A1F820 Offset: 0x1A1F921 VA: 0x1A1F820
	private void set_State(CameraState value) { }

	// RVA: 0x1A1F850 Offset: 0x1A1F951 VA: 0x1A1F850 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0x1A1F860 Offset: 0x1A1F961 VA: 0x1A1F860 Slot: 14
	public bool get_IsValid() { }

	// RVA: 0x1A1F870 Offset: 0x1A1F971 VA: 0x1A1F870 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0x1A1F880 Offset: 0x1A1F981 VA: 0x1A1F880 Slot: 16
	public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x1A1F890 Offset: 0x1A1F991 VA: 0x1A1F890 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1F8A0 Offset: 0x1A1F9A1 VA: 0x1A1F8A0 Slot: 18
	public void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1F8B0 Offset: 0x1A1F9B1 VA: 0x1A1F8B0 Slot: 19
	public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A1F8C0 Offset: 0x1A1F9C1 VA: 0x1A1F8C0 Slot: 20
	public void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }
}

