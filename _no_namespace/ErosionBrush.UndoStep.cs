public struct ErosionBrush.UndoStep // TypeDefIndex: 9709
{
	// Fields
	private float[,] heights; // 0x0
	private int heightsOffsetX; // 0x8
	private int heightsOffsetZ; // 0xC
	private float[,,] splats; // 0x10
	private int splatsOffsetX; // 0x18
	private int splatsOffsetZ; // 0x1C

	// Methods

	// RVA: 0x37B200 Offset: 0x37B301 VA: 0x37B200
	public void .ctor(float[,] heights, float[,,] splats, int heightsOffsetX, int heightsOffsetZ, int splatsOffsetX, int splatsOffsetZ) { }

	// RVA: 0x37B210 Offset: 0x37B311 VA: 0x37B210
	public void Perform(TerrainData data) { }
}

