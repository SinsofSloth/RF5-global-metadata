public sealed class CinemachineCore // TypeDefIndex: 4824
{
	// Fields
	public static readonly int kStreamingVersion; // 0x0
	public static readonly string kVersionString; // 0x8
	private static CinemachineCore sInstance; // 0x10
	public static bool sShowHiddenObjects; // 0x18
	public static CinemachineCore.AxisInputDelegate GetInputAxis; // 0x20
	public static float UniformDeltaTimeOverride; // 0x28
	public static float CurrentTimeOverride; // 0x2C
	public static CinemachineCore.GetBlendOverrideDelegate GetBlendOverride; // 0x30
	public static CinemachineBrain.BrainEvent CameraUpdatedEvent; // 0x38
	public static CinemachineBrain.BrainEvent CameraCutEvent; // 0x40
	private List<CinemachineBrain> mActiveBrains; // 0x10
	private List<CinemachineVirtualCameraBase> mActiveCameras; // 0x18
	private List<List<CinemachineVirtualCameraBase>> mAllCameras; // 0x20
	private CinemachineVirtualCameraBase mRoundRobinVcamLastFrame; // 0x28
	private static float mLastUpdateTime; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x1345E0 Offset: 0x1346E1 VA: 0x1345E0
	private static int <FixedFrameCount>k__BackingField; // 0x4C
	private Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus> mUpdateStatus; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x1345F0 Offset: 0x1346F1 VA: 0x1345F0
	private CinemachineCore.UpdateFilter <CurrentUpdateFilter>k__BackingField; // 0x38

	// Properties
	public static CinemachineCore Instance { get; }
	public static float DeltaTime { get; }
	public static float CurrentTime { get; }
	public int BrainCount { get; }
	public int VirtualCameraCount { get; }
	private static int FixedFrameCount { get; set; }
	internal CinemachineCore.UpdateFilter CurrentUpdateFilter { get; set; }

	// Methods

	// RVA: 0x188AA00 Offset: 0x188AB01 VA: 0x188AA00
	public static CinemachineCore get_Instance() { }

	// RVA: 0x188BBE0 Offset: 0x188BCE1 VA: 0x188BBE0
	public static float get_DeltaTime() { }

	// RVA: 0x1882940 Offset: 0x1882A41 VA: 0x1882940
	public static float get_CurrentTime() { }

	// RVA: 0x189B470 Offset: 0x189B571 VA: 0x189B470
	public int get_BrainCount() { }

	// RVA: 0x189B4C0 Offset: 0x189B5C1 VA: 0x189B4C0
	public CinemachineBrain GetActiveBrain(int index) { }

	// RVA: 0x188C240 Offset: 0x188C341 VA: 0x188C240
	internal void AddActiveBrain(CinemachineBrain brain) { }

	// RVA: 0x188C5A0 Offset: 0x188C6A1 VA: 0x188C5A0
	internal void RemoveActiveBrain(CinemachineBrain brain) { }

	// RVA: 0x188F680 Offset: 0x188F781 VA: 0x188F680
	public int get_VirtualCameraCount() { }

	// RVA: 0x188F6D0 Offset: 0x188F7D1 VA: 0x188F6D0
	public CinemachineVirtualCameraBase GetVirtualCamera(int index) { }

	// RVA: 0x189B540 Offset: 0x189B641 VA: 0x189B540
	internal void AddActiveCamera(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x189B680 Offset: 0x189B781 VA: 0x189B680
	internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x189B6F0 Offset: 0x189B7F1 VA: 0x189B6F0
	internal void CameraDestroyed(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x189B7D0 Offset: 0x189B8D1 VA: 0x189B7D0
	internal void CameraEnabled(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x189B960 Offset: 0x189BA61 VA: 0x189B960
	internal void CameraDisabled(CinemachineVirtualCameraBase vcam) { }

	[CompilerGeneratedAttribute] // RVA: 0x137140 Offset: 0x137241 VA: 0x137140
	// RVA: 0x189BA70 Offset: 0x189BB71 VA: 0x189BA70
	private static int get_FixedFrameCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x137150 Offset: 0x137251 VA: 0x137150
	// RVA: 0x189BAE0 Offset: 0x189BBE1 VA: 0x189BAE0
	private static void set_FixedFrameCount(int value) { }

	// RVA: 0x188E340 Offset: 0x188E441 VA: 0x188E340
	internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x189BB50 Offset: 0x189BC51 VA: 0x189BB50
	internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime) { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x137160 Offset: 0x137261 VA: 0x137160
	// RVA: 0x189C060 Offset: 0x189C161 VA: 0x189C060
	private static void InitializeModule() { }

	[CompilerGeneratedAttribute] // RVA: 0x137170 Offset: 0x137271 VA: 0x137170
	// RVA: 0x189C100 Offset: 0x189C201 VA: 0x189C100
	internal CinemachineCore.UpdateFilter get_CurrentUpdateFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x137180 Offset: 0x137281 VA: 0x137180
	// RVA: 0x189C110 Offset: 0x189C211 VA: 0x189C110
	internal void set_CurrentUpdateFilter(CinemachineCore.UpdateFilter value) { }

	// RVA: 0x189BEF0 Offset: 0x189BFF1 VA: 0x189BEF0
	private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x189C120 Offset: 0x189C221 VA: 0x189C120
	internal UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x188BA80 Offset: 0x188BB81 VA: 0x188BA80
	public bool IsLive(ICinemachineCamera vcam) { }

	// RVA: 0x188AAE0 Offset: 0x188ABE1 VA: 0x188AAE0
	public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom) { }

	// RVA: 0x188AC70 Offset: 0x188AD71 VA: 0x188AC70
	public void GenerateCameraCutEvent(ICinemachineCamera vcam) { }

	// RVA: 0x189C1D0 Offset: 0x189C2D1 VA: 0x189C1D0
	public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x189B380 Offset: 0x189B481 VA: 0x189B380
	public void .ctor() { }

	// RVA: 0x189C610 Offset: 0x189C711 VA: 0x189C610
	private static void .cctor() { }
}

