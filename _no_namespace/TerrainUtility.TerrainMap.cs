public class TerrainUtility.TerrainMap // TypeDefIndex: 3668
{
	// Fields
	private Vector3 m_patchSize; // 0x10
	public TerrainUtility.TerrainMap.ErrorCode m_errorCode; // 0x1C
	public Dictionary<TerrainUtility.TerrainMap.TileCoord, Terrain> m_terrainTiles; // 0x20

	// Methods

	// RVA: 0x1B47CF0 Offset: 0x1B47DF1 VA: 0x1B47CF0
	public Terrain GetTerrain(int tileX, int tileZ) { }

	// RVA: 0x1B47460 Offset: 0x1B47561 VA: 0x1B47460
	public static TerrainUtility.TerrainMap CreateFromPlacement(Terrain originTerrain, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	// RVA: 0x1B47F50 Offset: 0x1B48051 VA: 0x1B47F50
	public static TerrainUtility.TerrainMap CreateFromPlacement(Vector2 gridOrigin, Vector2 gridSize, TerrainUtility.TerrainMap.TerrainFilter filter, bool fullValidation = True) { }

	// RVA: 0x1B48390 Offset: 0x1B48491 VA: 0x1B48390
	public void .ctor() { }

	// RVA: 0x1B48A80 Offset: 0x1B48B81 VA: 0x1B48A80
	private void AddTerrainInternal(int x, int z, Terrain terrain) { }

	// RVA: 0x1B487F0 Offset: 0x1B488F1 VA: 0x1B487F0
	private bool TryToAddTerrain(int tileX, int tileZ, Terrain terrain) { }

	// RVA: 0x1B48C30 Offset: 0x1B48D31 VA: 0x1B48C30
	private void ValidateTerrain(int tileX, int tileZ) { }

	// RVA: 0x1B48970 Offset: 0x1B48A71 VA: 0x1B48970
	private TerrainUtility.TerrainMap.ErrorCode Validate() { }
}

