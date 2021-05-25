public class PlayerSnowball : MonoBehaviour // TypeDefIndex: 7409
{
	// Fields
	public float Scale; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1663B0 Offset: 0x1664B1 VA: 0x1663B0
	private bool <EnableMove>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x1663C0 Offset: 0x1664C1 VA: 0x1663C0
	private bool <IsSpeedUp>k__BackingField; // 0x1D
	[CompilerGeneratedAttribute] // RVA: 0x1663D0 Offset: 0x1664D1 VA: 0x1663D0
	private bool <IsInvincible>k__BackingField; // 0x1E
	[CompilerGeneratedAttribute] // RVA: 0x1663E0 Offset: 0x1664E1 VA: 0x1663E0
	private ParticleSystem <SpeedUpEffect>k__BackingField; // 0x20
	private const float SCALE_MIN = 1;
	private const float SNOWBALL_BASE_DISTANCE = 0.5;
	private const float SNOWBALL_RADIUS = 0.5;
	private const float INVINCIBLE_TIME = 3;
	private float speedUpTimeCount; // 0x28
	private Vector3 pastAxis; // 0x2C
	private float rotateSpeed; // 0x38
	private float effectScale; // 0x3C
	private float effectHeight; // 0x40
	private float effectHeightScale; // 0x44
	private MonsterControllerBase HitMocomoco; // 0x48

	// Properties
	public bool EnableMove { get; set; }
	public bool IsSpeedUp { get; set; }
	public bool IsInvincible { get; set; }
	public ParticleSystem SpeedUpEffect { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A0B10 Offset: 0x1A0C11 VA: 0x1A0B10
	// RVA: 0x22035F0 Offset: 0x22036F1 VA: 0x22035F0
	public bool get_EnableMove() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0B20 Offset: 0x1A0C21 VA: 0x1A0B20
	// RVA: 0x2203600 Offset: 0x2203701 VA: 0x2203600
	private void set_EnableMove(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0B30 Offset: 0x1A0C31 VA: 0x1A0B30
	// RVA: 0x2203610 Offset: 0x2203711 VA: 0x2203610
	public bool get_IsSpeedUp() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0B40 Offset: 0x1A0C41 VA: 0x1A0B40
	// RVA: 0x2203620 Offset: 0x2203721 VA: 0x2203620
	private void set_IsSpeedUp(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0B50 Offset: 0x1A0C51 VA: 0x1A0B50
	// RVA: 0x2203630 Offset: 0x2203731 VA: 0x2203630
	public bool get_IsInvincible() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0B60 Offset: 0x1A0C61 VA: 0x1A0B60
	// RVA: 0x2203640 Offset: 0x2203741 VA: 0x2203640
	public void set_IsInvincible(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0B70 Offset: 0x1A0C71 VA: 0x1A0B70
	// RVA: 0x2203650 Offset: 0x2203751 VA: 0x2203650
	public ParticleSystem get_SpeedUpEffect() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0B80 Offset: 0x1A0C81 VA: 0x1A0B80
	// RVA: 0x2203660 Offset: 0x2203761 VA: 0x2203660
	public void set_SpeedUpEffect(ParticleSystem value) { }

	// RVA: 0x2203670 Offset: 0x2203771 VA: 0x2203670
	private void Update() { }

	// RVA: 0x2203EB0 Offset: 0x2203FB1 VA: 0x2203EB0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x2204BF0 Offset: 0x2204CF1 VA: 0x2204BF0
	private void StartSpeedUp() { }

	// RVA: 0x2203B70 Offset: 0x2203C71 VA: 0x2203B70
	private void UpdateSpeedUp() { }

	// RVA: 0x2204C50 Offset: 0x2204D51 VA: 0x2204C50
	private void ResetMove() { }

	// RVA: 0x2204C70 Offset: 0x2204D71 VA: 0x2204C70
	private void ResetInvincible() { }

	// RVA: 0x2204C80 Offset: 0x2204D81 VA: 0x2204C80
	public void .ctor() { }
}

