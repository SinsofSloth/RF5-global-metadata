[Serializable]
public class NodeData // TypeDefIndex: 4680
{
	// Fields
	[SerializeField] // RVA: 0x12D590 Offset: 0x12D691 VA: 0x12D590
	private object nodeDesigner; // 0x10
	[SerializeField] // RVA: 0x12D5A0 Offset: 0x12D6A1 VA: 0x12D5A0
	private Vector2 offset; // 0x18
	[SerializeField] // RVA: 0x12D5B0 Offset: 0x12D6B1 VA: 0x12D5B0
	private string friendlyName; // 0x20
	[SerializeField] // RVA: 0x12D5C0 Offset: 0x12D6C1 VA: 0x12D5C0
	private string comment; // 0x28
	[SerializeField] // RVA: 0x12D5D0 Offset: 0x12D6D1 VA: 0x12D5D0
	private bool isBreakpoint; // 0x30
	[SerializeField] // RVA: 0x12D5E0 Offset: 0x12D6E1 VA: 0x12D5E0
	private Texture icon; // 0x38
	[SerializeField] // RVA: 0x12D5F0 Offset: 0x12D6F1 VA: 0x12D5F0
	private bool collapsed; // 0x40
	[SerializeField] // RVA: 0x12D600 Offset: 0x12D701 VA: 0x12D600
	private int colorIndex; // 0x44
	[SerializeField] // RVA: 0x12D610 Offset: 0x12D711 VA: 0x12D610
	private List<string> watchedFieldNames; // 0x48
	private List<FieldInfo> watchedFields; // 0x50
	private float pushTime; // 0x58
	private float popTime; // 0x5C
	private float interruptTime; // 0x60
	private bool isReevaluating; // 0x64
	private TaskStatus executionStatus; // 0x68

	// Properties
	public Vector2 Offset { get; set; }
	public string Comment { set; }
	public bool IsBreakpoint { get; set; }
	public bool Collapsed { set; }
	public int ColorIndex { set; }
	public List<string> WatchedFieldNames { get; set; }
	public List<FieldInfo> WatchedFields { get; set; }
	public float PushTime { set; }
	public float PopTime { set; }
	public float InterruptTime { set; }
	public bool IsReevaluating { get; set; }
	public TaskStatus ExecutionStatus { get; set; }

	// Methods

	// RVA: 0x1B22000 Offset: 0x1B22101 VA: 0x1B22000
	public void .ctor() { }

	// RVA: 0x1B220A0 Offset: 0x1B221A1 VA: 0x1B220A0
	public Vector2 get_Offset() { }

	// RVA: 0x1B220B0 Offset: 0x1B221B1 VA: 0x1B220B0
	public void set_Offset(Vector2 value) { }

	// RVA: 0x1B220C0 Offset: 0x1B221C1 VA: 0x1B220C0
	public void set_Comment(string value) { }

	// RVA: 0x1B220D0 Offset: 0x1B221D1 VA: 0x1B220D0
	public bool get_IsBreakpoint() { }

	// RVA: 0x1B220E0 Offset: 0x1B221E1 VA: 0x1B220E0
	public void set_IsBreakpoint(bool value) { }

	// RVA: 0x1B220F0 Offset: 0x1B221F1 VA: 0x1B220F0
	public void set_Collapsed(bool value) { }

	// RVA: 0x1B22100 Offset: 0x1B22201 VA: 0x1B22100
	public void set_ColorIndex(int value) { }

	// RVA: 0x1B22110 Offset: 0x1B22211 VA: 0x1B22110
	public List<string> get_WatchedFieldNames() { }

	// RVA: 0x1B22120 Offset: 0x1B22221 VA: 0x1B22120
	public void set_WatchedFieldNames(List<string> value) { }

	// RVA: 0x1B22130 Offset: 0x1B22231 VA: 0x1B22130
	public List<FieldInfo> get_WatchedFields() { }

	// RVA: 0x1B22140 Offset: 0x1B22241 VA: 0x1B22140
	public void set_WatchedFields(List<FieldInfo> value) { }

	// RVA: 0x1B22150 Offset: 0x1B22251 VA: 0x1B22150
	public void set_PushTime(float value) { }

	// RVA: 0x1B22160 Offset: 0x1B22261 VA: 0x1B22160
	public void set_PopTime(float value) { }

