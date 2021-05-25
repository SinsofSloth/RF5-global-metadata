[RequiredByNativeCodeAttribute] // RVA: 0xC8C40 Offset: 0xC8D41 VA: 0xC8C40
[Serializable]
public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable // TypeDefIndex: 3348
{
	// Methods

	// RVA: 0x2B6D730 Offset: 0x2B6D831 VA: 0x2B6D730
	public void .ctor() { }

	// RVA: 0x2B6D740 Offset: 0x2B6D841 VA: 0x2B6D740 Slot: 13
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x2B6D750 Offset: 0x2B6D851 VA: 0x2B6D750 Slot: 14
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x2B6D760 Offset: 0x2B6D861 VA: 0x2B6D760 Slot: 15
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x2B6D770 Offset: 0x2B6D871 VA: 0x2B6D770 Slot: 16
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x2B6D780 Offset: 0x2B6D881 VA: 0x2B6D780 Slot: 17
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x2B6D790 Offset: 0x2B6D891 VA: 0x2B6D790 Slot: 18
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x2B6D7A0 Offset: 0x2B6D8A1 VA: 0x2B6D7A0 Slot: 19
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x2B6D7B0 Offset: 0x2B6D8B1 VA: 0x2B6D7B0 Slot: 20
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x2B6D7C0 Offset: 0x2B6D8C1 VA: 0x2B6D7C0 Slot: 21
	public virtual object Clone() { }
}

