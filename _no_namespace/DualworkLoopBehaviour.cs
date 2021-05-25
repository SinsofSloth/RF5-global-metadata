[Serializable]
public class DualworkLoopBehaviour : PlayableBehaviour // TypeDefIndex: 8334
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16EE90 Offset: 0x16EF91 VA: 0x16EE90
	private PlayableDirector <director>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x16EEA0 Offset: 0x16EFA1 VA: 0x16EEA0
	private DualworkLoopTrack <Track>k__BackingField; // 0x18
	public TimelineClip Clip; // 0x20

	// Properties
	public PlayableDirector director { get; set; }
	public DualworkLoopTrack Track { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A6EB0 Offset: 0x1A6FB1 VA: 0x1A6EB0
	// RVA: 0x200F7D0 Offset: 0x200F8D1 VA: 0x200F7D0
	public PlayableDirector get_director() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6EC0 Offset: 0x1A6FC1 VA: 0x1A6EC0
	// RVA: 0x200F7E0 Offset: 0x200F8E1 VA: 0x200F7E0
	public void set_director(PlayableDirector value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6ED0 Offset: 0x1A6FD1 VA: 0x1A6ED0
	// RVA: 0x200F7F0 Offset: 0x200F8F1 VA: 0x200F7F0
	public DualworkLoopTrack get_Track() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6EE0 Offset: 0x1A6FE1 VA: 0x1A6EE0
	// RVA: 0x200F800 Offset: 0x200F901 VA: 0x200F800
	public void set_Track(DualworkLoopTrack value) { }

	// RVA: 0x200F810 Offset: 0x200F911 VA: 0x200F810 Slot: 17
	public override void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x200F820 Offset: 0x200F921 VA: 0x200F820
	public void .ctor() { }
}

