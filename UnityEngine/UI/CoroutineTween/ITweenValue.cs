internal interface ITweenValue // TypeDefIndex: 4037
{
	// Properties
	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TweenValue(float floatPercentage) { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_ignoreTimeScale() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_duration() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ValidTarget() { }
}

