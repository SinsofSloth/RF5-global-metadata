[ExecuteInEditMode] // RVA: 0x149580 Offset: 0x149681 VA: 0x149580
public class ErosionBrush : MonoBehaviour // TypeDefIndex: 9707
{
	// Fields
	public Terrain[] terrains; // 0x18
	private Terrain _terrain; // 0x20
	public Preset preset; // 0x28
	public Preset[] presets; // 0x30
	public int guiSelectedPreset; // 0x38
	public bool paint; // 0x3C
	public bool wasPaint; // 0x3D
	public bool moveDown; // 0x3E
	public Transform moveTfm; // 0x40
	public bool gen; // 0x48
	public bool undo; // 0x49
	public Texture2D guiHydraulicIcon; // 0x50
	public Texture2D guiWindIcon; // 0x58
	public Texture2D guiPluginIcon; // 0x60
	public int guiApplyIterations; // 0x68
	public int[] guiChannels; // 0x70
	public string[] guiChannelNames; // 0x78
	public Color guiBrushColor; // 0x80
	public float guiBrushThickness; // 0x90
	public int guiBrushNumCorners; // 0x94
	public bool recordUndo; // 0x98
	public bool unity5positioning; // 0x99
	public bool focusOnBrush; // 0x9A
	public bool guiShowPreset; // 0x9B
	public bool guiShowBrush; // 0x9C
	public bool guiShowErosion; // 0x9D
	public bool guiShowNoise; // 0x9E
	public bool guiShowTextures; // 0x9F
	public bool guiShowGlobal; // 0xA0
	public bool guiShowSettings; // 0xA1
	public bool guiShowAbout; // 0xA2
	public int guiMaxBrushSize; // 0xA4
	public bool guiSelectPresetsUsingNumkeys; // 0xA8
	public bool guiControlUsed; // 0xA9
	public int applyCount; // 0xAC
	public Stack<ErosionBrush.TerrainUndoStep[]> undoSteps; // 0xB0
	public Stack<ErosionBrush.TerrainUndoStep[]> redoSteps; // 0xB8
	public int currentUndoState; // 0xC0
	public int referenceUndoState; // 0xC4
	public List<List<ErosionBrush.UndoStep>> undoList; // 0xC8
	public bool allowUndo; // 0xD0

	// Properties
	public Terrain terrain { get; set; }

	// Methods

	// RVA: 0x2AEC220 Offset: 0x2AEC321 VA: 0x2AEC220
	public Terrain get_terrain() { }

	// RVA: 0x2AEC2D0 Offset: 0x2AEC3D1 VA: 0x2AEC2D0
	public void set_terrain(Terrain value) { }

	// RVA: 0x2AEC2E0 Offset: 0x2AEC3E1 VA: 0x2AEC2E0
	public Terrain[] GetTerrains() { }

	// RVA: 0x2AEC420 Offset: 0x2AEC521 VA: 0x2AEC420
	public void ApplyNoise(Matrix height, Matrix bedrock, Matrix sediment) { }

	// RVA: 0x2AEC6B0 Offset: 0x2AEC7B1 VA: 0x2AEC6B0
	public void ApplyErosion(Matrix height, Matrix bedrock, Matrix sediment) { }

	// RVA: 0x2AEC8A0 Offset: 0x2AEC9A1 VA: 0x2AEC8A0
	public void ApplyBrush(Vector3 pos, float radius, bool useFallof = True) { }

	// RVA: 0x2AED3E0 Offset: 0x2AED4E1 VA: 0x2AED3E0
	public void GetHeight(Matrix matrix, Terrain terrain) { }

	// RVA: 0x2AED6A0 Offset: 0x2AED7A1 VA: 0x2AED6A0
	public void AddHeight(Matrix matrix, Terrain terrain) { }

	// RVA: 0x2AED8C0 Offset: 0x2AED9C1 VA: 0x2AED8C0
	public void AddSplat(Matrix matrix, Terrain terrain, int channel) { }