	// RVA: 0x1B22170 Offset: 0x1B22271 VA: 0x1B22170
	public void set_InterruptTime(float value) { }

	// RVA: 0x1B22180 Offset: 0x1B22281 VA: 0x1B22180
	public bool get_IsReevaluating() { }

	// RVA: 0x1B22190 Offset: 0x1B22291 VA: 0x1B22190
	public void set_IsReevaluating(bool value) { }

	// RVA: 0x1B221A0 Offset: 0x1B222A1 VA: 0x1B221A0
	public TaskStatus get_ExecutionStatus() { }

	// RVA: 0x1B221B0 Offset: 0x1B222B1 VA: 0x1B221B0
	public void set_ExecutionStatus(TaskStatus value) { }
}

[Serializable]
public class NodeData // TypeDefIndex: 4680
{
	// Fields
	[SerializeField] // RVA: 0x12D590 Offset: 0x12D691 VA: 0x12D590
	private object nodeDesigner; // 0x10
	[SerializeField] // RVA: 0x12D5A0 Offset: 0x12D6A1 VA: 0x12D5A0
	private Vector2 offset; // 0x18
	[SerializeField] // RVA: 0x12D5B0 Offset: 0x12D6B1 VA: 0x12D5B0
	private string friendlyName; // 0x20
	[SerializeField] // RVA: 0x12D5C0 Offset: 0x12D6C1 VA: 0x12D5C0
	private string comment; // 0x28
	[SerializeField] // RVA: 0x12D5D0 Offset: 0x12D6D1 VA: 0x12D5D0
	private bool isBreakpoint; // 0x30
	[SerializeField] // RVA: 0x12D5E0 Offset: 0x12D6E1 VA: 0x12D5E0
	private Texture icon; // 0x38
	[SerializeField] // RVA: 0x12D5F0 Offset: 0x12D6F1 VA: 0x12D5F0
	private bool collapsed; // 0x40
	[SerializeField] // RVA: 0x12D600 Offset: 0x12D701 VA: 0x12D600
	private int colorIndex; // 0x44
	[SerializeField] // RVA: 0x12D610 Offset: 0x12D711 VA: 0x12D610
	private List<string> watchedFieldNames; // 0x48
	private List<FieldInfo> watchedFields; // 0x50
	private float pushTime; // 0x58
	private float popTime; // 0x5C
	private float interruptTime; // 0x60
	private bool isReevaluating; // 0x64
	private TaskStatus executionStatus; // 0x68

	// Properties
	public Vector2 Offset { get; set; }
	public string Comment { set; }
	public bool IsBreakpoint { get; set; }
	public bool Collapsed { set; }
	public int ColorIndex { set; }
	public List<string> WatchedFieldNames { get; set; }
	public List<FieldInfo> WatchedFields { get; set; }
	public float PushTime { set; }
	public float PopTime { set; }
	public float InterruptTime { set; }
	public bool IsReevaluating { get; set; }
	public TaskStatus ExecutionStatus { get; set; }

	// Methods

	// RVA: 0x1B22000 Offset: 0x1B22101 VA: 0x1B22000
	public void .ctor() { }

	// RVA: 0x1B220A0 Offset: 0x1B221A1 VA: 0x1B220A0
	public Vector2 get_Offset() { }

	// RVA: 0x1B220B0 Offset: 0x1B221B1 VA: 0x1B220B0
	public void set_Offset(Vector2 value) { }

	// RVA: 0x1B220C0 Offset: 0x1B221C1 VA: 0x1B220C0
	public void set_Comment(string value) { }

	// RVA: 0x1B220D0 Offset: 0x1B221D1 VA: 0x1B220D0
	public bool get_IsBreakpoint() { }

	// RVA: 0x1B220E0 Offset: 0x1B221E1 VA: 0x1B220E0
	public void set_IsBreakpoint(bool value) { }

	// RVA: 0x1B220F0 Offset: 0x1B221F1 VA: 0x1B220F0
	public void set_Collapsed(bool value) { }

	// RVA: 0x1B22100 Offset: 0x1B22201 VA: 0x1B22100
	public void set_ColorIndex(int value) { }

	// RVA: 0x1B22110 Offset: 0x1B22211 VA: 0x1B22110
	public List<string> get_WatchedFieldNames() { }

