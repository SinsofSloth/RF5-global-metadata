[FlagsAttribute] // RVA: 0x14A880 Offset: 0x14A981 VA: 0x14A880
public enum BadStatus // TypeDefIndex: 10832
{
	// Fields
	public int value__; // 0x0
	public const BadStatus None = 0;
	public const BadStatus Poison = 1;
	public const BadStatus Seal = 2;
	public const BadStatus Paralysis = 4;
	public const BadStatus Sleep = 8;
	public const BadStatus Tire = 16;
	public const BadStatus Sick = 32;
	public const BadStatus Stun = 64;
	public const BadStatus Death = 128;
	public const BadStatus All = 255;
}

