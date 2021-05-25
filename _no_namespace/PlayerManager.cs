public class PlayerManager : MonoBehaviour // TypeDefIndex: 6723
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15F190 Offset: 0x15F291 VA: 0x15F190
	private static bool <IsActive>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x15F1A0 Offset: 0x15F2A1 VA: 0x15F1A0
	private static Actor <Actor>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x15F1B0 Offset: 0x15F2B1 VA: 0x15F1B0
	private static Character <Character>k__BackingField; // 0x10
	[SerializeField] // RVA: 0x15F1C0 Offset: 0x15F2C1 VA: 0x15F1C0
	private PlayerInput playerInput; // 0x18
	[SerializeField] // RVA: 0x15F1D0 Offset: 0x15F2D1 VA: 0x15F1D0
	private PlayerCameraController playerCamera; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15F1E0 Offset: 0x15F2E1 VA: 0x15F1E0
	private float <SeedSupportCountdown>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x15F1F0 Offset: 0x15F2F1 VA: 0x15F1F0
	private static PlayerManager <Instance>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x15F200 Offset: 0x15F301 VA: 0x15F200
	private Vector3 <SpawnPosition>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x15F210 Offset: 0x15F311 VA: 0x15F210
	private Quaternion <SpawnRotation>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x15F220 Offset: 0x15F321 VA: 0x15F220
	private float <DeadTime>k__BackingField; // 0x48
	private PlayerManager.STATE updateState; // 0x4C

	// Properties
	public static bool IsActive { get; set; }
	public static Actor Actor { get; set; }
	public static Character Character { get; set; }
	public static CharacterStatusBase StatusController { get; }
	public static bool IsDead { get; }
	public static PlayerInput PlayerInput { get; }
	public static PlayerCameraController PlayerCameraController { get; }
	public float SeedSupportCountdown { get; set; }
	private static PlayerManager Instance { get; set; }
	private Vector3 SpawnPosition { get; set; }
	private Quaternion SpawnRotation { get; set; }
	private float DeadTime { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19CBB0 Offset: 0x19CCB1 VA: 0x19CBB0
	// RVA: 0x2200910 Offset: 0x2200A11 VA: 0x2200910
	public static bool get_IsActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CBC0 Offset: 0x19CCC1 VA: 0x19CBC0
	// RVA: 0x2200960 Offset: 0x2200A61 VA: 0x2200960
	private static void set_IsActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CBD0 Offset: 0x19CCD1 VA: 0x19CBD0
	// RVA: 0x22009C0 Offset: 0x2200AC1 VA: 0x22009C0
	public static Actor get_Actor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CBE0 Offset: 0x19CCE1 VA: 0x19CBE0
	// RVA: 0x2200A10 Offset: 0x2200B11 VA: 0x2200A10
	private static void set_Actor(Actor value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CBF0 Offset: 0x19CCF1 VA: 0x19CBF0
	// RVA: 0x2200A70 Offset: 0x2200B71 VA: 0x2200A70
	public static Character get_Character() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CC00 Offset: 0x19CD01 VA: 0x19CC00
	// RVA: 0x2200AC0 Offset: 0x2200BC1 VA: 0x2200AC0
	private static void set_Character(Character value) { }

	// RVA: 0x2200B20 Offset: 0x2200C21 VA: 0x2200B20
	public static CharacterStatusBase get_StatusController() { }

	// RVA: 0x2200C30 Offset: 0x2200D31 VA: 0x2200C30
	public static bool get_IsDead() { }

	// RVA: 0x2200D50 Offset: 0x2200E51 VA: 0x2200D50
	public static PlayerInput get_PlayerInput() { }

	// RVA: 0x2200E50 Offset: 0x2200F51 VA: 0x2200E50
	public static PlayerCameraController get_PlayerCameraController() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CC10 Offset: 0x19CD11 VA: 0x19CC10
	// RVA: 0x2200F50 Offset: 0x2201051 VA: 0x2200F50
	public float get_SeedSupportCountdown() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CC20 Offset: 0x19CD21 VA: 0x19CC20
	// RVA: 0x2200F60 Offset: 0x2201061 VA: 0x2200F60
	private void set_SeedSupportCountdown(float value) { }

	// RVA: 0x2200F70 Offset: 0x2201071 VA: 0x2200F70
	public static void SetPlayer(Character character) { }

	// RVA: 0x2201110 Offset: 0x2201211 VA: 0x2201110
	public static void SpawnPlayer(Vector3 position, Quaternion rotation) { }

	// RVA: 0x22012B0 Offset: 0x22013B1 VA: 0x22012B0
	public static void SpawnPlayer() { }

	// RVA: 0x2201430 Offset: 0x2201531 VA: 0x2201430
	public static void ResetPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CC30 Offset: 0x19CD31 VA: 0x19CC30
	// RVA: 0x2201610 Offset: 0x2201711 VA: 0x2201610
	private static PlayerManager get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CC40 Offset: 0x19CD41 VA: 0x19CC40
	// RVA: 0x2201660 Offset: 0x2201761 VA: 0x2201660
	private static void set_Instance(PlayerManager value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CC50 Offset: 0x19CD51 VA: 0x19CC50
	// RVA: 0x22016C0 Offset: 0x22017C1 VA: 0x22016C0
	private Vector3 get_SpawnPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CC60 Offset: 0x19CD61 VA: 0x19CC60
	// RVA: 0x22016D0 Offset: 0x22017D1 VA: 0x22016D0
	private void set_SpawnPosition(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CC70 Offset: 0x19CD71 VA: 0x19CC70
	// RVA: 0x22016E0 Offset: 0x22017E1 VA: 0x22016E0
	private Quaternion get_SpawnRotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CC80 Offset: 0x19CD81 VA: 0x19CC80
	// RVA: 0x22016F0 Offset: 0x22017F1 VA: 0x22016F0
	private void set_SpawnRotation(Quaternion value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CC90 Offset: 0x19CD91 VA: 0x19CC90
	// RVA: 0x2201710 Offset: 0x2201811 VA: 0x2201710
	private float get_DeadTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CCA0 Offset: 0x19CDA1 VA: 0x19CCA0
	// RVA: 0x2201720 Offset: 0x2201821 VA: 0x2201720
	private void set_DeadTime(float value) { }

	// RVA: 0x2201730 Offset: 0x2201831 VA: 0x2201730
	private void Init() { }

	// RVA: 0x2201810 Offset: 0x2201911 VA: 0x2201810
	private void Awake() { }

	// RVA: 0x2201910 Offset: 0x2201A11 VA: 0x2201910
	private void OnDestroy() { }

	// RVA: 0x2201920 Offset: 0x2201A21 VA: 0x2201920
	private void Start() { }

	// RVA: 0x22019D0 Offset: 0x2201AD1 VA: 0x22019D0
	private void Update() { }

	// RVA: 0x2202470 Offset: 0x2202571 VA: 0x2202470
	private void InitSeedSupportParam() { }

	// RVA: 0x2202180 Offset: 0x2202281 VA: 0x2202180
	private bool UpdateSeedSupport() { }

	// RVA: 0x22024A0 Offset: 0x22025A1 VA: 0x22024A0
	private void OnNextDay(int carryDay) { }

	// RVA: 0x22027C0 Offset: 0x22028C1 VA: 0x22027C0
	public void .ctor() { }
}

