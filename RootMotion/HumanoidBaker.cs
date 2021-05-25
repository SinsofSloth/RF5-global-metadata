public class HumanoidBaker : Baker // TypeDefIndex: 6069
{
	// Fields
	[TooltipAttribute] // RVA: 0x144900 Offset: 0x144A01 VA: 0x144900
	public bool bakeHandIK; // 0x74
	[TooltipAttribute] // RVA: 0x144940 Offset: 0x144A41 VA: 0x144940
	[RangeAttribute] // RVA: 0x144940 Offset: 0x144A41 VA: 0x144940
	public float IKKeyReductionError; // 0x78
	[TooltipAttribute] // RVA: 0x1449A0 Offset: 0x144AA1 VA: 0x1449A0
	[RangeAttribute] // RVA: 0x1449A0 Offset: 0x144AA1 VA: 0x1449A0
	public int muscleFrameRateDiv; // 0x7C
	private BakerMuscle[] bakerMuscles; // 0x80
	private BakerHumanoidQT rootQT; // 0x88
	private BakerHumanoidQT leftFootQT; // 0x90
	private BakerHumanoidQT rightFootQT; // 0x98
	private BakerHumanoidQT leftHandQT; // 0xA0
	private BakerHumanoidQT rightHandQT; // 0xA8
	private float[] muscles; // 0xB0
	private HumanPose pose; // 0xB8
	private HumanPoseHandler handler; // 0xE0
	private Vector3 bodyPosition; // 0xE8
	private Quaternion bodyRotation; // 0xF4
	private int mN; // 0x104
	private Quaternion lastBodyRotation; // 0x108

	// Methods

	// RVA: 0x1A48BA0 Offset: 0x1A48CA1 VA: 0x1A48BA0
	private void Awake() { }

	// RVA: 0x1A49050 Offset: 0x1A49151 VA: 0x1A49050 Slot: 4
	protected override Transform GetCharacterRoot() { }

	// RVA: 0x1A49070 Offset: 0x1A49171 VA: 0x1A49070 Slot: 5
	protected override void OnStartBaking() { }

	// RVA: 0x1A491E0 Offset: 0x1A492E1 VA: 0x1A491E0 Slot: 6
	protected override void OnSetLoopFrame(float time) { }

	// RVA: 0x1A49430 Offset: 0x1A49531 VA: 0x1A49430 Slot: 7
	protected override void OnSetCurves(ref AnimationClip clip) { }

	// RVA: 0x1A495F0 Offset: 0x1A496F1 VA: 0x1A495F0 Slot: 8
	protected override void OnSetKeyframes(float time, bool lastFrame) { }

	// RVA: 0x1A49920 Offset: 0x1A49A21 VA: 0x1A49920
	private void UpdateHumanPose() { }

	// RVA: 0x1A49A10 Offset: 0x1A49B11 VA: 0x1A49A10
	public void .ctor() { }
}