	// RVA: 0x2AEDF50 Offset: 0x2AEE051 VA: 0x2AEDF50
	public void TestUndo(Vector3 pos, float radius) { }

	// RVA: 0x2AEF100 Offset: 0x2AEF201 VA: 0x2AEF100
	public void NewUndo() { }

	// RVA: 0x2AEF180 Offset: 0x2AEF281 VA: 0x2AEF180
	public void AddUndo(Vector3 pos, float radius) { }

	// RVA: 0x2AEF3F0 Offset: 0x2AEF4F1 VA: 0x2AEF3F0
	public void AddGlobalUndo() { }

	// RVA: 0x2AEF8A0 Offset: 0x2AEF9A1 VA: 0x2AEF8A0
	public void PerformUndo() { }

	// RVA: 0x2AEFED0 Offset: 0x2AEFFD1 VA: 0x2AEFED0
	public void .ctor() { }
}

[ExecuteInEditMode] // RVA: 0x149580 Offset: 0x149681 VA: 0x149580
public class ErosionBrush : MonoBehaviour // TypeDefIndex: 9707
{
	// Fields
	public Terrain[] terrains; // 0x18
	private Terrain _terrain; // 0x20
	public Preset preset; // 0x28
	public Preset[] presets; // 0x30
	public int guiSelectedPreset; // 0x38
	public bool paint; // 0x3C
	public bool wasPaint; // 0x3D
	public bool moveDown; // 0x3E
	public Transform moveTfm; // 0x40
	public bool gen; // 0x48
	public bool undo; // 0x49
	public Texture2D guiHydraulicIcon; // 0x50
	public Texture2D guiWindIcon; // 0x58
	public Texture2D guiPluginIcon; // 0x60
	public int guiApplyIterations; // 0x68
	public int[] guiChannels; // 0x70
	public string[] guiChannelNames; // 0x78
	public Color guiBrushColor; // 0x80
	public float guiBrushThickness; // 0x90
	public int guiBrushNumCorners; // 0x94
	public bool recordUndo; // 0x98
	public bool unity5positioning; // 0x99
	public bool focusOnBrush; // 0x9A
	public bool guiShowPreset; // 0x9B
	public bool guiShowBrush; // 0x9C
	public bool guiShowErosion; // 0x9D
	public bool guiShowNoise; // 0x9E
	public bool guiShowTextures; // 0x9F
	public bool guiShowGlobal; // 0xA0
	public bool guiShowSettings; // 0xA1
	public bool guiShowAbout; // 0xA2
	public int guiMaxBrushSize; // 0xA4
	public bool guiSelectPresetsUsingNumkeys; // 0xA8
	public bool guiControlUsed; // 0xA9
	public int applyCount; // 0xAC
	public Stack<ErosionBrush.TerrainUndoStep[]> undoSteps; // 0xB0
	public Stack<ErosionBrush.TerrainUndoStep[]> redoSteps; // 0xB8
	public int currentUndoState; // 0xC0
	public int referenceUndoState; // 0xC4
	public List<List<ErosionBrush.UndoStep>> undoList; // 0xC8
	public bool allowUndo; // 0xD0

	// Properties
	public Terrain terrain { get; set; }

	// Methods

	// RVA: 0x2AEC220 Offset: 0x2AEC321 VA: 0x2AEC220
	public Terrain get_terrain() { }

	// RVA: 0x2AEC2D0 Offset: 0x2AEC3D1 VA: 0x2AEC2D0
	public void set_terrain(Terrain value) { }

	// RVA: 0x2AEC2E0 Offset: 0x2AEC3E1 VA: 0x2AEC2E0
	public Terrain[] GetTerrains() { }

	// RVA: 0x2AEC420 Offset: 0x2AEC521 VA: 0x2AEC420
	public void ApplyNoise(Matrix height, Matrix bedrock, Matrix sediment) { }

	// RVA: 0x2AEC6B0 Offset: 0x2AEC7B1 VA: 0x2AEC6B0
	public void ApplyErosion(Matrix height, Matrix bedrock, Matrix sediment) { }

