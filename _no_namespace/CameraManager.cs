public class CameraManager : SingletonMonoBehaviour<CameraManager> // TypeDefIndex: 6483
{
	// Fields
	private Dictionary<UseCameraType, int> GetSelectVcamBasePriority; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15CD90 Offset: 0x15CE91 VA: 0x15CD90
	private PlayerCameraController <PlayerCameraController>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15CDA0 Offset: 0x15CEA1 VA: 0x15CDA0
	private ShortPlayCameraController <ShortPlayCameraController>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15CDB0 Offset: 0x15CEB1 VA: 0x15CDB0
	private FishingCameraController <FishingCameraController>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15CDC0 Offset: 0x15CEC1 VA: 0x15CDC0
	private UseCameraType <CurrentCameraType>k__BackingField; // 0x38
	[SerializeField] // RVA: 0x15CDD0 Offset: 0x15CED1 VA: 0x15CDD0
	private Camera _MainCamera; // 0x40
	[SerializeField] // RVA: 0x15CDE0 Offset: 0x15CEE1 VA: 0x15CDE0
	private CinemachineBrain _CinemachineBrain; // 0x48
	[SerializeField] // RVA: 0x15CDF0 Offset: 0x15CEF1 VA: 0x15CDF0
	private FxPro _FxPro; // 0x50
	[SerializeField] // RVA: 0x15CE00 Offset: 0x15CF01 VA: 0x15CE00
	private Bloom _Bloom; // 0x58
	[SerializeField] // RVA: 0x15CE10 Offset: 0x15CF11 VA: 0x15CE10
	private List<CameraManager.CameraControllerPair> CameraControllerPairs; // 0x60
	private UseCameraType PrevCameraType; // 0x68
	private bool IsHideCullingMask; // 0x6C
	private int DefaultCullingMask; // 0x70
	private Camera ActiveCamera; // 0x78
	public OnChangeActiveCameraEvent OnChangeActiveCamaraEvent; // 0x80
	private Transform NearCameraTargetTransform; // 0x88
	private CinemachineBrain.BrainUpdateMethod TempBrainUpdateMethod; // 0x90

	// Properties
	public Camera MainCamera { get; set; }
	public CinemachineBrain CinemachineBrain { get; set; }
	public FxPro FxPro { get; }
	public Bloom Bloom { get; }
	public PlayerCameraController PlayerCameraController { get; set; }
	public ShortPlayCameraController ShortPlayCameraController { get; set; }
	public FishingCameraController FishingCameraController { get; set; }
	public UseCameraType CurrentCameraType { get; set; }

	// Methods

	// RVA: 0x1D34200 Offset: 0x1D34301 VA: 0x1D34200
	private void set_MainCamera(Camera value) { }

	// RVA: 0x1D34290 Offset: 0x1D34391 VA: 0x1D34290
	public Camera get_MainCamera() { }

	// RVA: 0x1D342A0 Offset: 0x1D343A1 VA: 0x1D342A0
	private void set_CinemachineBrain(CinemachineBrain value) { }

	// RVA: 0x1D342B0 Offset: 0x1D343B1 VA: 0x1D342B0
	public CinemachineBrain get_CinemachineBrain() { }

	// RVA: 0x1D342C0 Offset: 0x1D343C1 VA: 0x1D342C0
	public FxPro get_FxPro() { }

	// RVA: 0x1D342D0 Offset: 0x1D343D1 VA: 0x1D342D0
	public Bloom get_Bloom() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B2E0 Offset: 0x19B3E1 VA: 0x19B2E0
	// RVA: 0x1D342E0 Offset: 0x1D343E1 VA: 0x1D342E0
	private void set_PlayerCameraController(PlayerCameraController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B2F0 Offset: 0x19B3F1 VA: 0x19B2F0
	// RVA: 0x1D342F0 Offset: 0x1D343F1 VA: 0x1D342F0
	public PlayerCameraController get_PlayerCameraController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B300 Offset: 0x19B401 VA: 0x19B300
	// RVA: 0x1D34300 Offset: 0x1D34401 VA: 0x1D34300
	private void set_ShortPlayCameraController(ShortPlayCameraController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B310 Offset: 0x19B411 VA: 0x19B310
	// RVA: 0x1D34310 Offset: 0x1D34411 VA: 0x1D34310
	public ShortPlayCameraController get_ShortPlayCameraController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B320 Offset: 0x19B421 VA: 0x19B320
	// RVA: 0x1D34320 Offset: 0x1D34421 VA: 0x1D34320
	private void set_FishingCameraController(FishingCameraController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B330 Offset: 0x19B431 VA: 0x19B330
	// RVA: 0x1D34330 Offset: 0x1D34431 VA: 0x1D34330
	public FishingCameraController get_FishingCameraController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B340 Offset: 0x19B441 VA: 0x19B340
	// RVA: 0x1D34340 Offset: 0x1D34441 VA: 0x1D34340
	private void set_CurrentCameraType(UseCameraType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B350 Offset: 0x19B451 VA: 0x19B350
	// RVA: 0x1D34350 Offset: 0x1D34451 VA: 0x1D34350
	public UseCameraType get_CurrentCameraType() { }

	// RVA: 0x1D34360 Offset: 0x1D34461 VA: 0x1D34360 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1D34AC0 Offset: 0x1D34BC1 VA: 0x1D34AC0
	private void Start() { }

	// RVA: 0x1D34AE0 Offset: 0x1D34BE1 VA: 0x1D34AE0
	private void Update() { }

	// RVA: 0x1D34EA0 Offset: 0x1D34FA1 VA: 0x1D34EA0
	private void FixedUpdate() { }

	// RVA: 0x1D350D0 Offset: 0x1D351D1 VA: 0x1D350D0
	public void UseCamera(UseCameraType cameraType, bool isForceBlendCut = False) { }

	// RVA: 0x1D354E0 Offset: 0x1D355E1 VA: 0x1D354E0
	public void UsePlayableCamera() { }

	// RVA: 0x1D35890 Offset: 0x1D35991 VA: 0x1D35890
	public static void MainCameraSetActive(bool active) { }

	// RVA: 0x1D35A70 Offset: 0x1D35B71 VA: 0x1D35A70
	public void SetupMiniGameCamera(CinemachineVirtualCameraBase cinemachineVirtualCameraBase) { }

	// RVA: 0x1D35A90 Offset: 0x1D35B91 VA: 0x1D35A90
	public void SetupLandscapeCamera(CinemachineVirtualCameraBase cinemachineVirtualCameraBase) { }

	// RVA: 0x1D35AB0 Offset: 0x1D35BB1 VA: 0x1D35AB0
	public void HideAllCullingMask() { }

	// RVA: 0x1D34250 Offset: 0x1D34351 VA: 0x1D34250
	public void UnhideAllCullingMask() { }

	// RVA: 0x1D35B10 Offset: 0x1D35C11 VA: 0x1D35B10
	public void SetActiveCamera(Camera setCamera) { }

	// RVA: 0x1D359A0 Offset: 0x1D35AA1 VA: 0x1D359A0
	public void ResetActiveCamera(bool activeMainCamera = True) { }

	// RVA: 0x1D35BE0 Offset: 0x1D35CE1 VA: 0x1D35BE0
	public Camera GetActiveCamera() { }

	// RVA: 0x1D35E20 Offset: 0x1D35F21 VA: 0x1D35E20
	public void SetDOFTarget(Transform trans) { }

	// RVA: 0x1D35E50 Offset: 0x1D35F51 VA: 0x1D35E50
	public void ResetDOFTarget() { }

	// RVA: 0x1D35E80 Offset: 0x1D35F81 VA: 0x1D35E80
	public void ForceMoveMainCamra(UseCameraType useCameraType, CinemachineVirtualCamera cinemachineVirtualCamera) { }

	// RVA: 0x1D34CB0 Offset: 0x1D34DB1 VA: 0x1D34CB0
	private void FrameUpdateCameraControllers() { }

	// RVA: 0x1D34EB0 Offset: 0x1D34FB1 VA: 0x1D34EB0
	private void TimeStepUpdateCameraControllers() { }

	// RVA: 0x1D36060 Offset: 0x1D36161 VA: 0x1D36060
	private bool IsNotFrameUpdateCamera(UseCameraType useCameraType) { }

	// RVA: 0x1D361C0 Offset: 0x1D362C1 VA: 0x1D361C0
	private bool IsNotTimeStepUpdateCamera(UseCameraType useCameraType) { }

	// RVA: 0x1D35220 Offset: 0x1D35321 VA: 0x1D35220
	private void SetUseCamera(UseCameraType cameraType) { }

	// RVA: 0x1D35180 Offset: 0x1D35281 VA: 0x1D35180
	private void SetUseCameraBlendCut(UseCameraType cameraType) { }

	[IteratorStateMachineAttribute] // RVA: 0x19B360 Offset: 0x19B461 VA: 0x19B360
	// RVA: 0x1D36420 Offset: 0x1D36521 VA: 0x1D36420
	private IEnumerator BlendCutAsync(UseCameraType cameraType) { }

	// RVA: 0x1D349A0 Offset: 0x1D34AA1 VA: 0x1D349A0
	private CameraControllerBase GetCameraController(UseCameraType cameraType) { }

	// RVA: 0x1D36260 Offset: 0x1D36361 VA: 0x1D36260
	private void DisableHigherPriorityVcamBase(UseCameraType cameraType) { }

	// RVA: 0x1D35510 Offset: 0x1D35611 VA: 0x1D35510
	private UseCameraType GetActiveCameraTypeFromPriority(CameraManager.VCamPriority priority) { }

	// RVA: 0x1D35CC0 Offset: 0x1D35DC1 VA: 0x1D35CC0
	private Camera FindActiveCamera() { }

	// RVA: 0x1D34B10 Offset: 0x1D34C11 VA: 0x1D34B10
	private void UpdateActiveCamera() { }

	// RVA: 0x1D364E0 Offset: 0x1D365E1 VA: 0x1D364E0
	public void .ctor() { }
}

