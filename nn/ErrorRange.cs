public struct ErrorRange // TypeDefIndex: 11452
{
	// Fields
	private int _module; // 0x0
	private int _descriptionBegin; // 0x4
	private int _descriptionEnd; // 0x8

	// Properties
	public int Module { get; }
	public int DescriptionBegin { get; }
	public int DescriptionEnd { get; }

	// Methods

	// RVA: 0x361390 Offset: 0x361491 VA: 0x361390
	internal void .ctor(int Module, int DescriptionBegin, int DescriptionEnd) { }

	// RVA: 0x3613A0 Offset: 0x3614A1 VA: 0x3613A0
	public int get_Module() { }

	// RVA: 0x3613B0 Offset: 0x3614B1 VA: 0x3613B0
	public int get_DescriptionBegin() { }

	// RVA: 0x3613C0 Offset: 0x3614C1 VA: 0x3613C0
	public int get_DescriptionEnd() { }

	// RVA: 0x3613D0 Offset: 0x3614D1 VA: 0x3613D0
	public bool Includes(Result result) { }
}

