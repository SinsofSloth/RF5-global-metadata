[DefaultExecutionOrder] // RVA: 0x145E50 Offset: 0x145F51 VA: 0x145E50
public class FestivalCharacterController : HumanController // TypeDefIndex: 6627
{
	// Fields
	[SerializeField] // RVA: 0x15E250 Offset: 0x15E351 VA: 0x15E250
	[RangeAttribute] // RVA: 0x15E250 Offset: 0x15E351 VA: 0x15E250
	private float inputMoveSensitivity; // 0x238
	[CompilerGeneratedAttribute] // RVA: 0x15E290 Offset: 0x15E391 VA: 0x15E290
	private FestivalCharacterController.MoveWay <NextMoveWay>k__BackingField; // 0x23C
	[CompilerGeneratedAttribute] // RVA: 0x15E2A0 Offset: 0x15E3A1 VA: 0x15E2A0
	private Vector3 <NextDir>k__BackingField; // 0x240
	private float currentMoveSpeed; // 0x24C
	private float playerMoveMaxSpeed; // 0x250
	private float playerAcceleration; // 0x254
	private float playerDeceleration; // 0x258
	[SerializeField] // RVA: 0x15E2B0 Offset: 0x15E3B1 VA: 0x15E2B0
	private float beanSowingPlayerMoveMaxSpeed; // 0x25C
	[SerializeField] // RVA: 0x15E2C0 Offset: 0x15E3C1 VA: 0x15E2C0
	private float beanSowingPlayerAcceleration; // 0x260
	[SerializeField] // RVA: 0x15E2D0 Offset: 0x15E3D1 VA: 0x15E2D0
	private float beanSowingPlayerDeceleration; // 0x264
	[SerializeField] // RVA: 0x15E2E0 Offset: 0x15E3E1 VA: 0x15E2E0
	private float beanSowingSmoothRotation; // 0x268
	[SerializeField] // RVA: 0x15E2F0 Offset: 0x15E3F1 VA: 0x15E2F0
	private float snowmanPlayerMoveMaxSpeed; // 0x26C
	[SerializeField] // RVA: 0x15E300 Offset: 0x15E401 VA: 0x15E300
	private float snowmanPlayerAcceleration; // 0x270
	[SerializeField] // RVA: 0x15E310 Offset: 0x15E411 VA: 0x15E310
	private float snowmanPlayerDeceleration; // 0x274
	[SerializeField] // RVA: 0x15E320 Offset: 0x15E421 VA: 0x15E320
	private float snowmanPlayerSmoothRotation; // 0x278
	[SerializeField] // RVA: 0x15E330 Offset: 0x15E431 VA: 0x15E330
	private float snowmanCameraFollowSpeed; // 0x27C
	[SerializeField] // RVA: 0x15E340 Offset: 0x15E441 VA: 0x15E340
	private float snowmanCameraRotateSpeed; // 0x280
	[CompilerGeneratedAttribute] // RVA: 0x15E350 Offset: 0x15E451 VA: 0x15E350
	private float <SnowmanCurrentMoveRate>k__BackingField; // 0x284
	[SerializeField] // RVA: 0x15E360 Offset: 0x15E461 VA: 0x15E360
	private float baffamoPlayerMoveMaxSpeed; // 0x288
	[SerializeField] // RVA: 0x15E370 Offset: 0x15E471 VA: 0x15E370
	private float baffamoPlayerAcceleration; // 0x28C
	[SerializeField] // RVA: 0x15E380 Offset: 0x15E481 VA: 0x15E380
	private float baffamoPlayerDeceleration; // 0x290
	[SerializeField] // RVA: 0x15E390 Offset: 0x15E491 VA: 0x15E390
	private float baffamoPlayerSmoothRotation; // 0x294
	private const float AVOID_FORCE = 10;
	private readonly Dictionary<Gender, List<SoundID>> ROLLING_VOICE; // 0x298
	private Gender playerGender; // 0x2A0

	// Properties
	public float InputMoveSensitivity { get; }
	public FestivalCharacterController.MoveWay NextMoveWay { get; set; }
	public Vector3 NextDir { get; set; }
	private float WalkSpeedRate { get; }
	public float SnowmanCameraFollowSpeed { get; }
	public float SnowmanCameraRotateSpeed { get; }
	public float SnowmanCurrentMoveRate { get; set; }

