public sealed class VideoSchedulerPlayableBehaviour : PlayableBehaviour // TypeDefIndex: 11809
{
	// Fields
	private IEnumerable<TimelineClip> m_Clips; // 0x10
	private PlayableDirector m_Director; // 0x18

	// Properties
	internal PlayableDirector director { get; set; }
	internal IEnumerable<TimelineClip> clips { get; set; }

	// Methods

	// RVA: 0x1CFBF60 Offset: 0x1CFC061 VA: 0x1CFBF60
	internal PlayableDirector get_director() { }

	// RVA: 0x1CFBF70 Offset: 0x1CFC071 VA: 0x1CFBF70
	internal void set_director(PlayableDirector value) { }

	// RVA: 0x1CFBF80 Offset: 0x1CFC081 VA: 0x1CFBF80
	internal IEnumerable<TimelineClip> get_clips() { }

	// RVA: 0x1CFBF90 Offset: 0x1CFC091 VA: 0x1CFBF90
	internal void set_clips(IEnumerable<TimelineClip> value) { }

	// RVA: 0x1CFBFA0 Offset: 0x1CFC0A1 VA: 0x1CFBFA0 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x1CFC4C0 Offset: 0x1CFC5C1 VA: 0x1CFC4C0
	public void .ctor() { }
}

