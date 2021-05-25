public interface IPlayableAsset // TypeDefIndex: 3346
{
	// Properties
	public abstract double duration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract double get_duration() { }
}