	// RVA: 0x1B22120 Offset: 0x1B22221 VA: 0x1B22120
	public void set_WatchedFieldNames(List<string> value) { }

	// RVA: 0x1B22130 Offset: 0x1B22231 VA: 0x1B22130
	public List<FieldInfo> get_WatchedFields() { }

	// RVA: 0x1B22140 Offset: 0x1B22241 VA: 0x1B22140
	public void set_WatchedFields(List<FieldInfo> value) { }

	// RVA: 0x1B22150 Offset: 0x1B22251 VA: 0x1B22150
	public void set_PushTime(float value) { }

	// RVA: 0x1B22160 Offset: 0x1B22261 VA: 0x1B22160
	public void set_PopTime(float value) { }

	// RVA: 0x1B22170 Offset: 0x1B22271 VA: 0x1B22170
	public void set_InterruptTime(float value) { }

	// RVA: 0x1B22180 Offset: 0x1B22281 VA: 0x1B22180
	public bool get_IsReevaluating() { }

	// RVA: 0x1B22190 Offset: 0x1B22291 VA: 0x1B22190
	public void set_IsReevaluating(bool value) { }

	// RVA: 0x1B221A0 Offset: 0x1B222A1 VA: 0x1B221A0
	public TaskStatus get_ExecutionStatus() { }

	// RVA: 0x1B221B0 Offset: 0x1B222B1 VA: 0x1B221B0
	public void set_ExecutionStatus(TaskStatus value) { }
}

[Serializable]
public class NodeData // TypeDefIndex: 4680
{
	// Fields
	[SerializeField] // RVA: 0x12D590 Offset: 0x12D691 VA: 0x12D590
	private object nodeDesigner; // 0x10
	[SerializeField] // RVA: 0x12D5A0 Offset: 0x12D6A1 VA: 0x12D5A0
	private Vector2 offset; // 0x18
	[SerializeField] // RVA: 0x12D5B0 Offset: 0x12D6B1 VA: 0x12D5B0
	private string friendlyName; // 0x20
	[SerializeField] // RVA: 0x12D5C0 Offset: 0x12D6C1 VA: 0x12D5C0
	private string comment; // 0x28
	[SerializeField] // RVA: 0x12D5D0 Offset: 0x12D6D1 VA: 0x12D5D0
	private bool isBreakpoint; // 0x30
	[SerializeField] // RVA: 0x12D5E0 Offset: 0x12D6E1 VA: 0x12D5E0
	private Texture icon; // 0x38
	[SerializeField] // RVA: 0x12D5F0 Offset: 0x12D6F1 VA: 0x12D5F0
	private bool collapsed; // 0x40
	[SerializeField] // RVA: 0x12D600 Offset: 0x12D701 VA: 0x12D600
	private int colorIndex; // 0x44
	[SerializeField] // RVA: 0x12D610 Offset: 0x12D711 VA: 0x12D610
	private List<string> watchedFieldNames; // 0x48
	private List<FieldInfo> watchedFields; // 0x50
	private float pushTime; // 0x58
	private float popTime; // 0x5C
	private float interruptTime; // 0x60
	private bool isReevaluating; // 0x64
	private TaskStatus executionStatus; // 0x68

	// Properties
	public Vector2 Offset { get; set; }
	public string Comment { set; }
	public bool IsBreakpoint { get; set; }
	public bool Collapsed { set; }
	public int ColorIndex { set; }
	public List<string> WatchedFieldNames { get; set; }
	public List<FieldInfo> WatchedFields { get; set; }
	public float PushTime { set; }
	public float PopTime { set; }
	public float InterruptTime { set; }
	public bool IsReevaluating { get; set; }
	public TaskStatus ExecutionStatus { get; set; }

	// Methods

	// RVA: 0x1B22000 Offset: 0x1B22101 VA: 0x1B22000
	public void .ctor() { }

	// RVA: 0x1B220A0 Offset: 0x1B221A1 VA: 0x1B220A0
	public Vector2 get_Offset() { }

	// RVA: 0x1B220B0 Offset: 0x1B221B1 VA: 0x1B220B0
	public void set_Offset(Vector2 value) { }

	// RVA: 0x1B220C0 Offset: 0x1B221C1 VA: 0x1B220C0
	public void set_Comment(string value) { }

