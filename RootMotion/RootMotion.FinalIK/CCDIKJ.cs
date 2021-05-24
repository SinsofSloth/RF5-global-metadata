[RequireComponent] // RVA: 0x148A60 Offset: 0x148B61 VA: 0x148A60
[AddComponentMenu] // RVA: 0x148A60 Offset: 0x148B61 VA: 0x148A60
public class CCDIKJ : MonoBehaviour // TypeDefIndex: 9452
{
	// Fields
	[TooltipAttribute] // RVA: 0x17A500 Offset: 0x17A601 VA: 0x17A500
	public Transform target; // 0x18
	[TooltipAttribute] // RVA: 0x17A540 Offset: 0x17A641 VA: 0x17A540
	[RangeAttribute] // RVA: 0x17A540 Offset: 0x17A641 VA: 0x17A540
	public float weight; // 0x20
	[TooltipAttribute] // RVA: 0x17A5A0 Offset: 0x17A6A1 VA: 0x17A5A0
	public float tolerance; // 0x24
	[TooltipAttribute] // RVA: 0x17A5E0 Offset: 0x17A6E1 VA: 0x17A5E0
	public int maxIterations; // 0x28
	[TooltipAttribute] // RVA: 0x17A620 Offset: 0x17A721 VA: 0x17A620
	public bool useRotationLimits; // 0x2C
	[TooltipAttribute] // RVA: 0x17A660 Offset: 0x17A761 VA: 0x17A660
	public bool XY; // 0x2D
	[TooltipAttribute] // RVA: 0x17A6A0 Offset: 0x17A7A1 VA: 0x17A6A0
	public Transform[] bones; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x17A6E0 Offset: 0x17A7E1 VA: 0x17A6E0
	private bool <initiated>k__BackingField; // 0x38
	private Animator animator; // 0x40
	private PlayableGraph graph; // 0x48
	private AnimationScriptPlayable IKPlayable; // 0x58
	private CCDIKJob job; // 0x68

	// Properties
	public bool initiated { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AB410 Offset: 0x1AB511 VA: 0x1AB410
	// RVA: 0x27367F0 Offset: 0x27368F1 VA: 0x27367F0
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AB420 Offset: 0x1AB521 VA: 0x1AB420
	// RVA: 0x2736800 Offset: 0x2736901 VA: 0x2736800
	private void set_initiated(bool value) { }

	// RVA: 0x2736810 Offset: 0x2736911 VA: 0x2736810
	private void OnEnable() { }

	// RVA: 0x2736FD0 Offset: 0x27370D1 VA: 0x2736FD0
	private void Update() { }

	// RVA: 0x2737160 Offset: 0x2737261 VA: 0x2737160
	private void OnDisable() { }

	// RVA: 0x2737280 Offset: 0x2737381 VA: 0x2737280
	public void .ctor() { }
}

