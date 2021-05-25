public class GrapplingManager : SingletonMonoBehaviour<GrapplingManager> // TypeDefIndex: 6716
{
	// Fields
	private Register<ActorID, GrappleController> m_Register; // 0x18
	private Dictionary<ActorID, float> m_charaTimeCounters; // 0x20
	private const float TimeOverCount = 8;

	// Methods

	// RVA: 0x1EB4CB0 Offset: 0x1EB4DB1 VA: 0x1EB4CB0
	private void Update() { }

	// RVA: 0x1EB4FB0 Offset: 0x1EB50B1 VA: 0x1EB4FB0
	private void LateUpdate() { }

	// RVA: 0x1EB50E0 Offset: 0x1EB51E1 VA: 0x1EB50E0
	private void FixedUpdate() { }

	// RVA: 0x1EB5210 Offset: 0x1EB5311 VA: 0x1EB5210
	public bool RegistCharaGrapController(ActorID actorID, GrappleController charaGrappleController) { }

	// RVA: 0x1EB5280 Offset: 0x1EB5381 VA: 0x1EB5280
	public void RemoveCharaGrapController(ActorID actorID) { }

	// RVA: 0x1EB52F0 Offset: 0x1EB53F1 VA: 0x1EB52F0
	public bool IsGrappling(ActorID actorID) { }

	// RVA: 0x1EB45B0 Offset: 0x1EB46B1 VA: 0x1EB45B0
	public bool DoAttach(ActorID actorID) { }

	// RVA: 0x1EB5390 Offset: 0x1EB5491 VA: 0x1EB5390
	public bool DoGrap(ActorID actorID, GrapInterface target) { }

	// RVA: 0x1EB4EF0 Offset: 0x1EB4FF1 VA: 0x1EB4EF0
	public bool DoRelease(ActorID actorID) { }

	// RVA: 0x1EB4BA0 Offset: 0x1EB4CA1 VA: 0x1EB4BA0
	public bool DoThrow(ActorID actorID, float angle, float power, MagicParamID id1, MagicParamID id2) { }

	// RVA: 0x1EB5460 Offset: 0x1EB5561 VA: 0x1EB5460
	public bool DoPound(ActorID actorID) { }

	// RVA: 0x1EB5510 Offset: 0x1EB5611 VA: 0x1EB5510
	public bool DoFlung(ActorID actorID) { }

	// RVA: 0x1EB55E0 Offset: 0x1EB56E1 VA: 0x1EB55E0
	public bool DoSwing(ActorID actorID) { }

	// RVA: 0x1EB56B0 Offset: 0x1EB57B1 VA: 0x1EB56B0
	public bool DoSlam(ActorID actorID) { }

	// RVA: 0x1EB49E0 Offset: 0x1EB4AE1 VA: 0x1EB49E0
	public bool OnThrowEnd(ActorID actorID) { }

	// RVA: 0x1EB4930 Offset: 0x1EB4A31 VA: 0x1EB4930
	public bool TakeDamage(ActorID actorID, MagicParamID id) { }

	// RVA: 0x1EB5780 Offset: 0x1EB5881 VA: 0x1EB5780
	public void DoCancel(ActorID actorID) { }

	// RVA: 0x1EB5790 Offset: 0x1EB5891 VA: 0x1EB5790
	public void DoCancelAll() { }

	// RVA: 0x1EB4260 Offset: 0x1EB4361 VA: 0x1EB4260
	public bool ChangeDirection(ActorID actorID, float rate) { }

	// RVA: 0x1EB58A0 Offset: 0x1EB59A1 VA: 0x1EB58A0
	public void .ctor() { }
}