	// RVA: 0x1B220D0 Offset: 0x1B221D1 VA: 0x1B220D0
	public bool get_IsBreakpoint() { }

	// RVA: 0x1B220E0 Offset: 0x1B221E1 VA: 0x1B220E0
	public void set_IsBreakpoint(bool value) { }

	// RVA: 0x1B220F0 Offset: 0x1B221F1 VA: 0x1B220F0
	public void set_Collapsed(bool value) { }

	// RVA: 0x1B22100 Offset: 0x1B22201 VA: 0x1B22100
	public void set_ColorIndex(int value) { }

	// RVA: 0x1B22110 Offset: 0x1B22211 VA: 0x1B22110
	public List<string> get_WatchedFieldNames() { }

	// RVA: 0x1B22120 Offset: 0x1B22221 VA: 0x1B22120
	public void set_WatchedFieldNames(List<string> value) { }

	// RVA: 0x1B22130 Offset: 0x1B22231 VA: 0x1B22130
	public List<FieldInfo> get_WatchedFields() { }

	// RVA: 0x1B22140 Offset: 0x1B22241 VA: 0x1B22140
	public void set_WatchedFields(List<FieldInfo> value) { }

	// RVA: 0x1B22150 Offset: 0x1B22251 VA: 0x1B22150
	public void set_PushTime(float value) { }

	// RVA: 0x1B22160 Offset: 0x1B22261 VA: 0x1B22160
	public void set_PopTime(float value) { }

	// RVA: 0x1B22170 Offset: 0x1B22271 VA: 0x1B22170
	public void set_InterruptTime(float value) { }

	// RVA: 0x1B22180 Offset: 0x1B22281 VA: 0x1B22180
	public bool get_IsReevaluating() { }

	// RVA: 0x1B22190 Offset: 0x1B22291 VA: 0x1B22190
	public void set_IsReevaluating(bool value) { }

	// RVA: 0x1B221A0 Offset: 0x1B222A1 VA: 0x1B221A0
	public TaskStatus get_ExecutionStatus() { }

	// RVA: 0x1B221B0 Offset: 0x1B222B1 VA: 0x1B221B0
	public void set_ExecutionStatus(TaskStatus value) { }
}

[Serializable]
public class NodeData // TypeDefIndex: 4680
{
	// Fields
	[SerializeField] // RVA: 0x12D590 Offset: 0x12D691 VA: 0x12D590
	private object nodeDesigner; // 0x10
	[SerializeField] // RVA: 0x12D5A0 Offset: 0x12D6A1 VA: 0x12D5A0
	private Vector2 offset; // 0x18
	[SerializeField] // RVA: 0x12D5B0 Offset: 0x12D6B1 VA: 0x12D5B0
	private string friendlyName; // 0x20
	[SerializeField] // RVA: 0x12D5C0 Offset: 0x12D6C1 VA: 0x12D5C0
	private string comment; // 0x28
	[SerializeField] // RVA: 0x12D5D0 Offset: 0x12D6D1 VA: 0x12D5D0
	private bool isBreakpoint; // 0x30
	[SerializeField] // RVA: 0x12D5E0 Offset: 0x12D6E1 VA: 0x12D5E0
	private Texture icon; // 0x38
	[SerializeField] // RVA: 0x12D5F0 Offset: 0x12D6F1 VA: 0x12D5F0
	private bool collapsed; // 0x40
	[SerializeField] // RVA: 0x12D600 Offset: 0x12D701 VA: 0x12D600
	private int colorIndex; // 0x44
	[SerializeField] // RVA: 0x12D610 Offset: 0x12D711 VA: 0x12D610
	private List<string> watchedFieldNames; // 0x48
	private List<FieldInfo> watchedFields; // 0x50
	private float pushTime; // 0x58
	private float popTime; // 0x5C
	private float interruptTime; // 0x60
	private bool isReevaluating; // 0x64
	private TaskStatus executionStatus; // 0x68

	// Properties
	public Vector2 Offset { get; set; }
	public string Comment { set; }
	public bool IsBreakpoint { get; set; }
	public bool Collapsed { set; }
	public int ColorIndex { set; }
	public List<string> WatchedFieldNames { get; set; }
	public List<FieldInfo> WatchedFields { get; set; }
	public float PushTime { set; }
	public float PopTime { set; }
	public float InterruptTime { set; }
	public bool IsReevaluating { get; set; }
	public TaskStatus ExecutionStatus { get; set; }

