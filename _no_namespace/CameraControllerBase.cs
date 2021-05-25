public abstract class CameraControllerBase : MonoBehaviour // TypeDefIndex: 6481
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15CD70 Offset: 0x15CE71 VA: 0x15CD70
	private CinemachineVirtualCamera <UseVirtualCamera>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x15CD80 Offset: 0x15CE81 VA: 0x15CD80
	private CinemachineVirtualCameraBase m_VirtualCameraBase; // 0x20

	// Properties
	protected Character CtrlCharacter { get; }
	protected Camera MainCamera { get; }
	public CinemachineVirtualCameraBase ParentVirtualCameraBase { get; set; }
	public CinemachineVirtualCamera UseVirtualCamera { get; set; }

	// Methods

	// RVA: 0x1D331B0 Offset: 0x1D332B1 VA: 0x1D331B0
	protected Character get_CtrlCharacter() { }

	// RVA: 0x1D33210 Offset: 0x1D33311 VA: 0x1D33210
	protected Camera get_MainCamera() { }

	// RVA: 0x1D33270 Offset: 0x1D33371 VA: 0x1D33270
	protected void set_ParentVirtualCameraBase(CinemachineVirtualCameraBase value) { }

	// RVA: 0x1D33280 Offset: 0x1D33381 VA: 0x1D33280
	public CinemachineVirtualCameraBase get_ParentVirtualCameraBase() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B2C0 Offset: 0x19B3C1 VA: 0x19B2C0
	// RVA: 0x1D33290 Offset: 0x1D33391 VA: 0x1D33290
	protected void set_UseVirtualCamera(CinemachineVirtualCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B2D0 Offset: 0x19B3D1 VA: 0x19B2D0
	// RVA: 0x1D332A0 Offset: 0x1D333A1 VA: 0x1D332A0
	public CinemachineVirtualCamera get_UseVirtualCamera() { }

	// RVA: 0x1D332B0 Offset: 0x1D333B1 VA: 0x1D332B0 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1D33370 Offset: 0x1D33471 VA: 0x1D33370 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x1D33380 Offset: 0x1D33481 VA: 0x1D33380 Slot: 6
	public virtual void EnableCameraSetup(UseCameraType prevCameraType, CinemachineVirtualCamera vcam) { }

	// RVA: 0x1D33390 Offset: 0x1D33491 VA: 0x1D33390 Slot: 7
	public virtual void DisableCameraSetup(UseCameraType nextCameraType, CinemachineVirtualCamera vcam) { }

	// RVA: 0x1D333A0 Offset: 0x1D334A1 VA: 0x1D333A0 Slot: 8
	public virtual void PreFrameUpdate() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void FrameUpdate() { }

	// RVA: 0x1D333B0 Offset: 0x1D334B1 VA: 0x1D333B0 Slot: 10
	public virtual void TimeStepUpdate() { }

	// RVA: 0x1D333C0 Offset: 0x1D334C1 VA: 0x1D333C0
	protected void .ctor() { }
}

