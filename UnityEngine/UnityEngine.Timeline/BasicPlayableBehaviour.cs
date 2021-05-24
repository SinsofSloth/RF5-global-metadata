[ObsoleteAttribute] // RVA: 0x12AAD0 Offset: 0x12ABD1 VA: 0x12AAD0
[Serializable]
public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour // TypeDefIndex: 4603
{
	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: 0x17DA570 Offset: 0x17DA671 VA: 0x17DA570 Slot: 14
	public virtual double get_duration() { }

	// RVA: 0x17DA5E0 Offset: 0x17DA6E1 VA: 0x17DA5E0 Slot: 15
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	// RVA: 0x17DA650 Offset: 0x17DA751 VA: 0x17DA650 Slot: 16
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x17DA660 Offset: 0x17DA761 VA: 0x17DA660 Slot: 17
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x17DA670 Offset: 0x17DA771 VA: 0x17DA670 Slot: 18
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x17DA680 Offset: 0x17DA781 VA: 0x17DA680 Slot: 19
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x17DA690 Offset: 0x17DA791 VA: 0x17DA690 Slot: 20
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x17DA6A0 Offset: 0x17DA7A1 VA: 0x17DA6A0 Slot: 21
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x17DA6B0 Offset: 0x17DA7B1 VA: 0x17DA6B0 Slot: 22
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x17DA6C0 Offset: 0x17DA7C1 VA: 0x17DA6C0 Slot: 23
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x17DA6D0 Offset: 0x17DA7D1 VA: 0x17DA6D0 Slot: 24
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x17DA770 Offset: 0x17DA871 VA: 0x17DA770
	public void .ctor() { }
}

