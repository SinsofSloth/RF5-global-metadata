public class RF5FurnitureData : SaveDataValueBase // TypeDefIndex: 9883
{
	// Fields
	private const int FURNITURE_MAX = 90;
	private const int FURNITURE_EMPTY2_MAX = 30;
	public List<FurnitureSaveData> FurnitureSaveData; // 0x10

	// Methods

	// RVA: 0x1D76D90 Offset: 0x1D76E91 VA: 0x1D76D90
	public void OnPutSave(string guid, Vector3 pos, Quaternion rot) { }

	// RVA: 0x1D76F90 Offset: 0x1D77091 VA: 0x1D76F90
	public int Count() { }

	// RVA: 0x1D770A0 Offset: 0x1D771A1 VA: 0x1D770A0
	public int EmptyCount() { }

	// RVA: 0x1D771B0 Offset: 0x1D772B1 VA: 0x1D771B0
	public int ReserveCount() { }

	// RVA: 0x1D772C0 Offset: 0x1D773C1 VA: 0x1D772C0
	public void SetFurniture(FurnitureSaveData newdata, bool is_reserve = False) { }

	// RVA: 0x1D774F0 Offset: 0x1D775F1 VA: 0x1D774F0
	public bool IsMax() { }

	// RVA: 0x1D77600 Offset: 0x1D77701 VA: 0x1D77600
	public bool IsCreate(FurnitureCreatePoint point) { }

	// RVA: 0x1D77740 Offset: 0x1D77841 VA: 0x1D77740
	public void HaveSaveData(string guid) { }

	// RVA: 0x1D77870 Offset: 0x1D77971 VA: 0x1D77870
	public bool ReturnSaveData(string guid, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0x1D77A70 Offset: 0x1D77B71 VA: 0x1D77A70
	public void RemoveSave(string guid) { }

	// RVA: 0x1D77BC0 Offset: 0x1D77CC1 VA: 0x1D77BC0
	public int GetFurnitureCount(FurnitureID furnitureId) { }

	// RVA: 0x1D77CE0 Offset: 0x1D77DE1 VA: 0x1D77CE0
	public bool CheckHadFurniture(FurnitureID id) { }

	// RVA: 0x1D77E00 Offset: 0x1D77F01 VA: 0x1D77E00
	public void AllBreak() { }

	// RVA: 0x1D77EF0 Offset: 0x1D77FF1 VA: 0x1D77EF0
	public bool IsBreak() { }

	// RVA: 0x1D78030 Offset: 0x1D78131 VA: 0x1D78030
	public List<FurnitureSaveData> GetFurnitureSaveDataList(FieldSceneId fieldSceneId) { }

	// RVA: 0x1D78110 Offset: 0x1D78211 VA: 0x1D78110
	public void .ctor() { }

	// RVA: 0x1D78140 Offset: 0x1D78241 VA: 0x1D78140 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D78260 Offset: 0x1D78361 VA: 0x1D78260 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D78270 Offset: 0x1D78371 VA: 0x1D78270 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D78280 Offset: 0x1D78381 VA: 0x1D78280 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D78520 Offset: 0x1D78621 VA: 0x1D78520
	public void Reader0000(BinaryReader reader) { }
}

public class RF5FurnitureData : SaveDataValueBase // TypeDefIndex: 9883
{
	// Fields
	private const int FURNITURE_MAX = 90;
	private const int FURNITURE_EMPTY2_MAX = 30;
	public List<FurnitureSaveData> FurnitureSaveData; // 0x10

	// Methods

	// RVA: 0x1D76D90 Offset: 0x1D76E91 VA: 0x1D76D90
	public void OnPutSave(string guid, Vector3 pos, Quaternion rot) { }

	// RVA: 0x1D76F90 Offset: 0x1D77091 VA: 0x1D76F90
	public int Count() { }

	// RVA: 0x1D770A0 Offset: 0x1D771A1 VA: 0x1D770A0
	public int EmptyCount() { }

	// RVA: 0x1D771B0 Offset: 0x1D772B1 VA: 0x1D771B0
	public int ReserveCount() { }

	// RVA: 0x1D772C0 Offset: 0x1D773C1 VA: 0x1D772C0
	public void SetFurniture(FurnitureSaveData newdata, bool is_reserve = False) { }

	// RVA: 0x1D774F0 Offset: 0x1D775F1 VA: 0x1D774F0
	public bool IsMax() { }

	// RVA: 0x1D77600 Offset: 0x1D77701 VA: 0x1D77600
	public bool IsCreate(FurnitureCreatePoint point) { }

	// RVA: 0x1D77740 Offset: 0x1D77841 VA: 0x1D77740
	public void HaveSaveData(string guid) { }

	// RVA: 0x1D77870 Offset: 0x1D77971 VA: 0x1D77870
	public bool ReturnSaveData(string guid, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0x1D77A70 Offset: 0x1D77B71 VA: 0x1D77A70
	public void RemoveSave(string guid) { }

	// RVA: 0x1D77BC0 Offset: 0x1D77CC1 VA: 0x1D77BC0
	public int GetFurnitureCount(FurnitureID furnitureId) { }

	// RVA: 0x1D77CE0 Offset: 0x1D77DE1 VA: 0x1D77CE0
	public bool CheckHadFurniture(FurnitureID id) { }

	// RVA: 0x1D77E00 Offset: 0x1D77F01 VA: 0x1D77E00
	public void AllBreak() { }

	// RVA: 0x1D77EF0 Offset: 0x1D77FF1 VA: 0x1D77EF0
	public bool IsBreak() { }

	// RVA: 0x1D78030 Offset: 0x1D78131 VA: 0x1D78030
	public List<FurnitureSaveData> GetFurnitureSaveDataList(FieldSceneId fieldSceneId) { }

	// RVA: 0x1D78110 Offset: 0x1D78211 VA: 0x1D78110
	public void .ctor() { }

	// RVA: 0x1D78140 Offset: 0x1D78241 VA: 0x1D78140 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D78260 Offset: 0x1D78361 VA: 0x1D78260 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D78270 Offset: 0x1D78371 VA: 0x1D78270 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D78280 Offset: 0x1D78381 VA: 0x1D78280 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D78520 Offset: 0x1D78621 VA: 0x1D78520
	public void Reader0000(BinaryReader reader) { }
}

public class RF5FurnitureData : SaveDataValueBase // TypeDefIndex: 9883
{
	// Fields
	private const int FURNITURE_MAX = 90;
	private const int FURNITURE_EMPTY2_MAX = 30;
	public List<FurnitureSaveData> FurnitureSaveData; // 0x10

	// Methods

	// RVA: 0x1D76D90 Offset: 0x1D76E91 VA: 0x1D76D90
	public void OnPutSave(string guid, Vector3 pos, Quaternion rot) { }

	// RVA: 0x1D76F90 Offset: 0x1D77091 VA: 0x1D76F90
	public int Count() { }

	// RVA: 0x1D770A0 Offset: 0x1D771A1 VA: 0x1D770A0
	public int EmptyCount() { }

	// RVA: 0x1D771B0 Offset: 0x1D772B1 VA: 0x1D771B0
	public int ReserveCount() { }

	// RVA: 0x1D772C0 Offset: 0x1D773C1 VA: 0x1D772C0
	public void SetFurniture(FurnitureSaveData newdata, bool is_reserve = False) { }

	// RVA: 0x1D774F0 Offset: 0x1D775F1 VA: 0x1D774F0
	public bool IsMax() { }

	// RVA: 0x1D77600 Offset: 0x1D77701 VA: 0x1D77600
	public bool IsCreate(FurnitureCreatePoint point) { }

	// RVA: 0x1D77740 Offset: 0x1D77841 VA: 0x1D77740
	public void HaveSaveData(string guid) { }

	// RVA: 0x1D77870 Offset: 0x1D77971 VA: 0x1D77870
	public bool ReturnSaveData(string guid, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0x1D77A70 Offset: 0x1D77B71 VA: 0x1D77A70
	public void RemoveSave(string guid) { }

	// RVA: 0x1D77BC0 Offset: 0x1D77CC1 VA: 0x1D77BC0
	public int GetFurnitureCount(FurnitureID furnitureId) { }

	// RVA: 0x1D77CE0 Offset: 0x1D77DE1 VA: 0x1D77CE0
	public bool CheckHadFurniture(FurnitureID id) { }

	// RVA: 0x1D77E00 Offset: 0x1D77F01 VA: 0x1D77E00
	public void AllBreak() { }

	// RVA: 0x1D77EF0 Offset: 0x1D77FF1 VA: 0x1D77EF0
	public bool IsBreak() { }

	// RVA: 0x1D78030 Offset: 0x1D78131 VA: 0x1D78030
	public List<FurnitureSaveData> GetFurnitureSaveDataList(FieldSceneId fieldSceneId) { }

	// RVA: 0x1D78110 Offset: 0x1D78211 VA: 0x1D78110
	public void .ctor() { }

	// RVA: 0x1D78140 Offset: 0x1D78241 VA: 0x1D78140 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D78260 Offset: 0x1D78361 VA: 0x1D78260 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D78270 Offset: 0x1D78371 VA: 0x1D78270 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D78280 Offset: 0x1D78381 VA: 0x1D78280 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D78520 Offset: 0x1D78621 VA: 0x1D78520
	public void Reader0000(BinaryReader reader) { }
}

public class RF5FurnitureData : SaveDataValueBase // TypeDefIndex: 9883
{
	// Fields
	private const int FURNITURE_MAX = 90;
	private const int FURNITURE_EMPTY2_MAX = 30;
	public List<FurnitureSaveData> FurnitureSaveData; // 0x10

	// Methods

	// RVA: 0x1D76D90 Offset: 0x1D76E91 VA: 0x1D76D90
	public void OnPutSave(string guid, Vector3 pos, Quaternion rot) { }

	// RVA: 0x1D76F90 Offset: 0x1D77091 VA: 0x1D76F90
	public int Count() { }

	// RVA: 0x1D770A0 Offset: 0x1D771A1 VA: 0x1D770A0
	public int EmptyCount() { }

	// RVA: 0x1D771B0 Offset: 0x1D772B1 VA: 0x1D771B0
	public int ReserveCount() { }

	// RVA: 0x1D772C0 Offset: 0x1D773C1 VA: 0x1D772C0
	public void SetFurniture(FurnitureSaveData newdata, bool is_reserve = False) { }

	// RVA: 0x1D774F0 Offset: 0x1D775F1 VA: 0x1D774F0
	public bool IsMax() { }

	// RVA: 0x1D77600 Offset: 0x1D77701 VA: 0x1D77600
	public bool IsCreate(FurnitureCreatePoint point) { }

	// RVA: 0x1D77740 Offset: 0x1D77841 VA: 0x1D77740
	public void HaveSaveData(string guid) { }

	// RVA: 0x1D77870 Offset: 0x1D77971 VA: 0x1D77870
	public bool ReturnSaveData(string guid, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0x1D77A70 Offset: 0x1D77B71 VA: 0x1D77A70
	public void RemoveSave(string guid) { }

	// RVA: 0x1D77BC0 Offset: 0x1D77CC1 VA: 0x1D77BC0
	public int GetFurnitureCount(FurnitureID furnitureId) { }

	// RVA: 0x1D77CE0 Offset: 0x1D77DE1 VA: 0x1D77CE0
	public bool CheckHadFurniture(FurnitureID id) { }

	// RVA: 0x1D77E00 Offset: 0x1D77F01 VA: 0x1D77E00
	public void AllBreak() { }

	// RVA: 0x1D77EF0 Offset: 0x1D77FF1 VA: 0x1D77EF0
	public bool IsBreak() { }

	// RVA: 0x1D78030 Offset: 0x1D78131 VA: 0x1D78030
	public List<FurnitureSaveData> GetFurnitureSaveDataList(FieldSceneId fieldSceneId) { }

	// RVA: 0x1D78110 Offset: 0x1D78211 VA: 0x1D78110
	public void .ctor() { }

	// RVA: 0x1D78140 Offset: 0x1D78241 VA: 0x1D78140 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D78260 Offset: 0x1D78361 VA: 0x1D78260 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D78270 Offset: 0x1D78371 VA: 0x1D78270 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D78280 Offset: 0x1D78381 VA: 0x1D78280 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D78520 Offset: 0x1D78621 VA: 0x1D78520
	public void Reader0000(BinaryReader reader) { }
}

public class RF5FurnitureData : SaveDataValueBase // TypeDefIndex: 9883
{
	// Fields
	private const int FURNITURE_MAX = 90;
	private const int FURNITURE_EMPTY2_MAX = 30;
	public List<FurnitureSaveData> FurnitureSaveData; // 0x10

	// Methods

	// RVA: 0x1D76D90 Offset: 0x1D76E91 VA: 0x1D76D90
	public void OnPutSave(string guid, Vector3 pos, Quaternion rot) { }

	// RVA: 0x1D76F90 Offset: 0x1D77091 VA: 0x1D76F90
	public int Count() { }

	// RVA: 0x1D770A0 Offset: 0x1D771A1 VA: 0x1D770A0
	public int EmptyCount() { }

	// RVA: 0x1D771B0 Offset: 0x1D772B1 VA: 0x1D771B0
	public int ReserveCount() { }

	// RVA: 0x1D772C0 Offset: 0x1D773C1 VA: 0x1D772C0
	public void SetFurniture(FurnitureSaveData newdata, bool is_reserve = False) { }

	// RVA: 0x1D774F0 Offset: 0x1D775F1 VA: 0x1D774F0
	public bool IsMax() { }

	// RVA: 0x1D77600 Offset: 0x1D77701 VA: 0x1D77600
	public bool IsCreate(FurnitureCreatePoint point) { }

	// RVA: 0x1D77740 Offset: 0x1D77841 VA: 0x1D77740
	public void HaveSaveData(string guid) { }

	// RVA: 0x1D77870 Offset: 0x1D77971 VA: 0x1D77870
	public bool ReturnSaveData(string guid, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0x1D77A70 Offset: 0x1D77B71 VA: 0x1D77A70
	public void RemoveSave(string guid) { }

	// RVA: 0x1D77BC0 Offset: 0x1D77CC1 VA: 0x1D77BC0
	public int GetFurnitureCount(FurnitureID furnitureId) { }

	// RVA: 0x1D77CE0 Offset: 0x1D77DE1 VA: 0x1D77CE0
	public bool CheckHadFurniture(FurnitureID id) { }

	// RVA: 0x1D77E00 Offset: 0x1D77F01 VA: 0x1D77E00
	public void AllBreak() { }

	// RVA: 0x1D77EF0 Offset: 0x1D77FF1 VA: 0x1D77EF0
	public bool IsBreak() { }

	// RVA: 0x1D78030 Offset: 0x1D78131 VA: 0x1D78030
	public List<FurnitureSaveData> GetFurnitureSaveDataList(FieldSceneId fieldSceneId) { }

	// RVA: 0x1D78110 Offset: 0x1D78211 VA: 0x1D78110
	public void .ctor() { }

	// RVA: 0x1D78140 Offset: 0x1D78241 VA: 0x1D78140 Slot: 4
	public override void Initialize() { }

	// RVA: 0x1D78260 Offset: 0x1D78361 VA: 0x1D78260 Slot: 5
	public override void BeforeSave() { }

	// RVA: 0x1D78270 Offset: 0x1D78371 VA: 0x1D78270 Slot: 6
	public override void AfterLoad() { }

	// RVA: 0x1D78280 Offset: 0x1D78381 VA: 0x1D78280 Slot: 7
	public override void Writer(BinaryWriter writer) { }

	// RVA: 0x1D78520 Offset: 0x1D78621 VA: 0x1D78520
	public void Reader0000(BinaryReader reader) { }
}

