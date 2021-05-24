internal abstract class TimerThread.Timer : IDisposable // TypeDefIndex: 1920
{
	// Fields
	private readonly int m_StartTimeMilliseconds; // 0x10
	private readonly int m_DurationMilliseconds; // 0x14

	// Methods

	// RVA: 0x16DF290 Offset: 0x16DF391 VA: 0x16DF290
	internal void .ctor(int durationMilliseconds) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract bool Cancel() { }

	// RVA: 0x16DF2D0 Offset: 0x16DF3D1 VA: 0x16DF2D0 Slot: 4
	public void Dispose() { }
}

