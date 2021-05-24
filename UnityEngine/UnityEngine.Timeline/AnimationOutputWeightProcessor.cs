internal class AnimationOutputWeightProcessor : ITimelineEvaluateCallback // TypeDefIndex: 4530
{
	// Fields
	private AnimationPlayableOutput m_Output; // 0x10
	private AnimationMotionXToDeltaPlayable m_MotionXPlayable; // 0x20
	private readonly List<AnimationOutputWeightProcessor.WeightInfo> m_Mixers; // 0x30

	// Methods

	// RVA: 0x17D2DD0 Offset: 0x17D2ED1 VA: 0x17D2DD0
	public void .ctor(AnimationPlayableOutput output) { }

	// RVA: 0x17D2E90 Offset: 0x17D2F91 VA: 0x17D2E90
	private void FindMixers() { }

	// RVA: 0x17D2F60 Offset: 0x17D3061 VA: 0x17D2F60
	private void FindMixers(Playable parent, int port, Playable node) { }

	// RVA: 0x17D31B0 Offset: 0x17D32B1 VA: 0x17D31B0 Slot: 4
	public void Evaluate() { }
}