	// Methods

	// RVA: 0x1B22000 Offset: 0x1B22101 VA: 0x1B22000
	public void .ctor() { }

	// RVA: 0x1B220A0 Offset: 0x1B221A1 VA: 0x1B220A0
	public Vector2 get_Offset() { }

	// RVA: 0x1B220B0 Offset: 0x1B221B1 VA: 0x1B220B0
	public void set_Offset(Vector2 value) { }

	// RVA: 0x1B220C0 Offset: 0x1B221C1 VA: 0x1B220C0
	public void set_Comment(string value) { }

	// RVA: 0x1B220D0 Offset: 0x1B221D1 VA: 0x1B220D0
	public bool get_IsBreakpoint() { }

	// RVA: 0x1B220E0 Offset: 0x1B221E1 VA: 0x1B220E0
	public void set_IsBreakpoint(bool value) { }

	// RVA: 0x1B220F0 Offset: 0x1B221F1 VA: 0x1B220F0
	public void set_Collapsed(bool value) { }

	// RVA: 0x1B22100 Offset: 0x1B22201 VA: 0x1B22100
	public void set_ColorIndex(int value) { }

	// RVA: 0x1B22110 Offset: 0x1B22211 VA: 0x1B22110
	public List<string> get_WatchedFieldNames() { }

	// RVA: 0x1B22120 Offset: 0x1B22221 VA: 0x1B22120
	public void set_WatchedFieldNames(List<string> value) { }

	// RVA: 0x1B22130 Offset: 0x1B22231 VA: 0x1B22130
	public List<FieldInfo> get_WatchedFields() { }

	// RVA: 0x1B22140 Offset: 0x1B22241 VA: 0x1B22140
	public void set_WatchedFields(List<FieldInfo> value) { }

	// RVA: 0x1B22150 Offset: 0x1B22251 VA: 0x1B22150
	public void set_PushTime(float value) { }

	// RVA: 0x1B22160 Offset: 0x1B22261 VA: 0x1B22160
	public void set_PopTime(float value) { }

	// RVA: 0x1B22170 Offset: 0x1B22271 VA: 0x1B22170
	public void set_InterruptTime(float value) { }

	// RVA: 0x1B22180 Offset: 0x1B22281 VA: 0x1B22180
	public bool get_IsReevaluating() { }

	// RVA: 0x1B22190 Offset: 0x1B22291 VA: 0x1B22190
	public void set_IsReevaluating(bool value) { }

	// RVA: 0x1B221A0 Offset: 0x1B222A1 VA: 0x1B221A0
	public TaskStatus get_ExecutionStatus() { }

	// RVA: 0x1B221B0 Offset: 0x1B222B1 VA: 0x1B221B0
	public void set_ExecutionStatus(TaskStatus value) { }
}

[Serializable]
public class NodeData // TypeDefIndex: 4680
{
	// Fields
	[SerializeField] // RVA: 0x12D590 Offset: 0x12D691 VA: 0x12D590
	private object nodeDesigner; // 0x10
	[SerializeField] // RVA: 0x12D5A0 Offset: 0x12D6A1 VA: 0x12D5A0
	private Vector2 offset; // 0x18
	[SerializeField] // RVA: 0x12D5B0 Offset: 0x12D6B1 VA: 0x12D5B0
	private string friendlyName; // 0x20
	[SerializeField] // RVA: 0x12D5C0 Offset: 0x12D6C1 VA: 0x12D5C0
	private string comment; // 0x28
	[SerializeField] // RVA: 0x12D5D0 Offset: 0x12D6D1 VA: 0x12D5D0
	private bool isBreakpoint; // 0x30
	[SerializeField] // RVA: 0x12D5E0 Offset: 0x12D6E1 VA: 0x12D5E0
	private Texture icon; // 0x38
	[SerializeField] // RVA: 0x12D5F0 Offset: 0x12D6F1 VA: 0x12D5F0
	private bool collapsed; // 0x40
	[SerializeField] // RVA: 0x12D600 Offset: 0x12D701 VA: 0x12D600
	private int colorIndex; // 0x44
	[SerializeField] // RVA: 0x12D610 Offset: 0x12D711 VA: 0x12D610
	private List<string> watchedFieldNames; // 0x48
	private List<FieldInfo> watchedFields; // 0x50
	private float pushTime; // 0x58
	private float popTime; // 0x5C
	private float interruptTime; // 0x60
	private bool isReevaluating; // 0x64
	private TaskStatus executionStatus; // 0x68

