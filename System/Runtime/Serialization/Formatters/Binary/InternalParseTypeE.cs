[Serializable]
internal enum InternalParseTypeE // TypeDefIndex: 1068
{
	// Fields
	public int value__; // 0x0
	public const InternalParseTypeE Empty = 0;
	public const InternalParseTypeE SerializedStreamHeader = 1;
	public const InternalParseTypeE Object = 2;
	public const InternalParseTypeE Member = 3;
	public const InternalParseTypeE ObjectEnd = 4;
	public const InternalParseTypeE MemberEnd = 5;
	public const InternalParseTypeE Headers = 6;
	public const InternalParseTypeE HeadersEnd = 7;
	public const InternalParseTypeE SerializedStreamHeaderEnd = 8;
	public const InternalParseTypeE Envelope = 9;
	public const InternalParseTypeE EnvelopeEnd = 10;
	public const InternalParseTypeE Body = 11;
	public const InternalParseTypeE BodyEnd = 12;
}

