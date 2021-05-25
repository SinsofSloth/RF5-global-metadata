public class MonsterRideManager : SingletonMonoBehaviour<MonsterRideManager> // TypeDefIndex: 6722
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15F180 Offset: 0x15F281 VA: 0x15F180
	private bool <IsRiding>k__BackingField; // 0x18
	private MonsterControllerBase m_Monster; // 0x20
	private HumanRideSaddle m_Saddle; // 0x28
	private MonsterRideAnimationType m_RidAnimationType; // 0x30
	private RideController m_Rider1; // 0x38
	private RideController m_Rider2; // 0x40
	private RideChair m_Chair1; // 0x48
	private RideChair m_Chair2; // 0x50
	private GameObject m_chairObject; // 0x58
	private RideChair m_chair; // 0x60
	private string m_PrevTag; // 0x68
	public UnityEventMonster RideOnEvent; // 0x70
	public UnityEventMonster RideEndEvent; // 0x78

	// Properties
	public bool IsRiding { get; set; }
	public MonsterControllerBase Monster { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19CB90 Offset: 0x19CC91 VA: 0x19CB90
	// RVA: 0x1CD4D90 Offset: 0x1CD4E91 VA: 0x1CD4D90
	public bool get_IsRiding() { }

	[CompilerGeneratedAttribute] // RVA: 0x19CBA0 Offset: 0x19CCA1 VA: 0x19CBA0
	// RVA: 0x1CD4DA0 Offset: 0x1CD4EA1 VA: 0x1CD4DA0
	private void set_IsRiding(bool value) { }

	// RVA: 0x1CD4DB0 Offset: 0x1CD4EB1 VA: 0x1CD4DB0
	public MonsterControllerBase get_Monster() { }

	// RVA: 0x1CD4DC0 Offset: 0x1CD4EC1 VA: 0x1CD4DC0
	public void Init() { }

	// RVA: 0x1CD4E80 Offset: 0x1CD4F81 VA: 0x1CD4E80
	public bool InitUpdate() { }

	// RVA: 0x1CD4FD0 Offset: 0x1CD50D1 VA: 0x1CD4FD0
	private void OnDisable() { }

	// RVA: 0x1CD53B0 Offset: 0x1CD54B1 VA: 0x1CD53B0
	protected void Update() { }

	// RVA: 0x1CD55C0 Offset: 0x1CD56C1 VA: 0x1CD55C0
	protected void LateUpdate() { }

	// RVA: 0x1CD5800 Offset: 0x1CD5901 VA: 0x1CD5800
	public void EndRide() { }

	// RVA: 0x1CD5900 Offset: 0x1CD5A01 VA: 0x1CD5900
	public bool DoRide(MonsterControllerBase monster, HumanController[] riders) { }

	// RVA: 0x1CD6200 Offset: 0x1CD6301 VA: 0x1CD6200
	public void UpdateMonsterSaddle() { }

	// RVA: 0x1CD6440 Offset: 0x1CD6541 VA: 0x1CD6440
	public void ResetAction() { }

	// RVA: 0x1CD6100 Offset: 0x1CD6201 VA: 0x1CD6100
	public void ResetAction(MonsterControllerBase monster) { }

	// RVA: 0x1CD5E70 Offset: 0x1CD5F71 VA: 0x1CD5E70
	private bool CreateRider(HumanController human, ref RideController rider) { }

	// RVA: 0x1CD64E0 Offset: 0x1CD65E1 VA: 0x1CD64E0
	private void DeleteRider(ref RideController rider, bool isMoveOnNavmesh, bool onGround) { }

	// RVA: 0x1CD5F90 Offset: 0x1CD6091 VA: 0x1CD5F90
	private void CreateChair(ref RideChair chair, Transform attachPoint) { }

	// RVA: 0x1CD6700 Offset: 0x1CD6801 VA: 0x1CD6700
	private void DeleteChair(ref RideChair chair) { }

	// RVA: 0x1CD50A0 Offset: 0x1CD51A1 VA: 0x1CD50A0
	public void DoEnd(bool onGround = True) { }

	// RVA: 0x1CD67E0 Offset: 0x1CD68E1 VA: 0x1CD67E0
	public void OnDamage(DamageResult damageResult, Actor actor) { }

	// RVA: 0x1CD6A90 Offset: 0x1CD6B91 VA: 0x1CD6A90
	public void .ctor() { }
}

