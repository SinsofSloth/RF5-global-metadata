public class HandCuffsController : MonoBehaviour // TypeDefIndex: 6770
{
	// Fields
	private const float ChargeStartSoundPlayTime = 0.3;
	[SerializeField] // RVA: 0x15F5D0 Offset: 0x15F6D1 VA: 0x15F5D0
	private HumanController HumanController; // 0x18
	[SerializeField] // RVA: 0x15F5E0 Offset: 0x15F6E1 VA: 0x15F5E0
	private float Normal_Scale; // 0x20
	[SerializeField] // RVA: 0x15F5F0 Offset: 0x15F6F1 VA: 0x15F5F0
	private float Charge_Scale; // 0x24
	[SerializeField] // RVA: 0x15F600 Offset: 0x15F701 VA: 0x15F600
	private float Charge_MinScale; // 0x28
	[SerializeField] // RVA: 0x15F610 Offset: 0x15F711 VA: 0x15F610
	private float Charge_MaxScale; // 0x2C
	private const MagicID Normal_MagicID = 246;
	private const MagicID Charge_MagicID = 247;
	private const SoundID Normal_ThrowSoundID = 231;
	private const SoundID Charge_ThrowSoundID = 213;
	[SerializeField] // RVA: 0x15F620 Offset: 0x15F721 VA: 0x15F620
	private HandCuffsEffect[] Effects; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15F630 Offset: 0x15F731 VA: 0x15F630
	private SphereCollider <AimTarget>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x15F640 Offset: 0x15F741 VA: 0x15F640
	private float <CoolTimeNow>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x15F650 Offset: 0x15F751 VA: 0x15F650
	private float <CoolTimeMax>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x15F660 Offset: 0x15F761 VA: 0x15F660
	private float <ChargeTime>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x15F670 Offset: 0x15F771 VA: 0x15F670
	private bool <IsCharge>k__BackingField; // 0x4C
	private HandCuffsController.State updateState; // 0x50
	private SEController chargeSound; // 0x58
	private static HandCuffsController.UpdateVJ[] updateVJ; // 0x0

	// Properties
	public SphereCollider AimTarget { get; set; }
	public float CoolTimeNow { get; set; }
	public float CoolTimeMax { get; set; }
	public float CoolTimePer { get; }
	public virtual bool CanPlay { get; }
	public virtual bool CanThrow { get; }
	public float ChargeTime { get; set; }
	public bool IsCharge { get; set; }
	public bool IsPlaying { get; }
	public bool IsAiming { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19CE00 Offset: 0x19CF01 VA: 0x19CE00
	// RVA: 0x22F04D0 Offset: 0x22F05D1 VA: 0x22F04D0
	public SphereCollider get_AimTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CE10 Offset: 0x19CF11 VA: 0x19CE10
	// RVA: 0x22F04E0 Offset: 0x22F05E1 VA: 0x22F04E0
	public void set_AimTarget(SphereCollider value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CE20 Offset: 0x19CF21 VA: 0x19CE20
	// RVA: 0x22F04F0 Offset: 0x22F05F1 VA: 0x22F04F0
	public float get_CoolTimeNow() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CE30 Offset: 0x19CF31 VA: 0x19CE30
	// RVA: 0x22F0500 Offset: 0x22F0601 VA: 0x22F0500
	private void set_CoolTimeNow(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CE40 Offset: 0x19CF41 VA: 0x19CE40
	// RVA: 0x22F0510 Offset: 0x22F0611 VA: 0x22F0510
	public float get_CoolTimeMax() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CE50 Offset: 0x19CF51 VA: 0x19CE50
	// RVA: 0x22F0520 Offset: 0x22F0621 VA: 0x22F0520
	private void set_CoolTimeMax(float value) { }

	// RVA: 0x22F0530 Offset: 0x22F0631 VA: 0x22F0530
	public float get_CoolTimePer() { }

	// RVA: 0x22F0540 Offset: 0x22F0641 VA: 0x22F0540 Slot: 4
	public virtual bool get_CanPlay() { }

	// RVA: 0x22F0630 Offset: 0x22F0731 VA: 0x22F0630 Slot: 5
	public virtual bool get_CanThrow() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CE60 Offset: 0x19CF61 VA: 0x19CE60
	// RVA: 0x22F0660 Offset: 0x22F0761 VA: 0x22F0660
	public float get_ChargeTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CE70 Offset: 0x19CF71 VA: 0x19CE70
	// RVA: 0x22F0670 Offset: 0x22F0771 VA: 0x22F0670
	private void set_ChargeTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19CE80 Offset: 0x19CF81 VA: 0x19CE80
	// RVA: 0x22F0680 Offset: 0x22F0781 VA: 0x22F0680
	public bool get_IsCharge() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CE90 Offset: 0x19CF91 VA: 0x19CE90
	// RVA: 0x22F0690 Offset: 0x22F0791 VA: 0x22F0690
	private void set_IsCharge(bool value) { }

	// RVA: 0x22F06A0 Offset: 0x22F07A1 VA: 0x22F06A0
	public bool get_IsPlaying() { }

	// RVA: 0x22F06C0 Offset: 0x22F07C1 VA: 0x22F06C0
	public bool get_IsAiming() { }

	// RVA: 0x22F06D0 Offset: 0x22F07D1 VA: 0x22F06D0
	public void Initialize() { }

	// RVA: 0x22F0960 Offset: 0x22F0A61 VA: 0x22F0960
	public void OnStart() { }

	// RVA: 0x22F0BD0 Offset: 0x22F0CD1 VA: 0x22F0BD0
	public void OnThrow() { }

	// RVA: 0x22F0C20 Offset: 0x22F0D21 VA: 0x22F0C20
	public void Throw(bool charge) { }

	// RVA: 0x22F1150 Offset: 0x22F1251 VA: 0x22F1150
	public void OnCancel(bool immediate = False) { }

	// RVA: 0x22F1470 Offset: 0x22F1571 VA: 0x22F1470
	public void OnShot(bool charge) { }

	// RVA: 0x22F1810 Offset: 0x22F1911 VA: 0x22F1810
	public void OnUpdate() { }

	// RVA: 0x22F1CB0 Offset: 0x22F1DB1 VA: 0x22F1CB0
	public void OnUpdateEffect() { }

	// RVA: 0x22F1ED0 Offset: 0x22F1FD1 VA: 0x22F1ED0
	public void OnFixedUpdate() { }

	// RVA: 0x22F22F0 Offset: 0x22F23F1 VA: 0x22F22F0
	private void Awake() { }

	// RVA: 0x22F23B0 Offset: 0x22F24B1 VA: 0x22F23B0
	private void OnDestroy() { }

	// RVA: 0x22F23C0 Offset: 0x22F24C1 VA: 0x22F23C0
	private void OnEnable() { }

	// RVA: 0x22F2680 Offset: 0x22F2781 VA: 0x22F2680
	private void OnDisable() { }

	// RVA: 0x22F10A0 Offset: 0x22F11A1 VA: 0x22F10A0
	private void StopChargeSound() { }

	// RVA: 0x22F2860 Offset: 0x22F2961 VA: 0x22F2860
	private void PlayChargeSound(SoundID soundID) { }

	// RVA: 0x22F29A0 Offset: 0x22F2AA1 VA: 0x22F29A0
	private void SimulateTarget(out Vector3 from, out Vector3 to) { }

	// RVA: 0x22F2AD0 Offset: 0x22F2BD1 VA: 0x22F2AD0
	private static void UpdateNone(HandCuffsController controller) { }

	// RVA: 0x22F2C30 Offset: 0x22F2D31 VA: 0x22F2C30
	private static void UpdateIdle(HandCuffsController controller) { }

	// RVA: 0x22F2C40 Offset: 0x22F2D41 VA: 0x22F2C40
	private static void UpdateCharge(HandCuffsController controller) { }

	// RVA: 0x22F2FC0 Offset: 0x22F30C1 VA: 0x22F2FC0
	private static void UpdateAim(HandCuffsController controller) { }

	// RVA: 0x22F2FD0 Offset: 0x22F30D1 VA: 0x22F2FD0
	public void .ctor() { }

	// RVA: 0x22F3050 Offset: 0x22F3151 VA: 0x22F3050
	private static void .cctor() { }
}

