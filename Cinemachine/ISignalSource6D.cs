public interface ISignalSource6D // TypeDefIndex: 4858
{
	// Properties
	public abstract float SignalDuration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_SignalDuration() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }
}

