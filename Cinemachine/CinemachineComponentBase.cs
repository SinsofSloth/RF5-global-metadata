[DocumentationSortingAttribute] // RVA: 0x12EDD0 Offset: 0x12EED1 VA: 0x12EDD0
public abstract class CinemachineComponentBase : MonoBehaviour // TypeDefIndex: 4822
{
	// Fields
	protected const float Epsilon = 0.0001;
	private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
	private Transform mCachedFollowTarget; // 0x20
	private CinemachineVirtualCameraBase mCachedFollowTargetVcam; // 0x28
	private ICinemachineTargetGroup mCachedFollowTargetGroup; // 0x30
	private Transform mCachedLookAtTarget; // 0x38
	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x40
	private ICinemachineTargetGroup mCachedLookAtTargetGroup; // 0x48

	// Properties
	public CinemachineVirtualCameraBase VirtualCamera { get; }
	public Transform FollowTarget { get; }
	public Transform LookAtTarget { get; }
	public ICinemachineTargetGroup AbstractFollowTargetGroup { get; }
	public CinemachineTargetGroup FollowTargetGroup { get; }
	public Vector3 FollowTargetPosition { get; }
	public Quaternion FollowTargetRotation { get; }
	public ICinemachineTargetGroup AbstractLookAtTargetGroup { get; }
	public CinemachineTargetGroup LookAtTargetGroup { get; }
	public Vector3 LookAtTargetPosition { get; }
	public Quaternion LookAtTargetRotation { get; }
	public CameraState VcamState { get; }
	public abstract bool IsValid { get; }
	public abstract CinemachineCore.Stage Stage { get; }
	public virtual bool BodyAppliesAfterAim { get; }

	// Methods

	// RVA: 0x18875B0 Offset: 0x18876B1 VA: 0x18875B0
	public CinemachineVirtualCameraBase get_VirtualCamera() { }

	// RVA: 0x18873D0 Offset: 0x18874D1 VA: 0x18873D0
	public Transform get_FollowTarget() { }

	// RVA: 0x1896E80 Offset: 0x1896F81 VA: 0x1896E80
	public Transform get_LookAtTarget() { }

	// RVA: 0x1896F30 Offset: 0x1897031 VA: 0x1896F30
	private void UpdateFollowTargetCache() { }

	// RVA: 0x1897060 Offset: 0x1897161 VA: 0x1897060
	public ICinemachineTargetGroup get_AbstractFollowTargetGroup() { }

	// RVA: 0x1897100 Offset: 0x1897201 VA: 0x1897100
	public CinemachineTargetGroup get_FollowTargetGroup() { }

	// RVA: 0x1887C60 Offset: 0x1887D61 VA: 0x1887C60
	public Vector3 get_FollowTargetPosition() { }

	// RVA: 0x1887E70 Offset: 0x1887F71 VA: 0x1887E70
	public Quaternion get_FollowTargetRotation() { }

	// RVA: 0x1897220 Offset: 0x1897321 VA: 0x1897220
	private void UpdateLookAtTargetCache() { }

	// RVA: 0x1897350 Offset: 0x1897451 VA: 0x1897350
	public ICinemachineTargetGroup get_AbstractLookAtTargetGroup() { }

	// RVA: 0x18973F0 Offset: 0x18974F1 VA: 0x18973F0
	public CinemachineTargetGroup get_LookAtTargetGroup() { }

	// RVA: 0x1897510 Offset: 0x1897611 VA: 0x1897510
	public Vector3 get_LookAtTargetPosition() { }

	// RVA: 0x1897720 Offset: 0x1897821 VA: 0x1897720
	public Quaternion get_LookAtTargetRotation() { }

	// RVA: 0x18978F0 Offset: 0x18979F1 VA: 0x18978F0
	public CameraState get_VcamState() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsValid() { }

	// RVA: 0x18979D0 Offset: 0x1897AD1 VA: 0x18979D0 Slot: 5
	public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract CinemachineCore.Stage get_Stage() { }

	// RVA: 0x18979E0 Offset: 0x1897AE1 VA: 0x18979E0 Slot: 7
	public virtual bool get_BodyAppliesAfterAim() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x18979F0 Offset: 0x1897AF1 VA: 0x18979F0 Slot: 9
	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	// RVA: 0x1897A00 Offset: 0x1897B01 VA: 0x1897A00 Slot: 10
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1897A10 Offset: 0x1897B11 VA: 0x1897A10 Slot: 11
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1897A20 Offset: 0x1897B21 VA: 0x1897A20 Slot: 12
	public virtual float GetMaxDampTime() { }

	// RVA: 0x1888520 Offset: 0x1888621 VA: 0x1888520
	protected void .ctor() { }
}

