public interface IPlayableBehaviour // TypeDefIndex: 3342
{
	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0xD9BF0 Offset: 0xD9CF1 VA: 0xD9BF0
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnGraphStart(Playable playable) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9C00 Offset: 0xD9D01 VA: 0xD9C00
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnGraphStop(Playable playable) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9C10 Offset: 0xD9D11 VA: 0xD9C10
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPlayableCreate(Playable playable) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9C20 Offset: 0xD9D21 VA: 0xD9C20
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPlayableDestroy(Playable playable) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9C30 Offset: 0xD9D31 VA: 0xD9C30
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnBehaviourPlay(Playable playable, FrameData info) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9C40 Offset: 0xD9D41 VA: 0xD9C40
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnBehaviourPause(Playable playable, FrameData info) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9C50 Offset: 0xD9D51 VA: 0xD9C50
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PrepareFrame(Playable playable, FrameData info) { }

	[RequiredByNativeCodeAttribute] // RVA: 0xD9C60 Offset: 0xD9D61 VA: 0xD9C60
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ProcessFrame(Playable playable, FrameData info, object playerData) { }
}

