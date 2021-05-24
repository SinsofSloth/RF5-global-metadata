public class HouseMaterialChangeTime : MonoBehaviour // TypeDefIndex: 10448
{
	// Fields
	[SerializeField] // RVA: 0x1818E0 Offset: 0x1819E1 VA: 0x1818E0
	private MaterialChangeTime[] _MaterialChangeTimes; // 0x18
	[SerializeField] // RVA: 0x1818F0 Offset: 0x1819F1 VA: 0x1818F0
	private TimeParamTable[] _TimeParamTables; // 0x20
	[SerializeField] // RVA: 0x181900 Offset: 0x181A01 VA: 0x181900
	private ObjectChangeTime[] _ObjectChangeTimes; // 0x28
	[SerializeField] // RVA: 0x181910 Offset: 0x181A11 VA: 0x181910
	private TimeParamTable[] _ObjectTimeParamTables; // 0x30
	[SerializeField] // RVA: 0x181920 Offset: 0x181A21 VA: 0x181920
	public bool IsVacant; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x181930 Offset: 0x181A31 VA: 0x181930
	private bool <IsSleeping>k__BackingField; // 0x39
	private int _HouseId; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x181940 Offset: 0x181A41 VA: 0x181940
	private HouseWindowMaterialType <HouseWindowMaterialType>k__BackingField; // 0x40

	// Properties
	public MaterialChangeTime[] MaterialChangeTimes { get; set; }
	public TimeParamTable[] TimeParamTables { get; set; }
	public ObjectChangeTime[] ObjectChangeTimes { get; set; }
	public TimeParamTable[] ObjectTimeParamTables { get; set; }
	[SerializeField] // RVA: 0x1B92C0 Offset: 0x1B93C1 VA: 0x1B92C0
	public bool IsSleeping { get; set; }
	public int HouseId { get; set; }
	public HouseWindowMaterialType HouseWindowMaterialType { get; set; }

	// Methods

	// RVA: 0x1EE6E90 Offset: 0x1EE6F91 VA: 0x1EE6E90
	public MaterialChangeTime[] get_MaterialChangeTimes() { }

	// RVA: 0x1EE6EA0 Offset: 0x1EE6FA1 VA: 0x1EE6EA0
	public void set_MaterialChangeTimes(MaterialChangeTime[] value) { }

	// RVA: 0x1EE6EB0 Offset: 0x1EE6FB1 VA: 0x1EE6EB0
	public TimeParamTable[] get_TimeParamTables() { }

	// RVA: 0x1EE6EC0 Offset: 0x1EE6FC1 VA: 0x1EE6EC0
	public void set_TimeParamTables(TimeParamTable[] value) { }

	// RVA: 0x1EE6ED0 Offset: 0x1EE6FD1 VA: 0x1EE6ED0
	public ObjectChangeTime[] get_ObjectChangeTimes() { }

	// RVA: 0x1EE6EE0 Offset: 0x1EE6FE1 VA: 0x1EE6EE0
	public void set_ObjectChangeTimes(ObjectChangeTime[] value) { }

	// RVA: 0x1EE6EF0 Offset: 0x1EE6FF1 VA: 0x1EE6EF0
	public TimeParamTable[] get_ObjectTimeParamTables() { }

	// RVA: 0x1EE6F00 Offset: 0x1EE7001 VA: 0x1EE6F00
	public void set_ObjectTimeParamTables(TimeParamTable[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF3F0 Offset: 0x1AF4F1 VA: 0x1AF3F0
	// RVA: 0x1EE6F10 Offset: 0x1EE7011 VA: 0x1EE6F10
	public bool get_IsSleeping() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF400 Offset: 0x1AF501 VA: 0x1AF400
	// RVA: 0x1EE6F20 Offset: 0x1EE7021 VA: 0x1EE6F20
	public void set_IsSleeping(bool value) { }

	// RVA: 0x1EE6F30 Offset: 0x1EE7031 VA: 0x1EE6F30
	public int get_HouseId() { }

	// RVA: 0x1EE6F40 Offset: 0x1EE7041 VA: 0x1EE6F40
	public void set_HouseId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF410 Offset: 0x1AF511 VA: 0x1AF410
	// RVA: 0x1EE6F50 Offset: 0x1EE7051 VA: 0x1EE6F50
	public HouseWindowMaterialType get_HouseWindowMaterialType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF420 Offset: 0x1AF521 VA: 0x1AF420
	// RVA: 0x1EE6F60 Offset: 0x1EE7061 VA: 0x1EE6F60
	public void set_HouseWindowMaterialType(HouseWindowMaterialType value) { }

	// RVA: 0x1EE6F70 Offset: 0x1EE7071 VA: 0x1EE6F70
	private void OnDestroy() { }

	// RVA: 0x1EE7070 Offset: 0x1EE7171 VA: 0x1EE7070
	private void Awake() { }

	// RVA: 0x1EE7080 Offset: 0x1EE7181 VA: 0x1EE7080
	private void Start() { }

	// RVA: 0x1EE71B0 Offset: 0x1EE72B1 VA: 0x1EE71B0
	private void CheckHouseState(int houseId) { }

	// RVA: 0x1EE7400 Offset: 0x1EE7501 VA: 0x1EE7400
	private void SetHouseWindowTimeParam(TimeParamTable[] timeParamTables, MaterialChangeTime[] materialChangeTimes) { }

	// RVA: 0x1EE7480 Offset: 0x1EE7581 VA: 0x1EE7480
	private void SetHouseObjectTimeParam(TimeParamTable timeParamTable, ObjectChangeTime[] objectChangeTimes) { }

	// RVA: 0x1EE7640 Offset: 0x1EE7741 VA: 0x1EE7640
	public void OnHourChangeSetParam(int elapsedHour) { }

	// RVA: 0x1EE7650 Offset: 0x1EE7751 VA: 0x1EE7650
	public void .ctor() { }
}

public class HouseMaterialChangeTime : MonoBehaviour // TypeDefIndex: 10448
{
	// Fields
	[SerializeField] // RVA: 0x1818E0 Offset: 0x1819E1 VA: 0x1818E0
	private MaterialChangeTime[] _MaterialChangeTimes; // 0x18
	[SerializeField] // RVA: 0x1818F0 Offset: 0x1819F1 VA: 0x1818F0
	private TimeParamTable[] _TimeParamTables; // 0x20
	[SerializeField] // RVA: 0x181900 Offset: 0x181A01 VA: 0x181900
	private ObjectChangeTime[] _ObjectChangeTimes; // 0x28
	[SerializeField] // RVA: 0x181910 Offset: 0x181A11 VA: 0x181910
	private TimeParamTable[] _ObjectTimeParamTables; // 0x30
	[SerializeField] // RVA: 0x181920 Offset: 0x181A21 VA: 0x181920
	public bool IsVacant; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x181930 Offset: 0x181A31 VA: 0x181930
	private bool <IsSleeping>k__BackingField; // 0x39
	private int _HouseId; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x181940 Offset: 0x181A41 VA: 0x181940
	private HouseWindowMaterialType <HouseWindowMaterialType>k__BackingField; // 0x40

	// Properties
	public MaterialChangeTime[] MaterialChangeTimes { get; set; }
	public TimeParamTable[] TimeParamTables { get; set; }
	public ObjectChangeTime[] ObjectChangeTimes { get; set; }
	public TimeParamTable[] ObjectTimeParamTables { get; set; }
	[SerializeField] // RVA: 0x1B92C0 Offset: 0x1B93C1 VA: 0x1B92C0
	public bool IsSleeping { get; set; }
	public int HouseId { get; set; }
	public HouseWindowMaterialType HouseWindowMaterialType { get; set; }

	// Methods

	// RVA: 0x1EE6E90 Offset: 0x1EE6F91 VA: 0x1EE6E90
	public MaterialChangeTime[] get_MaterialChangeTimes() { }

	// RVA: 0x1EE6EA0 Offset: 0x1EE6FA1 VA: 0x1EE6EA0
	public void set_MaterialChangeTimes(MaterialChangeTime[] value) { }

	// RVA: 0x1EE6EB0 Offset: 0x1EE6FB1 VA: 0x1EE6EB0
	public TimeParamTable[] get_TimeParamTables() { }

	// RVA: 0x1EE6EC0 Offset: 0x1EE6FC1 VA: 0x1EE6EC0
	public void set_TimeParamTables(TimeParamTable[] value) { }

	// RVA: 0x1EE6ED0 Offset: 0x1EE6FD1 VA: 0x1EE6ED0
	public ObjectChangeTime[] get_ObjectChangeTimes() { }

	// RVA: 0x1EE6EE0 Offset: 0x1EE6FE1 VA: 0x1EE6EE0
	public void set_ObjectChangeTimes(ObjectChangeTime[] value) { }

	// RVA: 0x1EE6EF0 Offset: 0x1EE6FF1 VA: 0x1EE6EF0
	public TimeParamTable[] get_ObjectTimeParamTables() { }

	// RVA: 0x1EE6F00 Offset: 0x1EE7001 VA: 0x1EE6F00
	public void set_ObjectTimeParamTables(TimeParamTable[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF3F0 Offset: 0x1AF4F1 VA: 0x1AF3F0
	// RVA: 0x1EE6F10 Offset: 0x1EE7011 VA: 0x1EE6F10
	public bool get_IsSleeping() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF400 Offset: 0x1AF501 VA: 0x1AF400
	// RVA: 0x1EE6F20 Offset: 0x1EE7021 VA: 0x1EE6F20
	public void set_IsSleeping(bool value) { }

	// RVA: 0x1EE6F30 Offset: 0x1EE7031 VA: 0x1EE6F30
	public int get_HouseId() { }

	// RVA: 0x1EE6F40 Offset: 0x1EE7041 VA: 0x1EE6F40
	public void set_HouseId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF410 Offset: 0x1AF511 VA: 0x1AF410
	// RVA: 0x1EE6F50 Offset: 0x1EE7051 VA: 0x1EE6F50
	public HouseWindowMaterialType get_HouseWindowMaterialType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF420 Offset: 0x1AF521 VA: 0x1AF420
	// RVA: 0x1EE6F60 Offset: 0x1EE7061 VA: 0x1EE6F60
	public void set_HouseWindowMaterialType(HouseWindowMaterialType value) { }

	// RVA: 0x1EE6F70 Offset: 0x1EE7071 VA: 0x1EE6F70
	private void OnDestroy() { }

	// RVA: 0x1EE7070 Offset: 0x1EE7171 VA: 0x1EE7070
	private void Awake() { }

	// RVA: 0x1EE7080 Offset: 0x1EE7181 VA: 0x1EE7080
	private void Start() { }

	// RVA: 0x1EE71B0 Offset: 0x1EE72B1 VA: 0x1EE71B0
	private void CheckHouseState(int houseId) { }

	// RVA: 0x1EE7400 Offset: 0x1EE7501 VA: 0x1EE7400
	private void SetHouseWindowTimeParam(TimeParamTable[] timeParamTables, MaterialChangeTime[] materialChangeTimes) { }

	// RVA: 0x1EE7480 Offset: 0x1EE7581 VA: 0x1EE7480
	private void SetHouseObjectTimeParam(TimeParamTable timeParamTable, ObjectChangeTime[] objectChangeTimes) { }

	// RVA: 0x1EE7640 Offset: 0x1EE7741 VA: 0x1EE7640
	public void OnHourChangeSetParam(int elapsedHour) { }

	// RVA: 0x1EE7650 Offset: 0x1EE7751 VA: 0x1EE7650
	public void .ctor() { }
}

public class HouseMaterialChangeTime : MonoBehaviour // TypeDefIndex: 10448
{
	// Fields
	[SerializeField] // RVA: 0x1818E0 Offset: 0x1819E1 VA: 0x1818E0
	private MaterialChangeTime[] _MaterialChangeTimes; // 0x18
	[SerializeField] // RVA: 0x1818F0 Offset: 0x1819F1 VA: 0x1818F0
	private TimeParamTable[] _TimeParamTables; // 0x20
	[SerializeField] // RVA: 0x181900 Offset: 0x181A01 VA: 0x181900
	private ObjectChangeTime[] _ObjectChangeTimes; // 0x28
	[SerializeField] // RVA: 0x181910 Offset: 0x181A11 VA: 0x181910
	private TimeParamTable[] _ObjectTimeParamTables; // 0x30
	[SerializeField] // RVA: 0x181920 Offset: 0x181A21 VA: 0x181920
	public bool IsVacant; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x181930 Offset: 0x181A31 VA: 0x181930
	private bool <IsSleeping>k__BackingField; // 0x39
	private int _HouseId; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x181940 Offset: 0x181A41 VA: 0x181940
	private HouseWindowMaterialType <HouseWindowMaterialType>k__BackingField; // 0x40

	// Properties
	public MaterialChangeTime[] MaterialChangeTimes { get; set; }
	public TimeParamTable[] TimeParamTables { get; set; }
	public ObjectChangeTime[] ObjectChangeTimes { get; set; }
	public TimeParamTable[] ObjectTimeParamTables { get; set; }
	[SerializeField] // RVA: 0x1B92C0 Offset: 0x1B93C1 VA: 0x1B92C0
	public bool IsSleeping { get; set; }
	public int HouseId { get; set; }
	public HouseWindowMaterialType HouseWindowMaterialType { get; set; }

	// Methods

	// RVA: 0x1EE6E90 Offset: 0x1EE6F91 VA: 0x1EE6E90
	public MaterialChangeTime[] get_MaterialChangeTimes() { }

	// RVA: 0x1EE6EA0 Offset: 0x1EE6FA1 VA: 0x1EE6EA0
	public void set_MaterialChangeTimes(MaterialChangeTime[] value) { }

	// RVA: 0x1EE6EB0 Offset: 0x1EE6FB1 VA: 0x1EE6EB0
	public TimeParamTable[] get_TimeParamTables() { }

	// RVA: 0x1EE6EC0 Offset: 0x1EE6FC1 VA: 0x1EE6EC0
	public void set_TimeParamTables(TimeParamTable[] value) { }

	// RVA: 0x1EE6ED0 Offset: 0x1EE6FD1 VA: 0x1EE6ED0
	public ObjectChangeTime[] get_ObjectChangeTimes() { }

	// RVA: 0x1EE6EE0 Offset: 0x1EE6FE1 VA: 0x1EE6EE0
	public void set_ObjectChangeTimes(ObjectChangeTime[] value) { }

	// RVA: 0x1EE6EF0 Offset: 0x1EE6FF1 VA: 0x1EE6EF0
	public TimeParamTable[] get_ObjectTimeParamTables() { }

	// RVA: 0x1EE6F00 Offset: 0x1EE7001 VA: 0x1EE6F00
	public void set_ObjectTimeParamTables(TimeParamTable[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF3F0 Offset: 0x1AF4F1 VA: 0x1AF3F0
	// RVA: 0x1EE6F10 Offset: 0x1EE7011 VA: 0x1EE6F10
	public bool get_IsSleeping() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF400 Offset: 0x1AF501 VA: 0x1AF400
	// RVA: 0x1EE6F20 Offset: 0x1EE7021 VA: 0x1EE6F20
	public void set_IsSleeping(bool value) { }

	// RVA: 0x1EE6F30 Offset: 0x1EE7031 VA: 0x1EE6F30
	public int get_HouseId() { }

	// RVA: 0x1EE6F40 Offset: 0x1EE7041 VA: 0x1EE6F40
	public void set_HouseId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF410 Offset: 0x1AF511 VA: 0x1AF410
	// RVA: 0x1EE6F50 Offset: 0x1EE7051 VA: 0x1EE6F50
	public HouseWindowMaterialType get_HouseWindowMaterialType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF420 Offset: 0x1AF521 VA: 0x1AF420
	// RVA: 0x1EE6F60 Offset: 0x1EE7061 VA: 0x1EE6F60
	public void set_HouseWindowMaterialType(HouseWindowMaterialType value) { }

	// RVA: 0x1EE6F70 Offset: 0x1EE7071 VA: 0x1EE6F70
	private void OnDestroy() { }

	// RVA: 0x1EE7070 Offset: 0x1EE7171 VA: 0x1EE7070
	private void Awake() { }

	// RVA: 0x1EE7080 Offset: 0x1EE7181 VA: 0x1EE7080
	private void Start() { }

	// RVA: 0x1EE71B0 Offset: 0x1EE72B1 VA: 0x1EE71B0
	private void CheckHouseState(int houseId) { }

	// RVA: 0x1EE7400 Offset: 0x1EE7501 VA: 0x1EE7400
	private void SetHouseWindowTimeParam(TimeParamTable[] timeParamTables, MaterialChangeTime[] materialChangeTimes) { }

	// RVA: 0x1EE7480 Offset: 0x1EE7581 VA: 0x1EE7480
	private void SetHouseObjectTimeParam(TimeParamTable timeParamTable, ObjectChangeTime[] objectChangeTimes) { }

	// RVA: 0x1EE7640 Offset: 0x1EE7741 VA: 0x1EE7640
	public void OnHourChangeSetParam(int elapsedHour) { }

	// RVA: 0x1EE7650 Offset: 0x1EE7751 VA: 0x1EE7650
	public void .ctor() { }
}

public class HouseMaterialChangeTime : MonoBehaviour // TypeDefIndex: 10448
{
	// Fields
	[SerializeField] // RVA: 0x1818E0 Offset: 0x1819E1 VA: 0x1818E0
	private MaterialChangeTime[] _MaterialChangeTimes; // 0x18
	[SerializeField] // RVA: 0x1818F0 Offset: 0x1819F1 VA: 0x1818F0
	private TimeParamTable[] _TimeParamTables; // 0x20
	[SerializeField] // RVA: 0x181900 Offset: 0x181A01 VA: 0x181900
	private ObjectChangeTime[] _ObjectChangeTimes; // 0x28
	[SerializeField] // RVA: 0x181910 Offset: 0x181A11 VA: 0x181910
	private TimeParamTable[] _ObjectTimeParamTables; // 0x30
	[SerializeField] // RVA: 0x181920 Offset: 0x181A21 VA: 0x181920
	public bool IsVacant; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x181930 Offset: 0x181A31 VA: 0x181930
	private bool <IsSleeping>k__BackingField; // 0x39
	private int _HouseId; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x181940 Offset: 0x181A41 VA: 0x181940
	private HouseWindowMaterialType <HouseWindowMaterialType>k__BackingField; // 0x40

	// Properties
	public MaterialChangeTime[] MaterialChangeTimes { get; set; }
	public TimeParamTable[] TimeParamTables { get; set; }
	public ObjectChangeTime[] ObjectChangeTimes { get; set; }
	public TimeParamTable[] ObjectTimeParamTables { get; set; }
	[SerializeField] // RVA: 0x1B92C0 Offset: 0x1B93C1 VA: 0x1B92C0
	public bool IsSleeping { get; set; }
	public int HouseId { get; set; }
	public HouseWindowMaterialType HouseWindowMaterialType { get; set; }

	// Methods

	// RVA: 0x1EE6E90 Offset: 0x1EE6F91 VA: 0x1EE6E90
	public MaterialChangeTime[] get_MaterialChangeTimes() { }

	// RVA: 0x1EE6EA0 Offset: 0x1EE6FA1 VA: 0x1EE6EA0
	public void set_MaterialChangeTimes(MaterialChangeTime[] value) { }

	// RVA: 0x1EE6EB0 Offset: 0x1EE6FB1 VA: 0x1EE6EB0
	public TimeParamTable[] get_TimeParamTables() { }

	// RVA: 0x1EE6EC0 Offset: 0x1EE6FC1 VA: 0x1EE6EC0
	public void set_TimeParamTables(TimeParamTable[] value) { }

	// RVA: 0x1EE6ED0 Offset: 0x1EE6FD1 VA: 0x1EE6ED0
	public ObjectChangeTime[] get_ObjectChangeTimes() { }

	// RVA: 0x1EE6EE0 Offset: 0x1EE6FE1 VA: 0x1EE6EE0
	public void set_ObjectChangeTimes(ObjectChangeTime[] value) { }

	// RVA: 0x1EE6EF0 Offset: 0x1EE6FF1 VA: 0x1EE6EF0
	public TimeParamTable[] get_ObjectTimeParamTables() { }

	// RVA: 0x1EE6F00 Offset: 0x1EE7001 VA: 0x1EE6F00
	public void set_ObjectTimeParamTables(TimeParamTable[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF3F0 Offset: 0x1AF4F1 VA: 0x1AF3F0
	// RVA: 0x1EE6F10 Offset: 0x1EE7011 VA: 0x1EE6F10
	public bool get_IsSleeping() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF400 Offset: 0x1AF501 VA: 0x1AF400
	// RVA: 0x1EE6F20 Offset: 0x1EE7021 VA: 0x1EE6F20
	public void set_IsSleeping(bool value) { }

	// RVA: 0x1EE6F30 Offset: 0x1EE7031 VA: 0x1EE6F30
	public int get_HouseId() { }

	// RVA: 0x1EE6F40 Offset: 0x1EE7041 VA: 0x1EE6F40
	public void set_HouseId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF410 Offset: 0x1AF511 VA: 0x1AF410
	// RVA: 0x1EE6F50 Offset: 0x1EE7051 VA: 0x1EE6F50
	public HouseWindowMaterialType get_HouseWindowMaterialType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF420 Offset: 0x1AF521 VA: 0x1AF420
	// RVA: 0x1EE6F60 Offset: 0x1EE7061 VA: 0x1EE6F60
	public void set_HouseWindowMaterialType(HouseWindowMaterialType value) { }

	// RVA: 0x1EE6F70 Offset: 0x1EE7071 VA: 0x1EE6F70
	private void OnDestroy() { }

	// RVA: 0x1EE7070 Offset: 0x1EE7171 VA: 0x1EE7070
	private void Awake() { }

	// RVA: 0x1EE7080 Offset: 0x1EE7181 VA: 0x1EE7080
	private void Start() { }

	// RVA: 0x1EE71B0 Offset: 0x1EE72B1 VA: 0x1EE71B0
	private void CheckHouseState(int houseId) { }

	// RVA: 0x1EE7400 Offset: 0x1EE7501 VA: 0x1EE7400
	private void SetHouseWindowTimeParam(TimeParamTable[] timeParamTables, MaterialChangeTime[] materialChangeTimes) { }

	// RVA: 0x1EE7480 Offset: 0x1EE7581 VA: 0x1EE7480
	private void SetHouseObjectTimeParam(TimeParamTable timeParamTable, ObjectChangeTime[] objectChangeTimes) { }

	// RVA: 0x1EE7640 Offset: 0x1EE7741 VA: 0x1EE7640
	public void OnHourChangeSetParam(int elapsedHour) { }

	// RVA: 0x1EE7650 Offset: 0x1EE7751 VA: 0x1EE7650
	public void .ctor() { }
}

public class HouseMaterialChangeTime : MonoBehaviour // TypeDefIndex: 10448
{
	// Fields
	[SerializeField] // RVA: 0x1818E0 Offset: 0x1819E1 VA: 0x1818E0
	private MaterialChangeTime[] _MaterialChangeTimes; // 0x18
	[SerializeField] // RVA: 0x1818F0 Offset: 0x1819F1 VA: 0x1818F0
	private TimeParamTable[] _TimeParamTables; // 0x20
	[SerializeField] // RVA: 0x181900 Offset: 0x181A01 VA: 0x181900
	private ObjectChangeTime[] _ObjectChangeTimes; // 0x28
	[SerializeField] // RVA: 0x181910 Offset: 0x181A11 VA: 0x181910
	private TimeParamTable[] _ObjectTimeParamTables; // 0x30
	[SerializeField] // RVA: 0x181920 Offset: 0x181A21 VA: 0x181920
	public bool IsVacant; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x181930 Offset: 0x181A31 VA: 0x181930
	private bool <IsSleeping>k__BackingField; // 0x39
	private int _HouseId; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x181940 Offset: 0x181A41 VA: 0x181940
	private HouseWindowMaterialType <HouseWindowMaterialType>k__BackingField; // 0x40

	// Properties
	public MaterialChangeTime[] MaterialChangeTimes { get; set; }
	public TimeParamTable[] TimeParamTables { get; set; }
	public ObjectChangeTime[] ObjectChangeTimes { get; set; }
	public TimeParamTable[] ObjectTimeParamTables { get; set; }
	[SerializeField] // RVA: 0x1B92C0 Offset: 0x1B93C1 VA: 0x1B92C0
	public bool IsSleeping { get; set; }
	public int HouseId { get; set; }
	public HouseWindowMaterialType HouseWindowMaterialType { get; set; }

	// Methods

	// RVA: 0x1EE6E90 Offset: 0x1EE6F91 VA: 0x1EE6E90
	public MaterialChangeTime[] get_MaterialChangeTimes() { }

	// RVA: 0x1EE6EA0 Offset: 0x1EE6FA1 VA: 0x1EE6EA0
	public void set_MaterialChangeTimes(MaterialChangeTime[] value) { }

	// RVA: 0x1EE6EB0 Offset: 0x1EE6FB1 VA: 0x1EE6EB0
	public TimeParamTable[] get_TimeParamTables() { }

	// RVA: 0x1EE6EC0 Offset: 0x1EE6FC1 VA: 0x1EE6EC0
	public void set_TimeParamTables(TimeParamTable[] value) { }

	// RVA: 0x1EE6ED0 Offset: 0x1EE6FD1 VA: 0x1EE6ED0
	public ObjectChangeTime[] get_ObjectChangeTimes() { }

	// RVA: 0x1EE6EE0 Offset: 0x1EE6FE1 VA: 0x1EE6EE0
	public void set_ObjectChangeTimes(ObjectChangeTime[] value) { }

	// RVA: 0x1EE6EF0 Offset: 0x1EE6FF1 VA: 0x1EE6EF0
	public TimeParamTable[] get_ObjectTimeParamTables() { }

	// RVA: 0x1EE6F00 Offset: 0x1EE7001 VA: 0x1EE6F00
	public void set_ObjectTimeParamTables(TimeParamTable[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF3F0 Offset: 0x1AF4F1 VA: 0x1AF3F0
	// RVA: 0x1EE6F10 Offset: 0x1EE7011 VA: 0x1EE6F10
	public bool get_IsSleeping() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF400 Offset: 0x1AF501 VA: 0x1AF400
	// RVA: 0x1EE6F20 Offset: 0x1EE7021 VA: 0x1EE6F20
	public void set_IsSleeping(bool value) { }

	// RVA: 0x1EE6F30 Offset: 0x1EE7031 VA: 0x1EE6F30
	public int get_HouseId() { }

	// RVA: 0x1EE6F40 Offset: 0x1EE7041 VA: 0x1EE6F40
	public void set_HouseId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF410 Offset: 0x1AF511 VA: 0x1AF410
	// RVA: 0x1EE6F50 Offset: 0x1EE7051 VA: 0x1EE6F50
	public HouseWindowMaterialType get_HouseWindowMaterialType() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF420 Offset: 0x1AF521 VA: 0x1AF420
	// RVA: 0x1EE6F60 Offset: 0x1EE7061 VA: 0x1EE6F60
	public void set_HouseWindowMaterialType(HouseWindowMaterialType value) { }

	// RVA: 0x1EE6F70 Offset: 0x1EE7071 VA: 0x1EE6F70
	private void OnDestroy() { }

	// RVA: 0x1EE7070 Offset: 0x1EE7171 VA: 0x1EE7070
	private void Awake() { }

	// RVA: 0x1EE7080 Offset: 0x1EE7181 VA: 0x1EE7080
	private void Start() { }

	// RVA: 0x1EE71B0 Offset: 0x1EE72B1 VA: 0x1EE71B0
	private void CheckHouseState(int houseId) { }

	// RVA: 0x1EE7400 Offset: 0x1EE7501 VA: 0x1EE7400
	private void SetHouseWindowTimeParam(TimeParamTable[] timeParamTables, MaterialChangeTime[] materialChangeTimes) { }

	// RVA: 0x1EE7480 Offset: 0x1EE7581 VA: 0x1EE7480
	private void SetHouseObjectTimeParam(TimeParamTable timeParamTable, ObjectChangeTime[] objectChangeTimes) { }

	// RVA: 0x1EE7640 Offset: 0x1EE7741 VA: 0x1EE7640
	public void OnHourChangeSetParam(int elapsedHour) { }

	// RVA: 0x1EE7650 Offset: 0x1EE7751 VA: 0x1EE7650
	public void .ctor() { }
}

