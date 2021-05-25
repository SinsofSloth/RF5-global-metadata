public class OrkController : MonsterControllerBase // TypeDefIndex: 7949
{
	// Fields
	private MonsterControllerBase m_RideMonster; // 0x500
	private Transform m_Saddle; // 0x508
	private Transform m_Hips; // 0x510
	private List<SkinnedMeshRenderer> m_SkinningList; // 0x518
	private ValueTuple<float, float> CashColliderParam; // 0x520
	private EnemyBehaviorController m_BehaviorController; // 0x528
	private EnemyBehaviorController m_RideBehaviorController; // 0x530
	private OrkController.CashNavMeshAgent cashNavMeshAgent; // 0x538
	private bool IsSetupRide; // 0x56C

	// Properties
	private bool IsRidingWolf { get; }

	// Methods

	// RVA: 0x21B5650 Offset: 0x21B5751 VA: 0x21B5650
	private bool get_IsRidingWolf() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A48C0 Offset: 0x1A49C1 VA: 0x1A48C0
	// RVA: 0x21B56C0 Offset: 0x21B57C1 VA: 0x21B56C0 Slot: 131
	protected override IEnumerator OnSetupAsync() { }

	// RVA: 0x21B5770 Offset: 0x21B5871 VA: 0x21B5770
	private bool IsRiderOrk() { }

	// RVA: 0x21B57B0 Offset: 0x21B58B1 VA: 0x21B57B0 Slot: 108
	public override void OnSetupBehavior(MonsterEventReceiverInterface receiver) { }

	// RVA: 0x21B5BD0 Offset: 0x21B5CD1 VA: 0x21B5BD0 Slot: 67
	public override void OnPlayDamageAction(DamageActionType type, DamageResult damageResult) { }

	// RVA: 0x21B6130 Offset: 0x21B6231 VA: 0x21B6130 Slot: 7
	public override bool TakeDamage(DamageInfo damageInfo, out DamageResult damageResult) { }

	// RVA: 0x21B6320 Offset: 0x21B6421 VA: 0x21B6320 Slot: 65
	public override void OnBadStatus(BadStatus badStatus, bool isEnable) { }

	// RVA: 0x21B63F0 Offset: 0x21B64F1 VA: 0x21B63F0 Slot: 138
	public override void OnRestraint() { }

	// RVA: 0x21B6480 Offset: 0x21B6581 VA: 0x21B6480 Slot: 145
	public override bool CanGrap(HumanController humanController) { }

	// RVA: 0x21B6540 Offset: 0x21B6641 VA: 0x21B6540 Slot: 147
	public override bool DoGrap(HumanController humanController) { }

	// RVA: 0x21B6740 Offset: 0x21B6841 VA: 0x21B6740 Slot: 149
	protected override void TakeThrowDamage() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A4930 Offset: 0x1A4A31 VA: 0x1A4930
	// RVA: 0x21B67D0 Offset: 0x21B68D1 VA: 0x21B67D0
	private static IEnumerator CreateRideMonster(OrkController orkController) { }

	// RVA: 0x21B5A80 Offset: 0x21B5B81 VA: 0x21B5A80
	private void SetupRideMonster() { }

	// RVA: 0x21B6880 Offset: 0x21B6981 VA: 0x21B6880
	private void RideStart() { }

	// RVA: 0x21B6C70 Offset: 0x21B6D71 VA: 0x21B6C70
	private void OnEndThrow(bool isDamage) { }

	// RVA: 0x21B5CC0 Offset: 0x21B5DC1 VA: 0x21B5CC0
	private void RideEnd() { }

	// RVA: 0x21B69D0 Offset: 0x21B6AD1 VA: 0x21B69D0
	private void SetSkinningListEnable(bool isEnable, bool isEnableWeapon) { }

	// RVA: 0x21B6AB0 Offset: 0x21B6BB1 VA: 0x21B6AB0
	private void SetRidePoint() { }

	// RVA: 0x21B6C90 Offset: 0x21B6D91 VA: 0x21B6C90 Slot: 20
	protected override void OnDestroy() { }

	// RVA: 0x21B6DD0 Offset: 0x21B6ED1 VA: 0x21B6DD0 Slot: 42
	protected override void FixedUpdate() { }

	// RVA: 0x21B6E60 Offset: 0x21B6F61 VA: 0x21B6E60
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A49A0 Offset: 0x1A4AA1 VA: 0x1A49A0
	[DebuggerHiddenAttribute] // RVA: 0x1A49A0 Offset: 0x1A4AA1 VA: 0x1A49A0
	// RVA: 0x21B6F00 Offset: 0x21B7001 VA: 0x21B6F00
	private IEnumerator <>n__0() { }
}

