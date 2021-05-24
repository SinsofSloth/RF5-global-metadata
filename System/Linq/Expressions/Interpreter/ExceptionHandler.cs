internal sealed class ExceptionHandler // TypeDefIndex: 2526
{
	// Fields
	private readonly Type _exceptionType; // 0x10
	public readonly int LabelIndex; // 0x18
	public readonly int HandlerStartIndex; // 0x1C
	public readonly int HandlerEndIndex; // 0x20
	public readonly ExceptionFilter Filter; // 0x28

	// Methods

	// RVA: 0x197F7F0 Offset: 0x197F8F1 VA: 0x197F7F0
	internal void .ctor(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter) { }

	// RVA: 0x197F860 Offset: 0x197F961 VA: 0x197F860
	public bool Matches(Type exceptionType) { }

	// RVA: 0x197F890 Offset: 0x197F991 VA: 0x197F890 Slot: 3
	public override string ToString() { }
}

