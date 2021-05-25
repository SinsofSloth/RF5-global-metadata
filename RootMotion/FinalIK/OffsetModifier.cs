public abstract class OffsetModifier : MonoBehaviour // TypeDefIndex: 9566
{
	// Fields
	[TooltipAttribute] // RVA: 0x17CCE0 Offset: 0x17CDE1 VA: 0x17CCE0
	public float weight; // 0x18
	[TooltipAttribute] // RVA: 0x17CD20 Offset: 0x17CE21 VA: 0x17CD20
	public FullBodyBipedIK ik; // 0x20
	protected float lastTime; // 0x28

	// Properties
	protected float deltaTime { get; }

	// Methods

	// RVA: 0x291AFB0 Offset: 0x291B0B1 VA: 0x291AFB0
	protected float get_deltaTime() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void OnModifyOffset() { }

	// RVA: 0x291AFE0 Offset: 0x291B0E1 VA: 0x291AFE0 Slot: 5
	protected virtual void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AC210 Offset: 0x1AC311 VA: 0x1AC210
	// RVA: 0x291B070 Offset: 0x291B171 VA: 0x291B070
	private IEnumerator Initiate() { }

	// RVA: 0x291B120 Offset: 0x291B221 VA: 0x291B120
	private void ModifyOffset() { }

	// RVA: 0x291B230 Offset: 0x291B331 VA: 0x291B230
	protected void ApplyLimits(OffsetModifier.OffsetLimits[] limits) { }

	// RVA: 0x291B570 Offset: 0x291B671 VA: 0x291B570 Slot: 6
	protected virtual void OnDestroy() { }

	// RVA: 0x291B690 Offset: 0x291B791 VA: 0x291B690
	protected void .ctor() { }
}