	// Properties
	public Vector2 Offset { get; set; }
	public string Comment { set; }
	public bool IsBreakpoint { get; set; }
	public bool Collapsed { set; }
	public int ColorIndex { set; }
	public List<string> WatchedFieldNames { get; set; }
	public List<FieldInfo> WatchedFields { get; set; }
	public float PushTime { set; }
	public float PopTime { set; }
	public float InterruptTime { set; }
	public bool IsReevaluating { get; set; }
	public TaskStatus ExecutionStatus { get; set; }

	// Methods

	// RVA: 0x1B22000 Offset: 0x1B22101 VA: 0x1B22000
	public void .ctor() { }

	// RVA: 0x1B220A0 Offset: 0x1B221A1 VA: 0x1B220A0
	public Vector2 get_Offset() { }

	// RVA: 0x1B220B0 Offset: 0x1B221B1 VA: 0x1B220B0
	public void set_Offset(Vector2 value) { }

	// RVA: 0x1B220C0 Offset: 0x1B221C1 VA: 0x1B220C0
	public void set_Comment(string value) { }

	// RVA: 0x1B220D0 Offset: 0x1B221D1 VA: 0x1B220D0
	public bool get_IsBreakpoint() { }

	// RVA: 0x1B220E0 Offset: 0x1B221E1 VA: 0x1B220E0
	public void set_IsBreakpoint(bool value) { }

	// RVA: 0x1B220F0 Offset: 0x1B221F1 VA: 0x1B220F0
	public void set_Collapsed(bool value) { }

	// RVA: 0x1B22100 Offset: 0x1B22201 VA: 0x1B22100
	public void set_ColorIndex(int value) { }

	// RVA: 0x1B22110 Offset: 0x1B22211 VA: 0x1B22110
	public List<string> get_WatchedFieldNames() { }

	// RVA: 0x1B22120 Offset: 0x1B22221 VA: 0x1B22120
	public void set_WatchedFieldNames(List<string> value) { }

	// RVA: 0x1B22130 Offset: 0x1B22231 VA: 0x1B22130
	public List<FieldInfo> get_WatchedFields() { }

	// RVA: 0x1B22140 Offset: 0x1B22241 VA: 0x1B22140
	public void set_WatchedFields(List<FieldInfo> value) { }

	// RVA: 0x1B22150 Offset: 0x1B22251 VA: 0x1B22150
	public void set_PushTime(float value) { }

	// RVA: 0x1B22160 Offset: 0x1B22261 VA: 0x1B22160
	public void set_PopTime(float value) { }

	// RVA: 0x1B22170 Offset: 0x1B22271 VA: 0x1B22170
	public void set_InterruptTime(float value) { }

	// RVA: 0x1B22180 Offset: 0x1B22281 VA: 0x1B22180
	public bool get_IsReevaluating() { }

	// RVA: 0x1B22190 Offset: 0x1B22291 VA: 0x1B22190
	public void set_IsReevaluating(bool value) { }

	// RVA: 0x1B221A0 Offset: 0x1B222A1 VA: 0x1B221A0
	public TaskStatus get_ExecutionStatus() { }

	// RVA: 0x1B221B0 Offset: 0x1B222B1 VA: 0x1B221B0
	public void set_ExecutionStatus(TaskStatus value) { }
}

