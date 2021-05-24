public class RF5FarmData : SaveDataValueBase // TypeDefIndex: 9876
{
	// Fields
	public bool[] FirstVisitFarm; // 0x10
	public int[] FarmSizeLevels; // 0x18
	public FarmCropData[] FarmCropDatas; // 0x20
	public int[] CrystalUseCounts; // 0x28
	public FarmManager.RF4_CROP_STATE[] Crop; // 0x30
	public FarmManager.RF4_SOIL_INFO[] Soil; // 0x38
	public int[] HarvestCount; // 0x40
	public List<ItemID> ItemHarvestIdList; // 0x48
	public bool[] MonsterHutReleaseFlags; // 0x50
	public MonsterHutSaveData[] MonsterHutSaveDatas; // 0x58

	// Methods

	// RVA: 0x1D74780 Offset: 0x1D74881 VA: 0x1D74780
	public void .ctor() { }

	// RVA: 0x1D74840 Offset: 0x1D74941 VA: 0x1D74840 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D75A50 Offset: 0x1D75B51 VA: 0x1D75A50
	public void InitializeForNewGame() { }

	// RVA: 0x1D75AC0 Offset: 0x1D75BC1 VA: 0x1D75AC0 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D75AD0 Offset: 0x1D75BD1 VA: 0x1D75AD0 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D75BF0 Offset: 0x1D75CF1 VA: 0x1D75BF0 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D75D60 Offset: 0x1D75E61 VA: 0x1D75D60
	public void Reader0000(BinaryReader reader) { }

	// RVA: -1 Offset: -1
	private void _writer<T>(BinaryWriter writer, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D7080 Offset: 0x21D7181 VA: 0x21D7080
	|-RF5FarmData._writer<object>
	*/

	// RVA: -1 Offset: -1
	private void _writer_array<T>(BinaryWriter writer, IReadOnlyList<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D80A0 Offset: 0x21D81A1 VA: 0x21D80A0
	|-RF5FarmData._writer_array<FarmCropData>
	|-RF5FarmData._writer_array<object>
	|
	|-RVA: 0x21D7140 Offset: 0x21D7241 VA: 0x21D7140
	|-RF5FarmData._writer_array<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x21D73F0 Offset: 0x21D74F1 VA: 0x21D73F0
	|-RF5FarmData._writer_array<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x21D7E20 Offset: 0x21D7F21 VA: 0x21D7E20
	|-RF5FarmData._writer_array<ItemID>
	|-RF5FarmData._writer_array<Int32Enum>
	|
	|-RVA: 0x21D7680 Offset: 0x21D7781 VA: 0x21D7680
	|-RF5FarmData._writer_array<MonsterHutSaveData>
	|
	|-RVA: 0x21D7920 Offset: 0x21D7A21 VA: 0x21D7920
	|-RF5FarmData._writer_array<bool>
	|
	|-RVA: 0x21D7BA0 Offset: 0x21D7CA1 VA: 0x21D7BA0
	|-RF5FarmData._writer_array<int>
	*/

	// RVA: -1 Offset: -1
	private T _reader<T>(BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C78A0 Offset: 0x23C79A1 VA: 0x23C78A0
	|-RF5FarmData._reader<object>
	*/

	// RVA: -1 Offset: -1
	private T[] _reader_array<T>(BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226DFE0 Offset: 0x226E0E1 VA: 0x226DFE0
	|-RF5FarmData._reader_array<FarmCropData>
	|-RF5FarmData._reader_array<object>
	|
	|-RVA: 0x226D6F0 Offset: 0x226D7F1 VA: 0x226D6F0
	|-RF5FarmData._reader_array<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x226D8B0 Offset: 0x226D9B1 VA: 0x226D8B0
	|-RF5FarmData._reader_array<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x226DE80 Offset: 0x226DF81 VA: 0x226DE80
	|-RF5FarmData._reader_array<ItemID>
	|-RF5FarmData._reader_array<Int32Enum>
	|
	|-RVA: 0x226DA10 Offset: 0x226DB11 VA: 0x226DA10
	|-RF5FarmData._reader_array<MonsterHutSaveData>
	|
	|-RVA: 0x226DBC0 Offset: 0x226DCC1 VA: 0x226DBC0
	|-RF5FarmData._reader_array<bool>
	|
	|-RVA: 0x226DD20 Offset: 0x226DE21 VA: 0x226DD20
	|-RF5FarmData._reader_array<int>
	*/
}

public class RF5FarmData : SaveDataValueBase // TypeDefIndex: 9876
{
	// Fields
	public bool[] FirstVisitFarm; // 0x10
	public int[] FarmSizeLevels; // 0x18
	public FarmCropData[] FarmCropDatas; // 0x20
	public int[] CrystalUseCounts; // 0x28
	public FarmManager.RF4_CROP_STATE[] Crop; // 0x30
	public FarmManager.RF4_SOIL_INFO[] Soil; // 0x38
	public int[] HarvestCount; // 0x40
	public List<ItemID> ItemHarvestIdList; // 0x48
	public bool[] MonsterHutReleaseFlags; // 0x50
	public MonsterHutSaveData[] MonsterHutSaveDatas; // 0x58

	// Methods

	// RVA: 0x1D74780 Offset: 0x1D74881 VA: 0x1D74780
	public void .ctor() { }

	// RVA: 0x1D74840 Offset: 0x1D74941 VA: 0x1D74840 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D75A50 Offset: 0x1D75B51 VA: 0x1D75A50
	public void InitializeForNewGame() { }

	// RVA: 0x1D75AC0 Offset: 0x1D75BC1 VA: 0x1D75AC0 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D75AD0 Offset: 0x1D75BD1 VA: 0x1D75AD0 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D75BF0 Offset: 0x1D75CF1 VA: 0x1D75BF0 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D75D60 Offset: 0x1D75E61 VA: 0x1D75D60
	public void Reader0000(BinaryReader reader) { }

	// RVA: -1 Offset: -1
	private void _writer<T>(BinaryWriter writer, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D7080 Offset: 0x21D7181 VA: 0x21D7080
	|-RF5FarmData._writer<object>
	*/

	// RVA: -1 Offset: -1
	private void _writer_array<T>(BinaryWriter writer, IReadOnlyList<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D80A0 Offset: 0x21D81A1 VA: 0x21D80A0
	|-RF5FarmData._writer_array<FarmCropData>
	|-RF5FarmData._writer_array<object>
	|
	|-RVA: 0x21D7140 Offset: 0x21D7241 VA: 0x21D7140
	|-RF5FarmData._writer_array<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x21D73F0 Offset: 0x21D74F1 VA: 0x21D73F0
	|-RF5FarmData._writer_array<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x21D7E20 Offset: 0x21D7F21 VA: 0x21D7E20
	|-RF5FarmData._writer_array<ItemID>
	|-RF5FarmData._writer_array<Int32Enum>
	|
	|-RVA: 0x21D7680 Offset: 0x21D7781 VA: 0x21D7680
	|-RF5FarmData._writer_array<MonsterHutSaveData>
	|
	|-RVA: 0x21D7920 Offset: 0x21D7A21 VA: 0x21D7920
	|-RF5FarmData._writer_array<bool>
	|
	|-RVA: 0x21D7BA0 Offset: 0x21D7CA1 VA: 0x21D7BA0
	|-RF5FarmData._writer_array<int>
	*/

	// RVA: -1 Offset: -1
	private T _reader<T>(BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C78A0 Offset: 0x23C79A1 VA: 0x23C78A0
	|-RF5FarmData._reader<object>
	*/

	// RVA: -1 Offset: -1
	private T[] _reader_array<T>(BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226DFE0 Offset: 0x226E0E1 VA: 0x226DFE0
	|-RF5FarmData._reader_array<FarmCropData>
	|-RF5FarmData._reader_array<object>
	|
	|-RVA: 0x226D6F0 Offset: 0x226D7F1 VA: 0x226D6F0
	|-RF5FarmData._reader_array<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x226D8B0 Offset: 0x226D9B1 VA: 0x226D8B0
	|-RF5FarmData._reader_array<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x226DE80 Offset: 0x226DF81 VA: 0x226DE80
	|-RF5FarmData._reader_array<ItemID>
	|-RF5FarmData._reader_array<Int32Enum>
	|
	|-RVA: 0x226DA10 Offset: 0x226DB11 VA: 0x226DA10
	|-RF5FarmData._reader_array<MonsterHutSaveData>
	|
	|-RVA: 0x226DBC0 Offset: 0x226DCC1 VA: 0x226DBC0
	|-RF5FarmData._reader_array<bool>
	|
	|-RVA: 0x226DD20 Offset: 0x226DE21 VA: 0x226DD20
	|-RF5FarmData._reader_array<int>
	*/
}

public class RF5FarmData : SaveDataValueBase // TypeDefIndex: 9876
{
	// Fields
	public bool[] FirstVisitFarm; // 0x10
	public int[] FarmSizeLevels; // 0x18
	public FarmCropData[] FarmCropDatas; // 0x20
	public int[] CrystalUseCounts; // 0x28
	public FarmManager.RF4_CROP_STATE[] Crop; // 0x30
	public FarmManager.RF4_SOIL_INFO[] Soil; // 0x38
	public int[] HarvestCount; // 0x40
	public List<ItemID> ItemHarvestIdList; // 0x48
	public bool[] MonsterHutReleaseFlags; // 0x50
	public MonsterHutSaveData[] MonsterHutSaveDatas; // 0x58

	// Methods

	// RVA: 0x1D74780 Offset: 0x1D74881 VA: 0x1D74780
	public void .ctor() { }

	// RVA: 0x1D74840 Offset: 0x1D74941 VA: 0x1D74840 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D75A50 Offset: 0x1D75B51 VA: 0x1D75A50
	public void InitializeForNewGame() { }

	// RVA: 0x1D75AC0 Offset: 0x1D75BC1 VA: 0x1D75AC0 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D75AD0 Offset: 0x1D75BD1 VA: 0x1D75AD0 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D75BF0 Offset: 0x1D75CF1 VA: 0x1D75BF0 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D75D60 Offset: 0x1D75E61 VA: 0x1D75D60
	public void Reader0000(BinaryReader reader) { }

	// RVA: -1 Offset: -1
	private void _writer<T>(BinaryWriter writer, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D7080 Offset: 0x21D7181 VA: 0x21D7080
	|-RF5FarmData._writer<object>
	*/

	// RVA: -1 Offset: -1
	private void _writer_array<T>(BinaryWriter writer, IReadOnlyList<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D80A0 Offset: 0x21D81A1 VA: 0x21D80A0
	|-RF5FarmData._writer_array<FarmCropData>
	|-RF5FarmData._writer_array<object>
	|
	|-RVA: 0x21D7140 Offset: 0x21D7241 VA: 0x21D7140
	|-RF5FarmData._writer_array<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x21D73F0 Offset: 0x21D74F1 VA: 0x21D73F0
	|-RF5FarmData._writer_array<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x21D7E20 Offset: 0x21D7F21 VA: 0x21D7E20
	|-RF5FarmData._writer_array<ItemID>
	|-RF5FarmData._writer_array<Int32Enum>
	|
	|-RVA: 0x21D7680 Offset: 0x21D7781 VA: 0x21D7680
	|-RF5FarmData._writer_array<MonsterHutSaveData>
	|
	|-RVA: 0x21D7920 Offset: 0x21D7A21 VA: 0x21D7920
	|-RF5FarmData._writer_array<bool>
	|
	|-RVA: 0x21D7BA0 Offset: 0x21D7CA1 VA: 0x21D7BA0
	|-RF5FarmData._writer_array<int>
	*/

	// RVA: -1 Offset: -1
	private T _reader<T>(BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C78A0 Offset: 0x23C79A1 VA: 0x23C78A0
	|-RF5FarmData._reader<object>
	*/

	// RVA: -1 Offset: -1
	private T[] _reader_array<T>(BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226DFE0 Offset: 0x226E0E1 VA: 0x226DFE0
	|-RF5FarmData._reader_array<FarmCropData>
	|-RF5FarmData._reader_array<object>
	|
	|-RVA: 0x226D6F0 Offset: 0x226D7F1 VA: 0x226D6F0
	|-RF5FarmData._reader_array<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x226D8B0 Offset: 0x226D9B1 VA: 0x226D8B0
	|-RF5FarmData._reader_array<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x226DE80 Offset: 0x226DF81 VA: 0x226DE80
	|-RF5FarmData._reader_array<ItemID>
	|-RF5FarmData._reader_array<Int32Enum>
	|
	|-RVA: 0x226DA10 Offset: 0x226DB11 VA: 0x226DA10
	|-RF5FarmData._reader_array<MonsterHutSaveData>
	|
	|-RVA: 0x226DBC0 Offset: 0x226DCC1 VA: 0x226DBC0
	|-RF5FarmData._reader_array<bool>
	|
	|-RVA: 0x226DD20 Offset: 0x226DE21 VA: 0x226DD20
	|-RF5FarmData._reader_array<int>
	*/
}

public class RF5FarmData : SaveDataValueBase // TypeDefIndex: 9876
{
	// Fields
	public bool[] FirstVisitFarm; // 0x10
	public int[] FarmSizeLevels; // 0x18
	public FarmCropData[] FarmCropDatas; // 0x20
	public int[] CrystalUseCounts; // 0x28
	public FarmManager.RF4_CROP_STATE[] Crop; // 0x30
	public FarmManager.RF4_SOIL_INFO[] Soil; // 0x38
	public int[] HarvestCount; // 0x40
	public List<ItemID> ItemHarvestIdList; // 0x48
	public bool[] MonsterHutReleaseFlags; // 0x50
	public MonsterHutSaveData[] MonsterHutSaveDatas; // 0x58

	// Methods

	// RVA: 0x1D74780 Offset: 0x1D74881 VA: 0x1D74780
	public void .ctor() { }

	// RVA: 0x1D74840 Offset: 0x1D74941 VA: 0x1D74840 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D75A50 Offset: 0x1D75B51 VA: 0x1D75A50
	public void InitializeForNewGame() { }

	// RVA: 0x1D75AC0 Offset: 0x1D75BC1 VA: 0x1D75AC0 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D75AD0 Offset: 0x1D75BD1 VA: 0x1D75AD0 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D75BF0 Offset: 0x1D75CF1 VA: 0x1D75BF0 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D75D60 Offset: 0x1D75E61 VA: 0x1D75D60
	public void Reader0000(BinaryReader reader) { }

	// RVA: -1 Offset: -1
	private void _writer<T>(BinaryWriter writer, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D7080 Offset: 0x21D7181 VA: 0x21D7080
	|-RF5FarmData._writer<object>
	*/

	// RVA: -1 Offset: -1
	private void _writer_array<T>(BinaryWriter writer, IReadOnlyList<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D80A0 Offset: 0x21D81A1 VA: 0x21D80A0
	|-RF5FarmData._writer_array<FarmCropData>
	|-RF5FarmData._writer_array<object>
	|
	|-RVA: 0x21D7140 Offset: 0x21D7241 VA: 0x21D7140
	|-RF5FarmData._writer_array<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x21D73F0 Offset: 0x21D74F1 VA: 0x21D73F0
	|-RF5FarmData._writer_array<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x21D7E20 Offset: 0x21D7F21 VA: 0x21D7E20
	|-RF5FarmData._writer_array<ItemID>
	|-RF5FarmData._writer_array<Int32Enum>
	|
	|-RVA: 0x21D7680 Offset: 0x21D7781 VA: 0x21D7680
	|-RF5FarmData._writer_array<MonsterHutSaveData>
	|
	|-RVA: 0x21D7920 Offset: 0x21D7A21 VA: 0x21D7920
	|-RF5FarmData._writer_array<bool>
	|
	|-RVA: 0x21D7BA0 Offset: 0x21D7CA1 VA: 0x21D7BA0
	|-RF5FarmData._writer_array<int>
	*/

	// RVA: -1 Offset: -1
	private T _reader<T>(BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C78A0 Offset: 0x23C79A1 VA: 0x23C78A0
	|-RF5FarmData._reader<object>
	*/

	// RVA: -1 Offset: -1
	private T[] _reader_array<T>(BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226DFE0 Offset: 0x226E0E1 VA: 0x226DFE0
	|-RF5FarmData._reader_array<FarmCropData>
	|-RF5FarmData._reader_array<object>
	|
	|-RVA: 0x226D6F0 Offset: 0x226D7F1 VA: 0x226D6F0
	|-RF5FarmData._reader_array<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x226D8B0 Offset: 0x226D9B1 VA: 0x226D8B0
	|-RF5FarmData._reader_array<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x226DE80 Offset: 0x226DF81 VA: 0x226DE80
	|-RF5FarmData._reader_array<ItemID>
	|-RF5FarmData._reader_array<Int32Enum>
	|
	|-RVA: 0x226DA10 Offset: 0x226DB11 VA: 0x226DA10
	|-RF5FarmData._reader_array<MonsterHutSaveData>
	|
	|-RVA: 0x226DBC0 Offset: 0x226DCC1 VA: 0x226DBC0
	|-RF5FarmData._reader_array<bool>
	|
	|-RVA: 0x226DD20 Offset: 0x226DE21 VA: 0x226DD20
	|-RF5FarmData._reader_array<int>
	*/
}

public class RF5FarmData : SaveDataValueBase // TypeDefIndex: 9876
{
	// Fields
	public bool[] FirstVisitFarm; // 0x10
	public int[] FarmSizeLevels; // 0x18
	public FarmCropData[] FarmCropDatas; // 0x20
	public int[] CrystalUseCounts; // 0x28
	public FarmManager.RF4_CROP_STATE[] Crop; // 0x30
	public FarmManager.RF4_SOIL_INFO[] Soil; // 0x38
	public int[] HarvestCount; // 0x40
	public List<ItemID> ItemHarvestIdList; // 0x48
	public bool[] MonsterHutReleaseFlags; // 0x50
	public MonsterHutSaveData[] MonsterHutSaveDatas; // 0x58

	// Methods

	// RVA: 0x1D74780 Offset: 0x1D74881 VA: 0x1D74780
	public void .ctor() { }

	// RVA: 0x1D74840 Offset: 0x1D74941 VA: 0x1D74840 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D75A50 Offset: 0x1D75B51 VA: 0x1D75A50
	public void InitializeForNewGame() { }

	// RVA: 0x1D75AC0 Offset: 0x1D75BC1 VA: 0x1D75AC0 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D75AD0 Offset: 0x1D75BD1 VA: 0x1D75AD0 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D75BF0 Offset: 0x1D75CF1 VA: 0x1D75BF0 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D75D60 Offset: 0x1D75E61 VA: 0x1D75D60
	public void Reader0000(BinaryReader reader) { }

	// RVA: -1 Offset: -1
	private void _writer<T>(BinaryWriter writer, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D7080 Offset: 0x21D7181 VA: 0x21D7080
	|-RF5FarmData._writer<object>
	*/

	// RVA: -1 Offset: -1
	private void _writer_array<T>(BinaryWriter writer, IReadOnlyList<T> data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D80A0 Offset: 0x21D81A1 VA: 0x21D80A0
	|-RF5FarmData._writer_array<FarmCropData>
	|-RF5FarmData._writer_array<object>
	|
	|-RVA: 0x21D7140 Offset: 0x21D7241 VA: 0x21D7140
	|-RF5FarmData._writer_array<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x21D73F0 Offset: 0x21D74F1 VA: 0x21D73F0
	|-RF5FarmData._writer_array<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x21D7E20 Offset: 0x21D7F21 VA: 0x21D7E20
	|-RF5FarmData._writer_array<ItemID>
	|-RF5FarmData._writer_array<Int32Enum>
	|
	|-RVA: 0x21D7680 Offset: 0x21D7781 VA: 0x21D7680
	|-RF5FarmData._writer_array<MonsterHutSaveData>
	|
	|-RVA: 0x21D7920 Offset: 0x21D7A21 VA: 0x21D7920
	|-RF5FarmData._writer_array<bool>
	|
	|-RVA: 0x21D7BA0 Offset: 0x21D7CA1 VA: 0x21D7BA0
	|-RF5FarmData._writer_array<int>
	*/

	// RVA: -1 Offset: -1
	private T _reader<T>(BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C78A0 Offset: 0x23C79A1 VA: 0x23C78A0
	|-RF5FarmData._reader<object>
	*/

	// RVA: -1 Offset: -1
	private T[] _reader_array<T>(BinaryReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x226DFE0 Offset: 0x226E0E1 VA: 0x226DFE0
	|-RF5FarmData._reader_array<FarmCropData>
	|-RF5FarmData._reader_array<object>
	|
	|-RVA: 0x226D6F0 Offset: 0x226D7F1 VA: 0x226D6F0
	|-RF5FarmData._reader_array<FarmManager.RF4_CROP_STATE>
	|
	|-RVA: 0x226D8B0 Offset: 0x226D9B1 VA: 0x226D8B0
	|-RF5FarmData._reader_array<FarmManager.RF4_SOIL_INFO>
	|
	|-RVA: 0x226DE80 Offset: 0x226DF81 VA: 0x226DE80
	|-RF5FarmData._reader_array<ItemID>
	|-RF5FarmData._reader_array<Int32Enum>
	|
	|-RVA: 0x226DA10 Offset: 0x226DB11 VA: 0x226DA10
	|-RF5FarmData._reader_array<MonsterHutSaveData>
	|
	|-RVA: 0x226DBC0 Offset: 0x226DCC1 VA: 0x226DBC0
	|-RF5FarmData._reader_array<bool>
	|
	|-RVA: 0x226DD20 Offset: 0x226DE21 VA: 0x226DD20
	|-RF5FarmData._reader_array<int>
	*/
}

