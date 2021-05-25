public class HandCuffsManager : SingletonMonoBehaviour<HandCuffsManager> // TypeDefIndex: 6717
{
	// Fields
	private Register<ActorID, HandCuffsController> m_Register; // 0x18
	private Dictionary<ActorID, SphereCollider> m_AimTargets; // 0x20

	// Methods

	// RVA: 0x22F3A30 Offset: 0x22F3B31 VA: 0x22F3A30
	private void Update() { }

	// RVA: 0x22F3C30 Offset: 0x22F3D31 VA: 0x22F3C30
	private void FixedUpdate() { }

	// RVA: 0x22F2490 Offset: 0x22F2591 VA: 0x22F2490
	public bool Regist(ActorID actorID, HandCuffsController controller) { }

	// RVA: 0x22F2750 Offset: 0x22F2851 VA: 0x22F2750
	public bool Remove(ActorID actorID) { }

	// RVA: 0x22F3D90 Offset: 0x22F3E91 VA: 0x22F3D90
	public void Initialize(ActorID actorID) { }

	// RVA: 0x22F3E50 Offset: 0x22F3F51 VA: 0x22F3E50
	public bool OnAim(ActorID actorID) { }

	// RVA: 0x22F3F70 Offset: 0x22F4071 VA: 0x22F3F70
	public bool OnThrow(ActorID actorID) { }

	// RVA: 0x22F4060 Offset: 0x22F4161 VA: 0x22F4060
	public void DoCancel(ActorID actorID, bool immediate = False) { }

	// RVA: 0x22F4130 Offset: 0x22F4231 VA: 0x22F4130
	public void DoCancelAll(bool immediate = False) { }

	// RVA: 0x22F4250 Offset: 0x22F4351 VA: 0x22F4250
	public void DoShot(ActorID actorID, bool charge) { }

	// RVA: 0x22F4320 Offset: 0x22F4421 VA: 0x22F4320
	public bool IsPlaying(ActorID actorID) { }

	// RVA: 0x22F43F0 Offset: 0x22F44F1 VA: 0x22F43F0
	public bool IsAiming(ActorID actorID) { }

	// RVA: 0x22F44C0 Offset: 0x22F45C1 VA: 0x22F44C0
	public Collider GetAimTarget(ActorID actorID) { }

	// RVA: 0x22F4590 Offset: 0x22F4691 VA: 0x22F4590
	public bool CanPlay(ActorID actorID) { }

	// RVA: 0x22F46A0 Offset: 0x22F47A1 VA: 0x22F46A0
	public bool CanThrow(ActorID actorID) { }

	// RVA: 0x22F4770 Offset: 0x22F4871 VA: 0x22F4770
	public float CoolTimeNow(ActorID actorID) { }

	// RVA: 0x22F4830 Offset: 0x22F4931 VA: 0x22F4830
	public float CoolTimeMax(ActorID actorID) { }

	// RVA: 0x22F48F0 Offset: 0x22F49F1 VA: 0x22F48F0
	public float CoolTimePer(ActorID actorID) { }

	// RVA: 0x22F49C0 Offset: 0x22F4AC1 VA: 0x22F49C0
	public void .ctor() { }
}