	// Methods

	// RVA: 0x1E20150 Offset: 0x1E20251 VA: 0x1E20150
	public float get_InputMoveSensitivity() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C2E0 Offset: 0x19C3E1 VA: 0x19C2E0
	// RVA: 0x1E20160 Offset: 0x1E20261 VA: 0x1E20160
	public FestivalCharacterController.MoveWay get_NextMoveWay() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C2F0 Offset: 0x19C3F1 VA: 0x19C2F0
	// RVA: 0x1E20170 Offset: 0x1E20271 VA: 0x1E20170
	public void set_NextMoveWay(FestivalCharacterController.MoveWay value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19C300 Offset: 0x19C401 VA: 0x19C300
	// RVA: 0x1E20180 Offset: 0x1E20281 VA: 0x1E20180
	public Vector3 get_NextDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C310 Offset: 0x19C411 VA: 0x19C310
	// RVA: 0x1E20190 Offset: 0x1E20291 VA: 0x1E20190
	private void set_NextDir(Vector3 value) { }

	// RVA: 0x1E201A0 Offset: 0x1E202A1 VA: 0x1E201A0
	private float get_WalkSpeedRate() { }

	// RVA: 0x1E20210 Offset: 0x1E20311 VA: 0x1E20210
	public float get_SnowmanCameraFollowSpeed() { }

	// RVA: 0x1E20220 Offset: 0x1E20321 VA: 0x1E20220
	public float get_SnowmanCameraRotateSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C320 Offset: 0x19C421 VA: 0x19C320
	// RVA: 0x1E20230 Offset: 0x1E20331 VA: 0x1E20230
	public float get_SnowmanCurrentMoveRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x19C330 Offset: 0x19C431 VA: 0x19C330
	// RVA: 0x1E20240 Offset: 0x1E20341 VA: 0x1E20240
	private void set_SnowmanCurrentMoveRate(float value) { }

	// RVA: 0x1E20250 Offset: 0x1E20351 VA: 0x1E20250 Slot: 11
	protected override void Awake() { }

	// RVA: 0x1E20260 Offset: 0x1E20361 VA: 0x1E20260 Slot: 12
	protected override void Start() { }

	// RVA: 0x1E202B0 Offset: 0x1E203B1 VA: 0x1E202B0 Slot: 40
	protected override void Update() { }

	// RVA: 0x1E202C0 Offset: 0x1E203C1 VA: 0x1E202C0 Slot: 42
	protected override void FixedUpdate() { }

	// RVA: 0x1E211E0 Offset: 0x1E212E1 VA: 0x1E211E0
	public void SetupFestivalPlayer() { }

	// RVA: 0x1E21400 Offset: 0x1E21501 VA: 0x1E21400 Slot: 95
	public override void Avoid() { }

	// RVA: 0x1E21A00 Offset: 0x1E21B01 VA: 0x1E21A00 Slot: 49
	public override bool InputMove(Vector3 _vector) { }

	// RVA: 0x1E20510 Offset: 0x1E20611 VA: 0x1E20510
	private void UpdateBeansowingMovement() { }

	// RVA: 0x1E20930 Offset: 0x1E20A31 VA: 0x1E20930
	private void UpdateBaffamoMovement() { }

	// RVA: 0x1E20D50 Offset: 0x1E20E51 VA: 0x1E20D50
	private void UpdateSnowmanMovement() { }

	// RVA: 0x1E21AD0 Offset: 0x1E21BD1 VA: 0x1E21AD0
	private float GetSnowmanMoveSpeed() { }

	// RVA: 0x1E21940 Offset: 0x1E21A41 VA: 0x1E21940
	public void PlayMotion(string _name, Nullable<float> _repeat_time) { }

	// RVA: 0x1E21C50 Offset: 0x1E21D51 VA: 0x1E21C50
	public void PlayRollingVoice() { }

	// RVA: 0x1E21D90 Offset: 0x1E21E91 VA: 0x1E21D90 Slot: 18
	public override void OnSwitchActorBase(bool _on) { }

	// RVA: 0x1E21E10 Offset: 0x1E21F11 VA: 0x1E21E10
	public void .ctor() { }
}

