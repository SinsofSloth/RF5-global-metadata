[FlagsAttribute] // RVA: 0xC5610 Offset: 0xC5711 VA: 0xC5610
public enum ComputeBufferType // TypeDefIndex: 2903
{
	// Fields
	public int value__; // 0x0
	public const ComputeBufferType Default = 0;
	public const ComputeBufferType Raw = 1;
	public const ComputeBufferType Append = 2;
	public const ComputeBufferType Counter = 4;
	public const ComputeBufferType Constant = 8;
	public const ComputeBufferType Structured = 16;
	[ObsoleteAttribute] // RVA: 0xC9D50 Offset: 0xC9E51 VA: 0xC9D50
	public const ComputeBufferType DrawIndirect = 256;
	public const ComputeBufferType IndirectArguments = 256;
	[ObsoleteAttribute] // RVA: 0xC9D90 Offset: 0xC9E91 VA: 0xC9D90
	public const ComputeBufferType GPUMemory = 512;
}

