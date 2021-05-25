[FlagsAttribute] // RVA: 0x141540 Offset: 0x141641 VA: 0x141540
public enum RefreshMask // TypeDefIndex: 5965
{
	// Fields
	public int value__; // 0x0
	public const RefreshMask UV = 1;
	public const RefreshMask Colors = 2;
	public const RefreshMask Normals = 4;
	public const RefreshMask Tangents = 8;
	public const RefreshMask Collisions = 16;
	public const RefreshMask All = 31;
}

