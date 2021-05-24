private enum Guid.ParseFailureKind // TypeDefIndex: 254
{
	// Fields
	public int value__; // 0x0
	public const Guid.ParseFailureKind None = 0;
	public const Guid.ParseFailureKind ArgumentNull = 1;
	public const Guid.ParseFailureKind Format = 2;
	public const Guid.ParseFailureKind FormatWithParameter = 3;
	public const Guid.ParseFailureKind NativeException = 4;
	public const Guid.ParseFailureKind FormatWithInnerException = 5;
}

