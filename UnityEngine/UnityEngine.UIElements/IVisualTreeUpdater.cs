internal interface IVisualTreeUpdater : IDisposable // TypeDefIndex: 4143
{
	// Properties
	public abstract ProfilerMarker profilerMarker { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ProfilerMarker get_profilerMarker() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Update() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }
}

