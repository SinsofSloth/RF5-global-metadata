public class AnimationWarping : OffsetModifier // TypeDefIndex: 9341
{
	// Fields
	[TooltipAttribute] // RVA: 0x177F80 Offset: 0x178081 VA: 0x177F80
	public Animator animator; // 0x30
	[TooltipAttribute] // RVA: 0x177FC0 Offset: 0x1780C1 VA: 0x177FC0
	public AnimationWarping.EffectorMode effectorMode; // 0x38
	[SpaceAttribute] // RVA: 0x178000 Offset: 0x178101 VA: 0x178000
	[TooltipAttribute] // RVA: 0x178000 Offset: 0x178101 VA: 0x178000
	public AnimationWarping.Warp[] warps; // 0x40
	private AnimationWarping.EffectorMode lastMode; // 0x48

	// Methods

	// RVA: 0x26BEB50 Offset: 0x26BEC51 VA: 0x26BEB50 Slot: 5
	protected override void Start() { }

	// RVA: 0x26BEB80 Offset: 0x26BEC81 VA: 0x26BEB80
	public float GetWarpWeight(int warpIndex) { }

	// RVA: 0x26BED90 Offset: 0x26BEE91 VA: 0x26BED90 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x26BF160 Offset: 0x26BF261 VA: 0x26BF160
	private void OnDisable() { }

	// RVA: 0x26BF200 Offset: 0x26BF301 VA: 0x26BF200
	public void .ctor() { }
}

