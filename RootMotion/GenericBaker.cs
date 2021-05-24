public class GenericBaker : Baker // TypeDefIndex: 6062
{
	// Fields
	[TooltipAttribute] // RVA: 0x1447C0 Offset: 0x1448C1 VA: 0x1447C0
	public bool markAsLegacy; // 0x74
	[TooltipAttribute] // RVA: 0x144800 Offset: 0x144901 VA: 0x144800
	public Transform root; // 0x78
	[TooltipAttribute] // RVA: 0x144840 Offset: 0x144941 VA: 0x144840
	public Transform rootNode; // 0x80
	[TooltipAttribute] // RVA: 0x144880 Offset: 0x144981 VA: 0x144880
	public Transform[] ignoreList; // 0x88
	[TooltipAttribute] // RVA: 0x1448C0 Offset: 0x1449C1 VA: 0x1448C0
	public Transform[] bakePositionList; // 0x90
	private BakerTransform[] children; // 0x98
	private BakerTransform rootChild; // 0xA0
	private int rootChildIndex; // 0xA8

	// Methods

	// RVA: 0x1A48450 Offset: 0x1A48551 VA: 0x1A48450
	private void Awake() { }

	// RVA: 0x1A488B0 Offset: 0x1A489B1 VA: 0x1A488B0 Slot: 4
	protected override Transform GetCharacterRoot() { }

	// RVA: 0x1A488C0 Offset: 0x1A489C1 VA: 0x1A488C0 Slot: 5
	protected override void OnStartBaking() { }

	// RVA: 0x1A489B0 Offset: 0x1A48AB1 VA: 0x1A489B0 Slot: 6
	protected override void OnSetLoopFrame(float time) { }

	// RVA: 0x1A48A30 Offset: 0x1A48B31 VA: 0x1A48A30 Slot: 7
	protected override void OnSetCurves(ref AnimationClip clip) { }

	// RVA: 0x1A48AB0 Offset: 0x1A48BB1 VA: 0x1A48AB0 Slot: 8
	protected override void OnSetKeyframes(float time, bool lastFrame) { }

	// RVA: 0x1A486F0 Offset: 0x1A487F1 VA: 0x1A486F0
	private bool IsIgnored(Transform t) { }

	// RVA: 0x1A487D0 Offset: 0x1A488D1 VA: 0x1A487D0
	private bool BakePosition(Transform t) { }

	// RVA: 0x1A48B30 Offset: 0x1A48C31 VA: 0x1A48B30
	public void .ctor() { }
}

