public class TerrainNeighbours : MonoBehaviour // TypeDefIndex: 9091
{
	// Fields
	public List<Terrain> terrainsToOmit; // 0x18
	[TooltipAttribute] // RVA: 0x176F00 Offset: 0x177001 VA: 0x176F00
	public WorldMover worldMover; // 0x20
	public List<Terrain> _terrains; // 0x28
	private Dictionary<int[], Terrain> _terrainDict; // 0x30
	[TooltipAttribute] // RVA: 0x176F40 Offset: 0x177041 VA: 0x176F40
	private Vector2 firstPosition; // 0x38
	private int sizeX; // 0x40
	private int sizeZ; // 0x44
	private bool firstPositonSet; // 0x48

	// Methods

	// RVA: 0x20A7720 Offset: 0x20A7821 VA: 0x20A7720
	private void Start() { }

	// RVA: 0x20A7730 Offset: 0x20A7831 VA: 0x20A7730
	public void CreateNeighbours() { }

	// RVA: 0x20A8CB0 Offset: 0x20A8DB1 VA: 0x20A8CB0
	public void .ctor() { }
}

