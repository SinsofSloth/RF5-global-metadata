[HelpURLAttribute] // RVA: 0x148AF0 Offset: 0x148BF1 VA: 0x148AF0
[AddComponentMenu] // RVA: 0x148AF0 Offset: 0x148BF1 VA: 0x148AF0
public class InteractionObject : MonoBehaviour // TypeDefIndex: 9509
{
	// Fields
	[TooltipAttribute] // RVA: 0x17B850 Offset: 0x17B951 VA: 0x17B850
	public Transform otherLookAtTarget; // 0x18
	[TooltipAttribute] // RVA: 0x17B890 Offset: 0x17B991 VA: 0x17B890
	public Transform otherTargetsRoot; // 0x20
	[TooltipAttribute] // RVA: 0x17B8D0 Offset: 0x17B9D1 VA: 0x17B8D0
	public Transform positionOffsetSpace; // 0x28
	public InteractionObject.WeightCurve[] weightCurves; // 0x30
	public InteractionObject.Multiplier[] multipliers; // 0x38
	public InteractionObject.InteractionEvent[] events; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x17B910 Offset: 0x17BA11 VA: 0x17B910
	private float <length>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x17B920 Offset: 0x17BA21 VA: 0x17B920
	private InteractionSystem <lastUsedInteractionSystem>k__BackingField; // 0x50
	private InteractionTarget[] targets; // 0x58

	// Properties
	public float length { get; set; }
	public InteractionSystem lastUsedInteractionSystem { get; set; }
	public Transform lookAtTarget { get; }
	public Transform targetsRoot { get; }

	// Methods

	[ContextMenu] // RVA: 0x1AB530 Offset: 0x1AB631 VA: 0x1AB530
	// RVA: 0x2BEFC30 Offset: 0x2BEFD31 VA: 0x2BEFC30
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x1AB570 Offset: 0x1AB671 VA: 0x1AB570
	// RVA: 0x2BEFC80 Offset: 0x2BEFD81 VA: 0x2BEFC80
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x1AB5B0 Offset: 0x1AB6B1 VA: 0x1AB5B0
	// RVA: 0x2BEFCD0 Offset: 0x2BEFDD1 VA: 0x2BEFCD0
	private void OpenTutorial1() { }

	[ContextMenu] // RVA: 0x1AB5F0 Offset: 0x1AB6F1 VA: 0x1AB5F0
	// RVA: 0x2BEFD20 Offset: 0x2BEFE21 VA: 0x2BEFD20
	private void OpenTutorial2() { }

	[ContextMenu] // RVA: 0x1AB630 Offset: 0x1AB731 VA: 0x1AB630
	// RVA: 0x2BEFD70 Offset: 0x2BEFE71 VA: 0x2BEFD70
	private void OpenTutorial3() { }

	[ContextMenu] // RVA: 0x1AB670 Offset: 0x1AB771 VA: 0x1AB670
	// RVA: 0x2BEFDC0 Offset: 0x2BEFEC1 VA: 0x2BEFDC0
	private void OpenTutorial4() { }

	[ContextMenu] // RVA: 0x1AB6B0 Offset: 0x1AB7B1 VA: 0x1AB6B0
	// RVA: 0x2BEFE10 Offset: 0x2BEFF11 VA: 0x2BEFE10
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x1AB6F0 Offset: 0x1AB7F1 VA: 0x1AB6F0
	// RVA: 0x2BEFE60 Offset: 0x2BEFF61 VA: 0x2BEFE60
	private void ASThread() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB730 Offset: 0x1AB831 VA: 0x1AB730
	// RVA: 0x2BEFEB0 Offset: 0x2BEFFB1 VA: 0x2BEFEB0
	public float get_length() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB740 Offset: 0x1AB841 VA: 0x1AB740
	// RVA: 0x2BEFEC0 Offset: 0x2BEFFC1 VA: 0x2BEFEC0
	private void set_length(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB750 Offset: 0x1AB851 VA: 0x1AB750
	// RVA: 0x2BEFED0 Offset: 0x2BEFFD1 VA: 0x2BEFED0
	public InteractionSystem get_lastUsedInteractionSystem() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB760 Offset: 0x1AB861 VA: 0x1AB760
	// RVA: 0x2BEFEE0 Offset: 0x2BEFFE1 VA: 0x2BEFEE0
	private void set_lastUsedInteractionSystem(InteractionSystem value) { }

	// RVA: 0x2BEFEF0 Offset: 0x2BEFFF1 VA: 0x2BEFEF0
	public void Initiate() { }

	// RVA: 0x2BF0180 Offset: 0x2BF0281 VA: 0x2BF0180
	public Transform get_lookAtTarget() { }

	// RVA: 0x2BF0210 Offset: 0x2BF0311 VA: 0x2BF0210
	public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem) { }

	// RVA: 0x2BEDA20 Offset: 0x2BEDB21 VA: 0x2BEDA20
	public bool CurveUsed(InteractionObject.WeightCurve.Type type) { }

	// RVA: 0x2BF0390 Offset: 0x2BF0491 VA: 0x2BF0390
	public InteractionTarget[] GetTargets() { }

	// RVA: 0x2BED8A0 Offset: 0x2BED9A1 VA: 0x2BED8A0
	public Transform GetTarget(FullBodyBipedEffector effectorType, string tag) { }

	// RVA: 0x2BEDA10 Offset: 0x2BEDB11 VA: 0x2BEDA10
	public void OnStartInteraction(InteractionSystem interactionSystem) { }

	// RVA: 0x2BEE280 Offset: 0x2BEE381 VA: 0x2BEE280
	public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight) { }

	// RVA: 0x2BEECB0 Offset: 0x2BEEDB1 VA: 0x2BEECB0
	public float GetValue(InteractionObject.WeightCurve.Type weightCurveType, InteractionTarget target, float timer) { }

	// RVA: 0x2BEF1E0 Offset: 0x2BEF2E1 VA: 0x2BEF1E0
	public Transform get_targetsRoot() { }

	// RVA: 0x2BF0B40 Offset: 0x2BF0C41 VA: 0x2BF0B40
	private void Start() { }

	// RVA: 0x2BF0420 Offset: 0x2BF0521 VA: 0x2BF0420
	private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionObject.WeightCurve.Type type, float value, float weight) { }

	// RVA: 0x2BF03A0 Offset: 0x2BF04A1 VA: 0x2BF03A0
	private Transform GetTarget(FullBodyBipedEffector effectorType) { }

	// RVA: 0x2BF0AC0 Offset: 0x2BF0BC1 VA: 0x2BF0AC0
	private int GetWeightCurveIndex(InteractionObject.WeightCurve.Type weightCurveType) { }

	// RVA: 0x2BF0B50 Offset: 0x2BF0C51 VA: 0x2BF0B50
	private int GetMultiplierIndex(InteractionObject.WeightCurve.Type weightCurveType) { }

	// RVA: 0x2BF0BD0 Offset: 0x2BF0CD1 VA: 0x2BF0BD0
	public void .ctor() { }
}