	// RVA: 0x2AEC8A0 Offset: 0x2AEC9A1 VA: 0x2AEC8A0
	public void ApplyBrush(Vector3 pos, float radius, bool useFallof = True) { }

	// RVA: 0x2AED3E0 Offset: 0x2AED4E1 VA: 0x2AED3E0
	public void GetHeight(Matrix matrix, Terrain terrain) { }

	// RVA: 0x2AED6A0 Offset: 0x2AED7A1 VA: 0x2AED6A0
	public void AddHeight(Matrix matrix, Terrain terrain) { }

	// RVA: 0x2AED8C0 Offset: 0x2AED9C1 VA: 0x2AED8C0
	public void AddSplat(Matrix matrix, Terrain terrain, int channel) { }

	// RVA: 0x2AEDF50 Offset: 0x2AEE051 VA: 0x2AEDF50
	public void TestUndo(Vector3 pos, float radius) { }

	// RVA: 0x2AEF100 Offset: 0x2AEF201 VA: 0x2AEF100
	public void NewUndo() { }

	// RVA: 0x2AEF180 Offset: 0x2AEF281 VA: 0x2AEF180
	public void AddUndo(Vector3 pos, float radius) { }

	// RVA: 0x2AEF3F0 Offset: 0x2AEF4F1 VA: 0x2AEF3F0
	public void AddGlobalUndo() { }

	// RVA: 0x2AEF8A0 Offset: 0x2AEF9A1 VA: 0x2AEF8A0
	public void PerformUndo() { }

	// RVA: 0x2AEFED0 Offset: 0x2AEFFD1 VA: 0x2AEFED0
	public void .ctor() { }
}

[ExecuteInEditMode] // RVA: 0x149580 Offset: 0x149681 VA: 0x149580
public class ErosionBrush : MonoBehaviour // TypeDefIndex: 9707
{
	// Fields
	public Terrain[] terrains; // 0x18
	private Terrain _terrain; // 0x20
	public Preset preset; // 0x28
	public Preset[] presets; // 0x30
	public int guiSelectedPreset; // 0x38
	public bool paint; // 0x3C
	public bool wasPaint; // 0x3D
	public bool moveDown; // 0x3E
	public Transform moveTfm; // 0x40
	public bool gen; // 0x48
	public bool undo; // 0x49
	public Texture2D guiHydraulicIcon; // 0x50
	public Texture2D guiWindIcon; // 0x58
	public Texture2D guiPluginIcon; // 0x60
	public int guiApplyIterations; // 0x68
	public int[] guiChannels; // 0x70
	public string[] guiChannelNames; // 0x78
	public Color guiBrushColor; // 0x80
	public float guiBrushThickness; // 0x90
	public int guiBrushNumCorners; // 0x94
	public bool recordUndo; // 0x98
	public bool unity5positioning; // 0x99
	public bool focusOnBrush; // 0x9A
	public bool guiShowPreset; // 0x9B
	public bool guiShowBrush; // 0x9C
	public bool guiShowErosion; // 0x9D
	public bool guiShowNoise; // 0x9E
	public bool guiShowTextures; // 0x9F
	public bool guiShowGlobal; // 0xA0
	public bool guiShowSettings; // 0xA1
	public bool guiShowAbout; // 0xA2
	public int guiMaxBrushSize; // 0xA4
	public bool guiSelectPresetsUsingNumkeys; // 0xA8
	public bool guiControlUsed; // 0xA9
	public int applyCount; // 0xAC
	public Stack<ErosionBrush.TerrainUndoStep[]> undoSteps; // 0xB0
	public Stack<ErosionBrush.TerrainUndoStep[]> redoSteps; // 0xB8
	public int currentUndoState; // 0xC0
	public int referenceUndoState; // 0xC4
	public List<List<ErosionBrush.UndoStep>> undoList; // 0xC8
	public bool allowUndo; // 0xD0

	// Properties
	public Terrain terrain { get; set; }

	// Methods

	// RVA: 0x2AEC220 Offset: 0x2AEC321 VA: 0x2AEC220
	public Terrain get_terrain() { }

