public class KamereonController : BossMonsterContoroller // TypeDefIndex: 7898
{
	// Fields
	private KamereonShaderControl ShaderController; // 0x510
	[SerializeField] // RVA: 0x169D80 Offset: 0x169E81 VA: 0x169D80
	public float StealthFadeTime; // 0x518
	[SerializeField] // RVA: 0x169D90 Offset: 0x169E91 VA: 0x169D90
	public float StealthLoopWaitTimeOffset; // 0x51C
	[CompilerGeneratedAttribute] // RVA: 0x169DA0 Offset: 0x169EA1 VA: 0x169DA0
	private float <StealthTimeNormal>k__BackingField; // 0x520
	[CompilerGeneratedAttribute] // RVA: 0x169DB0 Offset: 0x169EB1 VA: 0x169DB0
	private float <StealthTimeMadness>k__BackingField; // 0x524
	[CompilerGeneratedAttribute] // RVA: 0x169DC0 Offset: 0x169EC1 VA: 0x169DC0
	private float <StealthSlowScale>k__BackingField; // 0x528
	private float T; // 0x52C
	private Action StealthState; // 0x530
	private bool IsCrazyRush; // 0x538
	private int CrazyRushCounter; // 0x53C

	// Properties
	private bool IsStealth { get; }
	public float StealthTimeNormal { get; set; }
	public float StealthTimeMadness { get; set; }
	public float StealthSlowScale { get; set; }

	// Methods

	// RVA: 0x2095500 Offset: 0x2095601 VA: 0x2095500 Slot: 9
	public override bool IsCanNotLockon(CharacterBase lockonCharacter) { }

	// RVA: 0x2095620 Offset: 0x2095721 VA: 0x2095620 Slot: 107
	public override bool IsCanRestraint() { }

	// RVA: 0x2095660 Offset: 0x2095761 VA: 0x2095660 Slot: 155
	protected override bool CanReciveItem() { }

	// RVA: 0x2095540 Offset: 0x2095641 VA: 0x2095540
	private bool get_IsStealth() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3F90 Offset: 0x1A4091 VA: 0x1A3F90
	// RVA: 0x20956A0 Offset: 0x20957A1 VA: 0x20956A0
	public float get_StealthTimeNormal() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3FA0 Offset: 0x1A40A1 VA: 0x1A3FA0
	// RVA: 0x20956B0 Offset: 0x20957B1 VA: 0x20956B0
	public void set_StealthTimeNormal(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3FB0 Offset: 0x1A40B1 VA: 0x1A3FB0
	// RVA: 0x20956C0 Offset: 0x20957C1 VA: 0x20956C0
	public float get_StealthTimeMadness() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3FC0 Offset: 0x1A40C1 VA: 0x1A3FC0
	// RVA: 0x20956D0 Offset: 0x20957D1 VA: 0x20956D0
	public void set_StealthTimeMadness(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3FD0 Offset: 0x1A40D1 VA: 0x1A3FD0
	// RVA: 0x20956E0 Offset: 0x20957E1 VA: 0x20956E0
	public float get_StealthSlowScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A3FE0 Offset: 0x1A40E1 VA: 0x1A3FE0
	// RVA: 0x20956F0 Offset: 0x20957F1 VA: 0x20956F0
	public void set_StealthSlowScale(float value) { }

	// RVA: 0x2095700 Offset: 0x2095801 VA: 0x2095700 Slot: 130
	protected override void OnSetup() { }

	// RVA: 0x20957E0 Offset: 0x20958E1 VA: 0x20957E0
	private void CreateProjectileEvent(MonsterProjectileActionScriptsController projectileActionScriptsController, int attackIndex) { }

	// RVA: 0x2095920 Offset: 0x2095A21 VA: 0x2095920 Slot: 138
	public override void OnRestraint() { }

	// RVA: 0x2095950 Offset: 0x2095A51 VA: 0x2095950 Slot: 132
	protected override void OnDeadEvent() { }

	// RVA: 0x2095980 Offset: 0x2095A81 VA: 0x2095980 Slot: 40
	protected override void Update() { }

	// RVA: 0x2095A50 Offset: 0x2095B51 VA: 0x2095A50 Slot: 53
	protected override float GetSlowMoveScale() { }

	// RVA: 0x20950A0 Offset: 0x20951A1 VA: 0x20950A0
	public void PlayStealth() { }

	// RVA: 0x2094880 Offset: 0x2094981 VA: 0x2094880
	public void PlayDefault() { }

	// RVA: 0x2095DA0 Offset: 0x2095EA1 VA: 0x2095DA0
	private void UpdateStartStealthWaitState() { }

	// RVA: 0x2095E90 Offset: 0x2095F91 VA: 0x2095E90
	private void UpdateStealthLoopState() { }

	// RVA: 0x2095A30 Offset: 0x2095B31 VA: 0x2095A30
	private void MainUpdateStealth() { }

	// RVA: 0x2095F00 Offset: 0x2096001 VA: 0x2095F00
	public void SetupCrazyRush(int min, int max) { }

	// RVA: 0x2095F60 Offset: 0x2096061 VA: 0x2095F60
	public void NextCrazyRush(string nextAction) { }

	// RVA: 0x2095FC0 Offset: 0x20960C1 VA: 0x2095FC0 Slot: 136
	public override void OnUniqueActionCommandInternal(MonsterActionCommandBase monsterActionCommandBase, ActionCommandDataTable actionCommandData) { }

	// RVA: 0x20965E0 Offset: 0x20966E1 VA: 0x20965E0
	public void .ctor() { }
}

