internal class BlendSourceVirtualCamera : ICinemachineCamera // TypeDefIndex: 4819
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x134550 Offset: 0x134651 VA: 0x134550
	private CinemachineBlend <Blend>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x134560 Offset: 0x134661 VA: 0x134560
	private int <Priority>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x134570 Offset: 0x134671 VA: 0x134570
	private Transform <LookAt>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x134580 Offset: 0x134681 VA: 0x134580
	private Transform <Follow>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x134590 Offset: 0x134691 VA: 0x134590
	private CameraState <State>k__BackingField; // 0x30

	// Properties
	public CinemachineBlend Blend { get; set; }
	public string Name { get; }
	public string Description { get; }
	public int Priority { get; set; }
	public Transform LookAt { get; set; }
	public Transform Follow { get; set; }
	public CameraState State { get; set; }
	public GameObject VirtualCameraGameObject { get; }
	public bool IsValid { get; }
	public ICinemachineCamera ParentCamera { get; }

	// Methods

	// RVA: 0x1882CD0 Offset: 0x1882DD1 VA: 0x1882CD0
	public void .ctor(CinemachineBlend blend) { }

	[CompilerGeneratedAttribute] // RVA: 0x1370A0 Offset: 0x1371A1 VA: 0x1370A0
	// RVA: 0x1882D10 Offset: 0x1882E11 VA: 0x1882D10
	public CinemachineBlend get_Blend() { }

	[CompilerGeneratedAttribute] // RVA: 0x1370B0 Offset: 0x1371B1 VA: 0x1370B0
	// RVA: 0x1882D20 Offset: 0x1882E21 VA: 0x1882D20
	public void set_Blend(CinemachineBlend value) { }

	// RVA: 0x1882D30 Offset: 0x1882E31 VA: 0x1882D30 Slot: 4
	public string get_Name() { }

	// RVA: 0x1882D80 Offset: 0x1882E81 VA: 0x1882D80 Slot: 5
	public string get_Description() { }

	[CompilerGeneratedAttribute] // RVA: 0x1370C0 Offset: 0x1371C1 VA: 0x1370C0
	// RVA: 0x1883130 Offset: 0x1883231 VA: 0x1883130 Slot: 6
	public int get_Priority() { }

	[CompilerGeneratedAttribute] // RVA: 0x1370D0 Offset: 0x1371D1 VA: 0x1370D0
	// RVA: 0x1883140 Offset: 0x1883241 VA: 0x1883140 Slot: 7
	public void set_Priority(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1370E0 Offset: 0x1371E1 VA: 0x1370E0
	// RVA: 0x1883150 Offset: 0x1883251 VA: 0x1883150 Slot: 8
	public Transform get_LookAt() { }

	[CompilerGeneratedAttribute] // RVA: 0x1370F0 Offset: 0x1371F1 VA: 0x1370F0
	// RVA: 0x1883160 Offset: 0x1883261 VA: 0x1883160 Slot: 9
	public void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x137100 Offset: 0x137201 VA: 0x137100
	// RVA: 0x1883170 Offset: 0x1883271 VA: 0x1883170 Slot: 10
	public Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x137110 Offset: 0x137211 VA: 0x137110
	// RVA: 0x1883180 Offset: 0x1883281 VA: 0x1883180 Slot: 11
	public void set_Follow(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x137120 Offset: 0x137221 VA: 0x137120
	// RVA: 0x1883190 Offset: 0x1883291 VA: 0x1883190 Slot: 12
	public CameraState get_State() { }

	[CompilerGeneratedAttribute] // RVA: 0x137130 Offset: 0x137231 VA: 0x137130
	// RVA: 0x18831A0 Offset: 0x18832A1 VA: 0x18831A0
	private void set_State(CameraState value) { }

	// RVA: 0x18831D0 Offset: 0x18832D1 VA: 0x18831D0 Slot: 13
	public GameObject get_VirtualCameraGameObject() { }

	// RVA: 0x18831E0 Offset: 0x18832E1 VA: 0x18831E0 Slot: 14
	public bool get_IsValid() { }

	// RVA: 0x1883350 Offset: 0x1883451 VA: 0x1883350 Slot: 15
	public ICinemachineCamera get_ParentCamera() { }

	// RVA: 0x1883360 Offset: 0x1883461 VA: 0x1883360 Slot: 16
	public bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x18833A0 Offset: 0x18834A1 VA: 0x18833A0
	public CameraState CalculateNewState(float deltaTime) { }

	// RVA: 0x18833B0 Offset: 0x18834B1 VA: 0x18833B0 Slot: 17
	public void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1883AE0 Offset: 0x1883BE1 VA: 0x1883AE0 Slot: 18
	public void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1883AF0 Offset: 0x1883BF1 VA: 0x1883AF0 Slot: 19
	public void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1883B00 Offset: 0x1883C01 VA: 0x1883B00 Slot: 20
	public void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }
}