	// RVA: 0x2AEC2D0 Offset: 0x2AEC3D1 VA: 0x2AEC2D0
	public void set_terrain(Terrain value) { }

	// RVA: 0x2AEC2E0 Offset: 0x2AEC3E1 VA: 0x2AEC2E0
	public Terrain[] GetTerrains() { }

	// RVA: 0x2AEC420 Offset: 0x2AEC521 VA: 0x2AEC420
	public void ApplyNoise(Matrix height, Matrix bedrock, Matrix sediment) { }

	// RVA: 0x2AEC6B0 Offset: 0x2AEC7B1 VA: 0x2AEC6B0
	public void ApplyErosion(Matrix height, Matrix bedrock, Matrix sediment) { }

	// RVA: 0x2AEC8A0 Offset: 0x2AEC9A1 VA: 0x2AEC8A0
	public void ApplyBrush(Vector3 pos, float radius, bool useFallof = True) { }

	// RVA: 0x2AED3E0 Offset: 0x2AED4E1 VA: 0x2AED3E0
	public void GetHeight(Matrix matrix, Terrain terrain) { }

	// RVA: 0x2AED6A0 Offset: 0x2AED7A1 VA: 0x2AED6A0
	public void AddHeight(Matrix matrix, Terrain terrain) { }

	// RVA: 0x2AED8C0 Offset: 0x2AED9C1 VA: 0x2AED8C0
	public void AddSplat(Matrix matrix, Terrain terrain, int channel) { }

	// RVA: 0x2AEDF50 Offset: 0x2AEE051 VA: 0x2AEDF50
	public void TestUndo(Vector3 pos, float radius) { }

	// RVA: 0x2AEF100 Offset: 0x2AEF201 VA: 0x2AEF100
	public void NewUndo() { }

	// RVA: 0x2AEF180 Offset: 0x2AEF281 VA: 0x2AEF180
	public void AddUndo(Vector3 pos, float radius) { }

	// RVA: 0x2AEF3F0 Offset: 0x2AEF4F1 VA: 0x2AEF3F0
	public void AddGlobalUndo() { }

	// RVA: 0x2AEF8A0 Offset: 0x2AEF9A1 VA: 0x2AEF8A0
	public void PerformUndo() { }

	// RVA: 0x2AEFED0 Offset: 0x2AEFFD1 VA: 0x2AEFED0
	public void .ctor() { }
}

[ExecuteInEditMode] // RVA: 0x149580 Offset: 0x149681 VA: 0x149580
public class ErosionBrush : MonoBehaviour // TypeDefIndex: 9707
{
	// Fields
	public Terrain[] terrains; // 0x18
	private Terrain _terrain; // 0x20
	public Preset preset; // 0x28
	public Preset[] presets; // 0x30
	public int guiSelectedPreset; // 0x38
	public bool paint; // 0x3C
	public bool wasPaint; // 0x3D
	public bool moveDown; // 0x3E
	public Transform moveTfm; // 0x40
	public bool gen; // 0x48
	public bool undo; // 0x49
	public Texture2D guiHydraulicIcon; // 0x50
	public Texture2D guiWindIcon; // 0x58
	public Texture2D guiPluginIcon; // 0x60
	public int guiApplyIterations; // 0x68
	public int[] guiChannels; // 0x70
	public string[] guiChannelNames; // 0x78
	public Color guiBrushColor; // 0x80
	public float guiBrushThickness; // 0x90
	public int guiBrushNumCorners; // 0x94
	public bool recordUndo; // 0x98
	public bool unity5positioning; // 0x99
	public bool focusOnBrush; // 0x9A
	public bool guiShowPreset; // 0x9B
	public bool guiShowBrush; // 0x9C
	public bool guiShowErosion; // 0x9D
	public bool guiShowNoise; // 0x9E
	public bool guiShowTextures; // 0x9F
	public bool guiShowGlobal; // 0xA0
	public bool guiShowSettings; // 0xA1
	public bool guiShowAbout; // 0xA2
	public int guiMaxBrushSize; // 0xA4
	public bool guiSelectPresetsUsingNumkeys; // 0xA8
	public bool guiControlUsed; // 0xA9
	public int applyCount; // 0xAC
	public Stack<ErosionBrush.TerrainUndoStep[]> undoSteps; // 0xB0
	public Stack<ErosionBrush.TerrainUndoStep[]> redoSteps; // 0xB8
	public int currentUndoState; // 0xC0
	public int referenceUndoState; // 0xC4
	public List<List<ErosionBrush.UndoStep>> undoList; // 0xC8
	public bool allowUndo; // 0xD0

