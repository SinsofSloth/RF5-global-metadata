[NativeHeaderAttribute] // RVA: 0xF1400 Offset: 0xF1501 VA: 0xF1400
[RequiredByNativeCodeAttribute] // RVA: 0xF1400 Offset: 0xF1501 VA: 0xF1400
[NativeHeaderAttribute] // RVA: 0xF1400 Offset: 0xF1501 VA: 0xF1400
[NativeHeaderAttribute] // RVA: 0xF1400 Offset: 0xF1501 VA: 0xF1400
[StaticAccessorAttribute] // RVA: 0xF1400 Offset: 0xF1501 VA: 0xF1400
public struct AudioPlayableOutput : IPlayableOutput // TypeDefIndex: 3577
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Properties
	public static AudioPlayableOutput Null { get; }

	// Methods

	// RVA: 0x1BB1F60 Offset: 0x1BB2061 VA: 0x1BB1F60
	public static AudioPlayableOutput Create(PlayableGraph graph, string name, AudioSource target) { }

	// RVA: 0x23640 Offset: 0x23741 VA: 0x23640
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x1BB2120 Offset: 0x1BB2221 VA: 0x1BB2120
	public static AudioPlayableOutput get_Null() { }

	// RVA: 0x23650 Offset: 0x23751 VA: 0x23650 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x1BB2080 Offset: 0x1BB2181 VA: 0x1BB2080
	public static PlayableOutput op_Implicit(AudioPlayableOutput output) { }

	// RVA: 0x1BB22D0 Offset: 0x1BB23D1 VA: 0x1BB22D0
	public static AudioPlayableOutput op_Explicit(PlayableOutput output) { }

	// RVA: 0x23660 Offset: 0x23761 VA: 0x23660
	public void SetTarget(AudioSource value) { }

	// RVA: 0x236B0 Offset: 0x237B1 VA: 0x236B0
	public void SetEvaluateOnSeek(bool value) { }

	[NativeThrowsAttribute] // RVA: 0xF1D90 Offset: 0xF1E91 VA: 0xF1D90
	// RVA: 0x1BB2320 Offset: 0x1BB2421 VA: 0x1BB2320
	private static void InternalSetTarget(ref PlayableOutputHandle output, AudioSource target) { }

	[NativeThrowsAttribute] // RVA: 0xF1DA0 Offset: 0xF1EA1 VA: 0xF1DA0
	// RVA: 0x1BB23C0 Offset: 0x1BB24C1 VA: 0x1BB23C0
	private static void InternalSetEvaluateOnSeek(ref PlayableOutputHandle output, bool value) { }
}

