public class FestivalCamera : MonoBehaviour // TypeDefIndex: 7362
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x165EE0 Offset: 0x165FE1 VA: 0x165EE0
	private Animator <Animator>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x165EF0 Offset: 0x165FF1 VA: 0x165EF0
	private CinemachineVirtualCameraBase <CameraBase>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x165F00 Offset: 0x166001 VA: 0x165F00
	private CinemachineVirtualCamera <Camera>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x165F10 Offset: 0x166011 VA: 0x165F10
	private bool <IsShaking>k__BackingField; // 0x30
	[SerializeField] // RVA: 0x165F20 Offset: 0x166021 VA: 0x165F20
	private float shakePower; // 0x34
	[SerializeField] // RVA: 0x165F30 Offset: 0x166031 VA: 0x165F30
	private float shakeSpeed; // 0x38
	[SerializeField] // RVA: 0x165F40 Offset: 0x166041 VA: 0x165F40
	private float shakeTime; // 0x3C

	// Properties
	public Animator Animator { get; set; }
	public CinemachineVirtualCameraBase CameraBase { get; set; }
	public CinemachineVirtualCamera Camera { get; set; }
	protected bool IsShaking { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A0300 Offset: 0x1A0401 VA: 0x1A0300
	// RVA: 0x1E1F800 Offset: 0x1E1F901 VA: 0x1E1F800
	public Animator get_Animator() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0310 Offset: 0x1A0411 VA: 0x1A0310
	// RVA: 0x1E1F810 Offset: 0x1E1F911 VA: 0x1E1F810
	private void set_Animator(Animator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0320 Offset: 0x1A0421 VA: 0x1A0320
	// RVA: 0x1E1F820 Offset: 0x1E1F921 VA: 0x1E1F820
	public CinemachineVirtualCameraBase get_CameraBase() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0330 Offset: 0x1A0431 VA: 0x1A0330
	// RVA: 0x1E1F830 Offset: 0x1E1F931 VA: 0x1E1F830
	private void set_CameraBase(CinemachineVirtualCameraBase value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0340 Offset: 0x1A0441 VA: 0x1A0340
	// RVA: 0x1E1F840 Offset: 0x1E1F941 VA: 0x1E1F840
	public CinemachineVirtualCamera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0350 Offset: 0x1A0451 VA: 0x1A0350
	// RVA: 0x1E1F850 Offset: 0x1E1F951 VA: 0x1E1F850
	private void set_Camera(CinemachineVirtualCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0360 Offset: 0x1A0461 VA: 0x1A0360
	// RVA: 0x1E1F860 Offset: 0x1E1F961 VA: 0x1E1F860
	protected bool get_IsShaking() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0370 Offset: 0x1A0471 VA: 0x1A0370
	// RVA: 0x1E1F870 Offset: 0x1E1F971 VA: 0x1E1F870
	private void set_IsShaking(bool value) { }

	// RVA: 0x1E1F880 Offset: 0x1E1F981 VA: 0x1E1F880 Slot: 4
	protected virtual void Awake() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0380 Offset: 0x1A0481 VA: 0x1A0380
	// RVA: 0x1E1F9F0 Offset: 0x1E1FAF1 VA: 0x1E1F9F0
	public IEnumerator CountDownCamera() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A03F0 Offset: 0x1A04F1 VA: 0x1A03F0
	// RVA: 0x1E1FAA0 Offset: 0x1E1FBA1 VA: 0x1E1FAA0
	public IEnumerator CameraShake() { }

	// RVA: 0x1E1FB50 Offset: 0x1E1FC51 VA: 0x1E1FB50
	public void .ctor() { }
}

