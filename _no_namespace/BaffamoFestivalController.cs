public class BaffamoFestivalController : MonoBehaviour // TypeDefIndex: 7332
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x165C30 Offset: 0x165D31 VA: 0x165C30
	private bool <IsPlayerHit>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x165C40 Offset: 0x165D41 VA: 0x165C40
	private bool <IsAttack>k__BackingField; // 0x19
	[CompilerGeneratedAttribute] // RVA: 0x165C50 Offset: 0x165D51 VA: 0x165C50
	private bool <IsJudge>k__BackingField; // 0x1A
	[CompilerGeneratedAttribute] // RVA: 0x165C60 Offset: 0x165D61 VA: 0x165C60
	private float <MoveSpeed>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x165C70 Offset: 0x165D71 VA: 0x165C70
	private Animator <Animator>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x165C80 Offset: 0x165D81 VA: 0x165C80
	private Rigidbody <Rigidbody>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x165C90 Offset: 0x165D91 VA: 0x165C90
	private float <StartActionTime>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x165CA0 Offset: 0x165DA1 VA: 0x165CA0
	private ParticleSystem <RushEffect>k__BackingField; // 0x38
	private const string FESTIVAL_COLLIDER_NAME = "InnerWallCube";
	private const string PLAYER_TAG = "Player";
	private const float RUSH_FOOTSTEP_INTERVAL = 0.5;
	private float countTime; // 0x40

	// Properties
	public bool IsPlayerHit { get; set; }
	public bool IsAttack { get; set; }
	public bool IsJudge { get; set; }
	public float MoveSpeed { get; set; }
	public Animator Animator { get; set; }
	public Rigidbody Rigidbody { get; set; }
	public float StartActionTime { get; set; }
	public ParticleSystem RushEffect { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19FEE0 Offset: 0x19FFE1 VA: 0x19FEE0
	// RVA: 0x215B550 Offset: 0x215B651 VA: 0x215B550
	public bool get_IsPlayerHit() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FEF0 Offset: 0x19FFF1 VA: 0x19FEF0
	// RVA: 0x215B560 Offset: 0x215B661 VA: 0x215B560
	private void set_IsPlayerHit(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19FF00 Offset: 0x1A0001 VA: 0x19FF00
	// RVA: 0x215B570 Offset: 0x215B671 VA: 0x215B570
	public bool get_IsAttack() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FF10 Offset: 0x1A0011 VA: 0x19FF10
	// RVA: 0x215B580 Offset: 0x215B681 VA: 0x215B580
	private void set_IsAttack(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19FF20 Offset: 0x1A0021 VA: 0x19FF20
	// RVA: 0x215B590 Offset: 0x215B691 VA: 0x215B590
	public bool get_IsJudge() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FF30 Offset: 0x1A0031 VA: 0x19FF30
	// RVA: 0x215B5A0 Offset: 0x215B6A1 VA: 0x215B5A0
	public void set_IsJudge(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19FF40 Offset: 0x1A0041 VA: 0x19FF40
	// RVA: 0x215B5B0 Offset: 0x215B6B1 VA: 0x215B5B0
	public float get_MoveSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FF50 Offset: 0x1A0051 VA: 0x19FF50
	// RVA: 0x215B5C0 Offset: 0x215B6C1 VA: 0x215B5C0
	public void set_MoveSpeed(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19FF60 Offset: 0x1A0061 VA: 0x19FF60
	// RVA: 0x215B5D0 Offset: 0x215B6D1 VA: 0x215B5D0
	public Animator get_Animator() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FF70 Offset: 0x1A0071 VA: 0x19FF70
	// RVA: 0x215B5E0 Offset: 0x215B6E1 VA: 0x215B5E0
	public void set_Animator(Animator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19FF80 Offset: 0x1A0081 VA: 0x19FF80
	// RVA: 0x215B5F0 Offset: 0x215B6F1 VA: 0x215B5F0
	public Rigidbody get_Rigidbody() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FF90 Offset: 0x1A0091 VA: 0x19FF90
	// RVA: 0x215B600 Offset: 0x215B701 VA: 0x215B600
	public void set_Rigidbody(Rigidbody value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19FFA0 Offset: 0x1A00A1 VA: 0x19FFA0
	// RVA: 0x215B610 Offset: 0x215B711 VA: 0x215B610
	public float get_StartActionTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FFB0 Offset: 0x1A00B1 VA: 0x19FFB0
	// RVA: 0x215B620 Offset: 0x215B721 VA: 0x215B620
	public void set_StartActionTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19FFC0 Offset: 0x1A00C1 VA: 0x19FFC0
	// RVA: 0x215B630 Offset: 0x215B731 VA: 0x215B630
	public ParticleSystem get_RushEffect() { }

	[CompilerGeneratedAttribute] // RVA: 0x19FFD0 Offset: 0x1A00D1 VA: 0x19FFD0
	// RVA: 0x215B640 Offset: 0x215B741 VA: 0x215B640
	public void set_RushEffect(ParticleSystem value) { }

	// RVA: 0x215B650 Offset: 0x215B751 VA: 0x215B650
	private void Update() { }

	// RVA: 0x2159630 Offset: 0x2159731 VA: 0x2159630
	public void Init() { }

	// RVA: 0x215BA30 Offset: 0x215BB31 VA: 0x215BA30
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x215BB50 Offset: 0x215BC51 VA: 0x215BB50
	private void HitFestivalZone() { }

	[IteratorStateMachineAttribute] // RVA: 0x19FFE0 Offset: 0x1A00E1 VA: 0x19FFE0
	// RVA: 0x215BC40 Offset: 0x215BD41 VA: 0x215BC40
	private IEnumerator Attack() { }

	// RVA: 0x215B7E0 Offset: 0x215B8E1 VA: 0x215B7E0
	private void Rush() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0050 Offset: 0x1A0151 VA: 0x1A0050
	// RVA: 0x215B9B0 Offset: 0x215BAB1 VA: 0x215B9B0
	private IEnumerator StartAction() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A00C0 Offset: 0x1A01C1 VA: 0x1A00C0
	// RVA: 0x215BD20 Offset: 0x215BE21 VA: 0x215BD20
	private IEnumerator OnRushEffect() { }

	// RVA: 0x215BDD0 Offset: 0x215BED1 VA: 0x215BDD0
	public void .ctor() { }
}

