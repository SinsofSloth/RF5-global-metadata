public abstract class GrappleThrowObserve : NormalizedTimeObserve // TypeDefIndex: 6548
{
	// Fields
	private ActorID m_ActorID; // 0x24
	private float m_ThrowAngle; // 0x28
	private float m_ThrowPower; // 0x2C
	private MagicParamID m_ParamID1; // 0x30
	private MagicParamID m_ParamID2; // 0x34

	// Methods

	// RVA: 0x1EB4AD0 Offset: 0x1EB4BD1 VA: 0x1EB4AD0 Slot: 19
	public override void DoEvent() { }

	// RVA: 0x1EB4C90 Offset: 0x1EB4D91 VA: 0x1EB4C90
	public void Setup(ActorID actorID, float angle, float power, MagicParamID id1, MagicParamID id2) { }

	// RVA: 0x1EB4470 Offset: 0x1EB4571 VA: 0x1EB4470
	protected void .ctor() { }
}

