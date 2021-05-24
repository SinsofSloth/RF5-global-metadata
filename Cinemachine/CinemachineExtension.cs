[DocumentationSortingAttribute] // RVA: 0x12EDF0 Offset: 0x12EEF1 VA: 0x12EDF0
public abstract class CinemachineExtension : MonoBehaviour // TypeDefIndex: 4830
{
	// Fields
	protected const float Epsilon = 0.0001;
	private CinemachineVirtualCameraBase m_vcamOwner; // 0x18
	private Dictionary<ICinemachineCamera, object> mExtraState; // 0x20

	// Properties
	public CinemachineVirtualCameraBase VirtualCamera { get; }

	// Methods

	// RVA: 0x1720C90 Offset: 0x1720D91 VA: 0x1720C90
	public CinemachineVirtualCameraBase get_VirtualCamera() { }

	// RVA: 0x1720D40 Offset: 0x1720E41 VA: 0x1720D40 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1720D50 Offset: 0x1720E51 VA: 0x1720D50 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x1720D60 Offset: 0x1720E61 VA: 0x1720D60 Slot: 6
	protected virtual void OnDestroy() { }

	// RVA: 0x1720D70 Offset: 0x1720E71 VA: 0x1720D70
	internal void EnsureStarted() { }

	// RVA: 0x1720D80 Offset: 0x1720E81 VA: 0x1720D80 Slot: 7
	protected virtual void ConnectToVcam(bool connect) { }

	// RVA: 0x1721030 Offset: 0x1721131 VA: 0x1721030 Slot: 8
	public virtual void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) { }

	// RVA: 0x1721040 Offset: 0x1721141 VA: 0x1721040
	public void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1721050 Offset: 0x1721151 VA: 0x1721050 Slot: 10
	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1721060 Offset: 0x1721161 VA: 0x1721060 Slot: 11
	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1721070 Offset: 0x1721171 VA: 0x1721070 Slot: 12
	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1721080 Offset: 0x1721181 VA: 0x1721080 Slot: 13
	public virtual float GetMaxDampTime() { }

	// RVA: -1 Offset: -1
	protected T GetExtraState<T>(ICinemachineCamera vcam) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23BE8D0 Offset: 0x23BE9D1 VA: 0x23BE8D0
	|-CinemachineExtension.GetExtraState<CinemachineCollider.VcamExtraState>
	|-CinemachineExtension.GetExtraState<CinemachineConfiner.VcamExtraState>
	|-CinemachineExtension.GetExtraState<CinemachineFollowZoom.VcamExtraState>
	|-CinemachineExtension.GetExtraState<object>
	*/

	// RVA: -1 Offset: -1
	protected List<T> GetAllExtraStates<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21AA700 Offset: 0x21AA801 VA: 0x21AA700
	|-CinemachineExtension.GetAllExtraStates<CinemachineCollider.VcamExtraState>
	|-CinemachineExtension.GetAllExtraStates<object>
	*/

	// RVA: 0x1721090 Offset: 0x1721191 VA: 0x1721090
	protected void .ctor() { }
}