	// Properties
	public Terrain terrain { get; set; }

	// Methods

	// RVA: 0x2AEC220 Offset: 0x2AEC321 VA: 0x2AEC220
	public Terrain get_terrain() { }

	// RVA: 0x2AEC2D0 Offset: 0x2AEC3D1 VA: 0x2AEC2D0
	public void set_terrain(Terrain value) { }

	// RVA: 0x2AEC2E0 Offset: 0x2AEC3E1 VA: 0x2AEC2E0
	public Terrain[] GetTerrains() { }

	// RVA: 0x2AEC420 Offset: 0x2AEC521 VA: 0x2AEC420
	public void ApplyNoise(Matrix height, Matrix bedrock, Matrix sediment) { }

	// RVA: 0x2AEC6B0 Offset: 0x2AEC7B1 VA: 0x2AEC6B0
	public void ApplyErosion(Matrix height, Matrix bedrock, Matrix sediment) { }

	// RVA: 0x2AEC8A0 Offset: 0x2AEC9A1 VA: 0x2AEC8A0
	public void ApplyBrush(Vector3 pos, float radius, bool useFallof = True) { }

	// RVA: 0x2AED3E0 Offset: 0x2AED4E1 VA: 0x2AED3E0
	public void GetHeight(Matrix matrix, Terrain terrain) { }

	// RVA: 0x2AED6A0 Offset: 0x2AED7A1 VA: 0x2AED6A0
	public void AddHeight(Matrix matrix, Terrain terrain) { }

	// RVA: 0x2AED8C0 Offset: 0x2AED9C1 VA: 0x2AED8C0
	public void AddSplat(Matrix matrix, Terrain terrain, int channel) { }

	// RVA: 0x2AEDF50 Offset: 0x2AEE051 VA: 0x2AEDF50
	public void TestUndo(Vector3 pos, float radius) { }

	// RVA: 0x2AEF100 Offset: 0x2AEF201 VA: 0x2AEF100
	public void NewUndo() { }

	// RVA: 0x2AEF180 Offset: 0x2AEF281 VA: 0x2AEF180
	public void AddUndo(Vector3 pos, float radius) { }

	// RVA: 0x2AEF3F0 Offset: 0x2AEF4F1 VA: 0x2AEF3F0
	public void AddGlobalUndo() { }

	// RVA: 0x2AEF8A0 Offset: 0x2AEF9A1 VA: 0x2AEF8A0
	public void PerformUndo() { }

	// RVA: 0x2AEFED0 Offset: 0x2AEFFD1 VA: 0x2AEFED0
	public void .ctor() { }
}

