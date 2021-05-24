private enum MonoChunkStream.State // TypeDefIndex: 1984
{
	// Fields
	public int value__; // 0x0
	public const MonoChunkStream.State None = 0;
	public const MonoChunkStream.State PartialSize = 1;
	public const MonoChunkStream.State Body = 2;
	public const MonoChunkStream.State BodyFinished = 3;
	public const MonoChunkStream.State Trailer = 4;
}