[Serializable]
public class NodeData // TypeDefIndex: 4680
{
	// Fields
	[SerializeField] // RVA: 0x12D590 Offset: 0x12D691 VA: 0x12D590
	private object nodeDesigner; // 0x10
	[SerializeField] // RVA: 0x12D5A0 Offset: 0x12D6A1 VA: 0x12D5A0
	private Vector2 offset; // 0x18
	[SerializeField] // RVA: 0x12D5B0 Offset: 0x12D6B1 VA: 0x12D5B0
	private string friendlyName; // 0x20
	[SerializeField] // RVA: 0x12D5C0 Offset: 0x12D6C1 VA: 0x12D5C0
	private string comment; // 0x28
	[SerializeField] // RVA: 0x12D5D0 Offset: 0x12D6D1 VA: 0x12D5D0
	private bool isBreakpoint; // 0x30
	[SerializeField] // RVA: 0x12D5E0 Offset: 0x12D6E1 VA: 0x12D5E0
	private Texture icon; // 0x38
	[SerializeField] // RVA: 0x12D5F0 Offset: 0x12D6F1 VA: 0x12D5F0
	private bool collapsed; // 0x40
	[SerializeField] // RVA: 0x12D600 Offset: 0x12D701 VA: 0x12D600
	private int colorIndex; // 0x44
	[SerializeField] // RVA: 0x12D610 Offset: 0x12D711 VA: 0x12D610
	private List<string> watchedFieldNames; // 0x48
	private List<FieldInfo> watchedFields; // 0x50
	private float pushTime; // 0x58
	private float popTime; // 0x5C
	private float interruptTime; // 0x60
	private bool isReevaluating; // 0x64
	private TaskStatus executionStatus; // 0x68

	// Properties
	public Vector2 Offset { get; set; }
	public string Comment { set; }
	public bool IsBreakpoint { get; set; }
	public bool Collapsed { set; }
	public int ColorIndex { set; }
	public List<string> WatchedFieldNames { get; set; }
	public List<FieldInfo> WatchedFields { get; set; }
	public float PushTime { set; }
	public float PopTime { set; }
	public float InterruptTime { set; }
	public bool IsReevaluating { get; set; }
	public TaskStatus ExecutionStatus { get; set; }

	// Methods

	// RVA: 0x1B22000 Offset: 0x1B22101 VA: 0x1B22000
	public void .ctor() { }

	// RVA: 0x1B220A0 Offset: 0x1B221A1 VA: 0x1B220A0
	public Vector2 get_Offset() { }

	// RVA: 0x1B220B0 Offset: 0x1B221B1 VA: 0x1B220B0
	public void set_Offset(Vector2 value) { }

	// RVA: 0x1B220C0 Offset: 0x1B221C1 VA: 0x1B220C0
	public void set_Comment(string value) { }

	// RVA: 0x1B220D0 Offset: 0x1B221D1 VA: 0x1B220D0
	public bool get_IsBreakpoint() { }

	// RVA: 0x1B220E0 Offset: 0x1B221E1 VA: 0x1B220E0
	public void set_IsBreakpoint(bool value) { }

	// RVA: 0x1B220F0 Offset: 0x1B221F1 VA: 0x1B220F0
	public void set_Collapsed(bool value) { }

	// RVA: 0x1B22100 Offset: 0x1B22201 VA: 0x1B22100
	public void set_ColorIndex(int value) { }

	// RVA: 0x1B22110 Offset: 0x1B22211 VA: 0x1B22110
	public List<string> get_WatchedFieldNames() { }

	// RVA: 0x1B22120 Offset: 0x1B22221 VA: 0x1B22120
	public void set_WatchedFieldNames(List<string> value) { }

	// RVA: 0x1B22130 Offset: 0x1B22231 VA: 0x1B22130
	public List<FieldInfo> get_WatchedFields() { }

	// RVA: 0x1B22140 Offset: 0x1B22241 VA: 0x1B22140
	public void set_WatchedFields(List<FieldInfo> value) { }

	// RVA: 0x1B22150 Offset: 0x1B22251 VA: 0x1B22150
	public void set_PushTime(float value) { }

	// RVA: 0x1B22160 Offset: 0x1B22261 VA: 0x1B22160
	public void set_PopTime(float value) { }

	// RVA: 0x1B22170 Offset: 0x1B22271 VA: 0x1B22170
	public void set_InterruptTime(float value) { }

	// RVA: 0x1B22180 Offset: 0x1B22281 VA: 0x1B22180
	public bool get_IsReevaluating() { }

	// RVA: 0x1B22190 Offset: 0x1B22291 VA: 0x1B22190
	public void set_IsReevaluating(bool value) { }

	// RVA: 0x1B221A0 Offset: 0x1B222A1 VA: 0x1B221A0
	public TaskStatus get_ExecutionStatus() { }

	// RVA: 0x1B221B0 Offset: 0x1B222B1 VA: 0x1B221B0
	public void set_ExecutionStatus(TaskStatus value) { }
}