[ExecuteInEditMode] // RVA: 0x149580 Offset: 0x149681 VA: 0x149580
public class ErosionBrush : MonoBehaviour // TypeDefIndex: 9707
{
	// Fields
	public Terrain[] terrains; // 0x18
	private Terrain _terrain; // 0x20
	public Preset preset; // 0x28
	public Preset[] presets; // 0x30
	public int guiSelectedPreset; // 0x38
	public bool paint; // 0x3C
	public bool wasPaint; // 0x3D
	public bool moveDown; // 0x3E
	public Transform moveTfm; // 0x40
	public bool gen; // 0x48
	public bool undo; // 0x49
	public Texture2D guiHydraulicIcon; // 0x50
	public Texture2D guiWindIcon; // 0x58
	public Texture2D guiPluginIcon; // 0x60
	public int guiApplyIterations; // 0x68
	public int[] guiChannels; // 0x70
	public string[] guiChannelNames; // 0x78
	public Color guiBrushColor; // 0x80
	public float guiBrushThickness; // 0x90
	public int guiBrushNumCorners; // 0x94
	public bool recordUndo; // 0x98
	public bool unity5positioning; // 0x99
	public bool focusOnBrush; // 0x9A
	public bool guiShowPreset; // 0x9B
	public bool guiShowBrush; // 0x9C
	public bool guiShowErosion; // 0x9D
	public bool guiShowNoise; // 0x9E
	public bool guiShowTextures; // 0x9F
	public bool guiShowGlobal; // 0xA0
	public bool guiShowSettings; // 0xA1
	public bool guiShowAbout; // 0xA2
	public int guiMaxBrushSize; // 0xA4
	public bool guiSelectPresetsUsingNumkeys; // 0xA8
	public bool guiControlUsed; // 0xA9
	public int applyCount; // 0xAC
	public Stack<ErosionBrush.TerrainUndoStep[]> undoSteps; // 0xB0
	public Stack<ErosionBrush.TerrainUndoStep[]> redoSteps; // 0xB8
	public int currentUndoState; // 0xC0
	public int referenceUndoState; // 0xC4
	public List<List<ErosionBrush.UndoStep>> undoList; // 0xC8
	public bool allowUndo; // 0xD0

	// Properties
	public Terrain terrain { get; set; }

	// Methods

	// RVA: 0x2AEC220 Offset: 0x2AEC321 VA: 0x2AEC220
	public Terrain get_terrain() { }

	// RVA: 0x2AEC2D0 Offset: 0x2AEC3D1 VA: 0x2AEC2D0
	public void set_terrain(Terrain value) { }

	// RVA: 0x2AEC2E0 Offset: 0x2AEC3E1 VA: 0x2AEC2E0
	public Terrain[] GetTerrains() { }

	// RVA: 0x2AEC420 Offset: 0x2AEC521 VA: 0x2AEC420
	public void ApplyNoise(Matrix height, Matrix bedrock, Matrix sediment) { }

	// RVA: 0x2AEC6B0 Offset: 0x2AEC7B1 VA: 0x2AEC6B0
	public void ApplyErosion(Matrix height, Matrix bedrock, Matrix sediment) { }

	// RVA: 0x2AEC8A0 Offset: 0x2AEC9A1 VA: 0x2AEC8A0
	public void ApplyBrush(Vector3 pos, float radius, bool useFallof = True) { }

	// RVA: 0x2AED3E0 Offset: 0x2AED4E1 VA: 0x2AED3E0
	public void GetHeight(Matrix matrix, Terrain terrain) { }

	// RVA: 0x2AED6A0 Offset: 0x2AED7A1 VA: 0x2AED6A0
	public void AddHeight(Matrix matrix, Terrain terrain) { }

	// RVA: 0x2AED8C0 Offset: 0x2AED9C1 VA: 0x2AED8C0
	public void AddSplat(Matrix matrix, Terrain terrain, int channel) { }

	// RVA: 0x2AEDF50 Offset: 0x2AEE051 VA: 0x2AEDF50
	public void TestUndo(Vector3 pos, float radius) { }

	// RVA: 0x2AEF100 Offset: 0x2AEF201 VA: 0x2AEF100
	public void NewUndo() { }

	// RVA: 0x2AEF180 Offset: 0x2AEF281 VA: 0x2AEF180
	public void AddUndo(Vector3 pos, float radius) { }

	// RVA: 0x2AEF3F0 Offset: 0x2AEF4F1 VA: 0x2AEF3F0
	public void AddGlobalUndo() { }

	// RVA: 0x2AEF8A0 Offset: 0x2AEF9A1 VA: 0x2AEF8A0
	public void PerformUndo() { }

	// RVA: 0x2AEFED0 Offset: 0x2AEFFD1 VA: 0x2AEFED0
	public void .ctor() { }
}

