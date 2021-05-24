public interface IProfilerService // TypeDefIndex: 5623
{
	// Properties
	public abstract float AverageFrameTime { get; }
	public abstract float LastFrameTime { get; }
	public abstract CircularBuffer<ProfilerFrame> FrameBuffer { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract float get_AverageFrameTime() { }

	// RVA: -1 Offset: -1 Slot: 1
	public abstract float get_LastFrameTime() { }

	// RVA: -1 Offset: -1 Slot: 2
	public abstract CircularBuffer<ProfilerFrame> get_FrameBuffer() { }
}

